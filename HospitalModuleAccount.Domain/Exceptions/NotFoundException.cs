﻿
namespace HospitalModuleAccount.Domain.Exceptions
{
    public class NotFoundException:CoreBusinessException
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string msg) : base(msg)
        {
        }

        public NotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
