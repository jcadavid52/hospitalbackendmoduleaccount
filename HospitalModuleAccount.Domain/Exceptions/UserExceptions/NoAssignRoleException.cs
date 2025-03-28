﻿

using HospitalModuleAccount.Domain.Exceptions;

namespace HospitalModuleAccount.Domain.Exceptions.UserExceptions
{
    public class NoAssignRoleException : CoreBusinessException
    {
        public NoAssignRoleException()
        {
        }

        public NoAssignRoleException(string msg) : base(msg)
        {
        }

        public NoAssignRoleException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
