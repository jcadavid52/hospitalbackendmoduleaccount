
using HospitalModuleAccount.Application.Account.CommandHandler.Command;
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using HospitalModuleAccount.Domain.Entities.AccountUser.Service;
using MediatR;

namespace HospitalModuleAccount.Application.Account.CommandHandler.Handler
{
    public class AccountLoginCommandHandler : IRequestHandler<AccountLoginCommand, ResponseAccessDto>
    {
        private readonly AccountUserLoginService _service;

        public AccountLoginCommandHandler(AccountUserLoginService service)
        {
            _service = service;
        }
        public async Task<ResponseAccessDto> Handle(AccountLoginCommand request, CancellationToken cancellationToken)
        {
            return await _service.ExecuteAsync(request.userName, request.password);


        }
    }
}
