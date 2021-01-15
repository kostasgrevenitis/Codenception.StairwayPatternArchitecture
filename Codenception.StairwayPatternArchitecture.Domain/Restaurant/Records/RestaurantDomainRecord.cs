using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using PostSharp.Patterns.Contracts;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public enum PriceLevel
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
        [Required]
        public string Name
        {
            get; init;
        }

        [Required]
        public RestaurantType RestaurantType
        {
            get; init;
        }

        public PriceLevel PriceLevel
        {
            get; init;
        }

        [Required, NotNull]
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