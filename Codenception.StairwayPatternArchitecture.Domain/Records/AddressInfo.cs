using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Records
{
    public record AddressInfo : IRecord
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