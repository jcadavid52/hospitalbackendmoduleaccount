

using HospitalModuleAccount.Application.Account.QueryHandler.Query;
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using HospitalModuleAccount.Domain.Entities.AccountUser.Port.InterfacesRepositories;
using HospitalModuleAccount.Domain.Exceptions;
using MediatR;

namespace HospitalModuleAccount.Application.Account.QueryHandler.Handler
{
    public class AccountFindByIdQueryHandler(IAccountUserRepository repository) : IRequestHandler<AccountFindByIdQuery, AccountUserDto>
    {
        public async Task<AccountUserDto> Handle(AccountFindByIdQuery request, CancellationToken cancellationToken)
        {
            var resultAccount = await repository.GetAccountUserById(request.id);

            if (resultAccount.User == null)
            {
                throw new NotFoundException($"No se encontró recurso con el id: '{request.id}'");
            }

            var roles = await repository.GetAccountUserRoles(resultAccount.User);

            return new AccountUserDto(resultAccount.User.Id,
                                      resultAccount.User.FullName,
                                      resultAccount.User.UserName,
                                      resultAccount.User.Email,
                                      resultAccount.User.PhoneNumber,
                                      resultAccount.User.Age,
                                      resultAccount.User.Address,
                                      roles);
        }
    }
}
