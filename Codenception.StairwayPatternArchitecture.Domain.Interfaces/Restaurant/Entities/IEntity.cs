using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Records;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Entities
{
    public interface IEntity<TRestaurantRecord, TAddressInfo>
        where TRestaurantRecord : IDomainRecord
        where TAddressInfo : IDomainRecord
    {
        public void Validate(TRestaurantRecord restaurantRecord);

        public TRestaurantRecord WithUpdatedAddressInfo(TRestaurantRecord restaurantRecord, TAddressInfo addressInfo);

        public TRestaurantRecord WithUpdatedName(TRestaurantRecord restaurantRecord, string name);
    }
}