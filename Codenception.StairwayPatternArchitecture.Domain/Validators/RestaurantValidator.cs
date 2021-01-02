using Codenception.StairwayPatternArchitecture.Domain.Records;
using FluentValidation;

namespace Codenception.StairwayPatternArchitecture.Domain.Validators
{
    public class RestaurantValidator : AbstractValidator<RestaurantRecord>
    {
        public RestaurantValidator()
        {
            RuleFor(restaurant => restaurant.Name).NotNull();
            RuleFor(restaurant => restaurant.AddressInfo).NotNull();
        }
    }
}