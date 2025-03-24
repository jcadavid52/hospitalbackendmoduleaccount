using FluentValidation;
using HospitalModuleAccount.Application.Account.CommandHandler.Command;

namespace HospitalModuleAccount.Api.ApiHandlers.AccountApi
{
    public class AccountUserLoginCommandValidator:AbstractValidator<AccountLoginCommand>
    {
        public AccountUserLoginCommandValidator()
        {
            RuleFor(x => x.userName)
                .NotEmpty().WithMessage("El campo username es requerido");

            RuleFor(x => x.password)
              .NotEmpty().WithMessage("El campo password es requerido");
        }
    }
}
