﻿

using HospitalModuleAccount.Domain.Exceptions;

namespace HospitalModuleAccount.Domain.Exceptions.UserExceptions
{
    public class NoAuthenticateException : CoreBusinessException
    {
        public NoAuthenticateException()
        {
        }

        public NoAuthenticateException(string msg) : base(msg)
        {
        }

        public NoAuthenticateException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
