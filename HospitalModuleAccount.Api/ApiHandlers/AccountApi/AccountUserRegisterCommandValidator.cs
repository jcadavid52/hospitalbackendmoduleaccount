using FluentValidation;
using HospitalModuleAccount.Application.Account.CommandHandler.Command;

namespace HospitalModuleAccount.Api.ApiHandlers.AccountApi
{
    public class AccountUserRegisterCommandValidator: AbstractValidator<AccountRegisterCommand>
    {
        const int minimalLengthFullName = 2;
        const int minimalLengthPhoneNumber = 10;
        const int minimalLengthAddress = 5;
        const int minimalLengthEmail = 6;
        const int minimalAge = 1;
        const int minimalLengthPassword = 7;
        public AccountUserRegisterCommandValidator()
        {
            RuleFor(x => x.fullName)
             .NotEmpty()
             .WithMessage("El campo 'fullName' no puede estar vacío")
             .MinimumLength(minimalLengthFullName).WithMessage($"El nombre debe tener al menos {minimalLengthFullName} caracteres.");

            RuleFor(x => x.age)
              .NotNull().WithMessage("La edad no puede estar vacía.")
              .GreaterThanOrEqualTo(minimalAge).WithMessage($"La edad no puede ser menor a {minimalAge} año.");

            RuleFor(x => x.address)
               .NotEmpty().WithMessage("La dirección es obligatoria")
               .MinimumLength(minimalLengthAddress).WithMessage($"La dirección debe ser de mínimo {minimalLengthAddress} caracteres");

            RuleFor(x => x.email)
               .NotEmpty().WithMessage("El correo electrónico no puede estar vacío.")
               .EmailAddress().WithMessage("El correo electrónico no tiene un formato válido.")
               .MinimumLength(minimalLengthEmail).WithMessage($"El correo electrónico debe tener una longitud mínima de {minimalLengthEmail} caracteres.");

            RuleFor(x => x.PhoneNumber)
               .NotEmpty().WithMessage("El número de teléfono es obligatorio")
               .MinimumLength(minimalLengthPhoneNumber).WithMessage($"El número de teléfono no puede ser menor a {minimalLengthPhoneNumber} dígitos")
               .MaximumLength(minimalLengthPhoneNumber).WithMessage($"El número de teléfono no puede ser mayor a {minimalLengthPhoneNumber} dígitos")
               .Matches(@"^\d+$").WithMessage("El número de teléfono solo puede contener dígitos.");

            RuleFor(x => x.password)
               .NotEmpty().WithMessage("La contraseña es requerida.")
               .Matches(@"[A-Z]").WithMessage("La contraseña debe contener al menos una letra mayúscula.")
               .Matches(@"[0-9]").WithMessage("La contraseña debe contener al menos un número.")
               .Matches(@"[\W_]").WithMessage("La contraseña debe contener al menos un carácter especial.")
               .MinimumLength(mini).WithMessage($"La contraseña debe tener al menos {minimalLengthPassword} caracteres.");

            RuleFor(x => x.confirmPassword)
                .NotEmpty().WithMessage("La confirmación de la contraseña es requerida.")
                .Equal(x => x.password).WithMessage("Las contraseñas no coinciden.");

        }
    }
}
