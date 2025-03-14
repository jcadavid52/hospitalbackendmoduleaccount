using FluentValidation;
using HospitalModuleAccount.Application.Account.CommandHandler.Command;

namespace HospitalModuleAccount.Api.ApiHandlers.AccountApi
{
    public class AccountUserRegisterCommandValidator: AbstractValidator<AccountRegisterCommand>
    {
        public AccountUserRegisterCommandValidator()
        {
            RuleFor(command => command.fullName)
         .NotEmpty()
         .WithMessage("El campo usuario no puede estar vacío");

        }
    }
}
