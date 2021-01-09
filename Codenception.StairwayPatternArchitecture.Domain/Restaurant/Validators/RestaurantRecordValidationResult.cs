using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Validators
{
    public class RestaurantRecordValidationResult : IRecordValidationResult<IValidationError>
    {
        public RestaurantRecordValidationResult(IList<IValidationError> errors, bool isValid, string[] ruleSetsExecuted)
        {
            this.Errors = errors;
            this.IsValid = isValid;
            this.RuleSetsExecuted = ruleSetsExecuted;
        }

        public IList<IValidationError> Errors
        {
            get;
            private set;
        }

        public bool IsValid
        {
            get;
            private set;
        }

        public string[] RuleSetsExecuted
        {
            get;
            private set;
        }
    }
}