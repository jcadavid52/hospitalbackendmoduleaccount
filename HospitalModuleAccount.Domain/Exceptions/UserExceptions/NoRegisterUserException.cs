
using HospitalModuleAccount.Domain.Exceptions;

namespace HospitalModuleAccount.Domain.Exceptions.UserExceptions
{
    public class NoRegisterUserException : CoreBusinessException
    {
        public NoRegisterUserException()
        {
        }

        public NoRegisterUserException(string msg) : base(msg)
        {
        }

        public NoRegisterUserException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
