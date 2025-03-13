using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using MediatR;

namespace HospitalModuleAccount.Application.Account.CommandHandler.Command
{
    public record AccountLoginCommand(string userName, string password) : IRequest<ResponseAccessDto>;

}
