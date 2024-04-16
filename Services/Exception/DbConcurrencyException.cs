using System;

namespace SalesWebV.Services.Exception
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(String message) : base(message) 
        {

        }
    }
}
