using HospitalModuleAccount.Application.Account.CommandHandler.Command;
using HospitalModuleAccount.Application.Account.QueryHandler.Query;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalModuleAccount.Api.ApiHandlers.AccountApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] AccountRegisterCommand command)
        {
            var resultRegister = await _mediator.Send(command);

            return StatusCode(201, resultRegister);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] AccountLoginCommand command)
        {
            var resultAccess = await _mediator.Send(command);

            return Ok(resultAccess);
        }

        [HttpGet ("StatusAuth")]
        [Authorize]
        public async Task<IActionResult> StatusAuth(string id)
        {
            var user = await _mediator.Send(new AccountFindByIdQuery(id));
            return Ok(user);
        }
    }
}
