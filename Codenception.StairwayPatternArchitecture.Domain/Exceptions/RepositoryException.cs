using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}