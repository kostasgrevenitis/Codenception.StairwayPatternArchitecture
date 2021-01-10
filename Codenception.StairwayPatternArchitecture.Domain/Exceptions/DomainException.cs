using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}