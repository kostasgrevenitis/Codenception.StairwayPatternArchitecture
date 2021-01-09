using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IRecordValidationResult<TValidationFailure>
        where TValidationFailure : IValidationError
    {
        public IList<IValidationError> Errors
        {
            get;
        }

        public bool IsValid
        {
            get;
        }

        public string[] RuleSetsExecuted
        {
            get;
        }
    }
}