using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Validators
{
    public class RestaurantRecordValidationResult : IRecordValidationResult<IValidationError>
    {
        public RestaurantRecordValidationResult(ValidationResult validationResult)
        {
            //this.Errors = validationResult.Errors;
            this.IsValid = validationResult.IsValid;
            this.RuleSetsExecuted = validationResult.RuleSetsExecuted;
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