using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant;
using Codenception.StairwayPatternArchitecture.Domain.Records;
using Codenception.StairwayPatternArchitecture.Domain.Validators;

namespace Codenception.StairwayPatternArchitecture.Domain.Entities
{
    public class RestaurantEntity : IRestaurantEntity<RestaurantRecord, AddressInfo>
    {
        private readonly RestaurantValidator _restaurantValidator;

        public RestaurantEntity(RestaurantValidator restaurantValidator)
        {
            this._restaurantValidator = restaurantValidator;
        }

        public void Validate(RestaurantRecord restaurantRecord)
        {
            var validationResult = this._restaurantValidator.Validate(restaurantRecord);
            if (!validationResult.IsValid)
            {
                throw new System.Exception();
            }
        }

        public RestaurantRecord WithUpdatedAddressInfo(RestaurantRecord restaurantRecord, AddressInfo addressInfo)
        {
            this.Validate(restaurantRecord);
            return restaurantRecord with
            {
                AddressInfo = addressInfo
            };
        }

        public RestaurantRecord WithUpdatedName(RestaurantRecord restaurantRecord, string name)
        {
            this.Validate(restaurantRecord);
            return restaurantRecord with
            {
                Name = name
            };
        }
    }
}