using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;

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

        public object AttemptedValue
        {
            get; private set;
        }

        public string ErrorCode
        {
            get; private set;
        }

        public string ErrorMessage
        {
            get; private set;
        }

        public string PropertyName
        {
            get; private set;
        }
    }
}