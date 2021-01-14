using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant
{
    public record RestaurantDatabaseRecord : IDatabaseRecord<ValueType>
    {
        public ValueType Id
        {
            get;
            init;
        }

        public string Name
        {
            get; init;
        }

        public int RestaurantType
        {
            get; init;
        }

        public int PriceLevel
        {
            get; init;
        }

        public string StreetName
        {
            get; init;
        }

        public int StreetNumber
        {
            get; init;
        }

        public int PostalCode
        {
            get; init;
        }

        public Tuple<double, double> GeoPosition
        {
            get; init;
        }
    }
}