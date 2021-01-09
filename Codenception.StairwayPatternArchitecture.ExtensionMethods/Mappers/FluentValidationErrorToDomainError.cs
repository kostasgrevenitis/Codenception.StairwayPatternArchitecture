using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Validators;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.ExtensionMethods.Mappers
{
    public static class FluentValidationErrorToDomainError
    {
        public static IList<IValidationError> ToDomainValidationErrorsList(this IList<ValidationFailure> fluentValidationErrors)
        {
            var restaurantRecordValidationErrors = new List<IValidationError>();

            foreach (var fluentValidationError in fluentValidationErrors)
            {
                restaurantRecordValidationErrors.Add(
                    new RestaurantRecordValidationError(
                        fluentValidationError.AttemptedValue,
                        fluentValidationError.ErrorCode,
                        fluentValidationError.ErrorMessage,
                        fluentValidationError.PropertyName
                        )
                    );
            }

            return restaurantRecordValidationErrors;
        }
    }
}