using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public record RestaurantAddressInfoDomainRecord : IDomainRecord
    {
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

        public string RecordToString()
        {
            return this.ToString();
        }
    }
}