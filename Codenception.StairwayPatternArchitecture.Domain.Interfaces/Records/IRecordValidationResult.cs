using LanguageExt;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IRecordValidationResult<TValidationFailure>
        where TValidationFailure : IValidationError
    {
        public IList<Option<IValidationError>> Errors
        {
            get;
        }

        public Option<bool> IsValid
        {
            get;
        }

        public Option<string[]> RuleSetsExecuted
        {
            get;
        }
    }
}