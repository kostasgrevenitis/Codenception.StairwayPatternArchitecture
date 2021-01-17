using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}