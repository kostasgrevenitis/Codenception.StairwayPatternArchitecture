using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using LanguageExt;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Validators
{
    public class RestaurantRecordValidationError : IValidationError
    {
        public RestaurantRecordValidationError(object attemptedValue, string errorCode, string errorMessage, string propertyName)
        {
            AttemptedValue = attemptedValue;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            PropertyName = propertyName;
        }

        public Option<object> AttemptedValue
        {
            get; private set;
        }

        public Option<string> ErrorCode
        {
            get; private set;
        }

        public Option<string> ErrorMessage
        {
            get; private set;
        }

        public Option<string> PropertyName
        {
            get; private set;
        }
    }
}