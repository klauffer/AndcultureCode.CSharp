using System;

namespace AndcultureCode.CSharp.Testing.Exceptions
{
    public class MissingFactoryException : Exception
    {
        public MissingFactoryException()
        {
        }

        public MissingFactoryException(string message) : base(message)
        {
        }

        public MissingFactoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}