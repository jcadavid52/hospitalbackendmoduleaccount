using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using MediatR;

namespace HospitalModuleAccount.Application.Account.QueryHandler.Query
{
    public record AccountFindByIdQuery(string id):IRequest<AccountUserDto>;
    
}
