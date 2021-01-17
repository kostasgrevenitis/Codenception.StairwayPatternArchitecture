using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.ComponentModel.DataAnnotations;

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

    public record RestaurantDomainRecord : IDomainRecord<ValueType>
    {
        [Required]
        public virtual string Name
        {
            get; init;
        }

        [Required]
        public virtual RestaurantType RestaurantType
        {
            get; init;
        }

        [Required]
        public virtual PriceLevel PriceLevel
        {
            get; init;
        }

        [Required]
        public virtual RestaurantAddressInfoDomainRecord AddressInfo
        {
            get; init;
        }
        public ValueType Id
        {
            get; init;
        }
    }
}