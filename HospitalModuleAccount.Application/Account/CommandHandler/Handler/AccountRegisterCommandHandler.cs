
using HospitalModuleAccount.Application.Account.CommandHandler.Command;
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Entity;
using HospitalModuleAccount.Domain.Entities.AccountUser.Service;
using MediatR;

namespace HospitalModuleAccount.Application.Account.CommandHandler.Handler
{
    public class AccountRegisterCommandHandler : IRequestHandler<AccountRegisterCommand, AccountUserDto>
    {
        private readonly AccountUserResgisterService _userResgisterService;

        public AccountRegisterCommandHandler(AccountUserResgisterService userResgisterService)
        {
            _userResgisterService = userResgisterService;
        }
        public async Task<AccountUserDto> Handle(AccountRegisterCommand request, CancellationToken cancellationToken)
        {
            var userDomain = new AccountUserEntity(request.fullName, request.email, request.email,
               request.PhoneNumber, request.age, request.address);

            return await _userResgisterService.ExecuteRegisterAsync(userDomain, request.confirmPassword);
        }
    }
}
