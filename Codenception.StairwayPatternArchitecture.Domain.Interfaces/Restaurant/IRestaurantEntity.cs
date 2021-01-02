namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant
{
    public interface IRestaurantEntity<TRestaurantRecord, TAddressInfo>
        where TRestaurantRecord : IDomainRecord
        where TAddressInfo : IDomainRecord
    {
        public void Validate(TRestaurantRecord restaurantRecord);

        public TRestaurantRecord WithUpdatedAddressInfo(TRestaurantRecord restaurantRecord, TAddressInfo addressInfo);

        public TRestaurantRecord WithUpdatedName(TRestaurantRecord restaurantRecord, string name);
    }
}