using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Repositories.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}