using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Validators;
using Codenception.StairwayPatternArchitecture.Domain.Validators;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Entities
{
    public class RestaurantEntity : IEntity<RestaurantRecord, AddressInfo, IRecordValidationResult<IValidationError>>
    {
        private readonly RestaurantValidator _restaurantValidator;

        public RestaurantEntity(RestaurantValidator restaurantValidator)
        {
            this._restaurantValidator = restaurantValidator;
        }

        public IRecordValidationResult<IValidationError> RecordValidationResult(RestaurantRecord restaurantRecord)
        {
            var validationResult = this._restaurantValidator.Validate(restaurantRecord);
            return new RestaurantRecordValidationResult(validationResult);
        }

        public RestaurantRecord WithUpdatedAddressInfo(RestaurantRecord restaurantRecord, AddressInfo addressInfo)
        {
            this.RecordValidationResult(restaurantRecord);
            return restaurantRecord with
            {
                AddressInfo = addressInfo
            };
        }

        public RestaurantRecord WithUpdatedName(RestaurantRecord restaurantRecord, string name)
        {
            this.RecordValidationResult(restaurantRecord);
            return restaurantRecord with
            {
                Name = name
            };
        }
    }
}