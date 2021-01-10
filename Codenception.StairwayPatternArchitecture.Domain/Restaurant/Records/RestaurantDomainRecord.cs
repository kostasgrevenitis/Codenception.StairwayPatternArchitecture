using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public enum Prices
    {
        VeryCheap = 1,
        Cheap = 2,
        InBudget = 3,
        Expensive = 4,
        VeryExpensive = 5
    }

    public enum RestaurantType
    {
        FastFood = 1,
        SportsBar = 2,
        CasualDining = 3,
        FineDining = 4,
        FoodTruck = 5
    }

    public record RestaurantDomainRecord : IDomainRecord
    {
        public string Name
        {
            get; init;
        }

        public RestaurantType RestaurantType
        {
            get; init;
        }

        public Prices Prices
        {
            get; init;
        }

        public RestaurantAddressInfoDomainRecord AddressInfo
        {
            get; init;
        }

        public string RecordToString()
        {
            return this.ToString();
        }
    }
}