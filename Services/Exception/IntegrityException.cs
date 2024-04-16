using System;

namespace SalesWebV.Services.Exception
{
    public class IntegrityException:ApplicationException
    {
        public IntegrityException(String massage) : base(massage) { }
    }
}
