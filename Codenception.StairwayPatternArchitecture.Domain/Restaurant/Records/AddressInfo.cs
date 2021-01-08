using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using LanguageExt;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public record AddressInfo : IDomainRecord
    {
        public Option<string> StreetName
        {
            get; init;
        }

        public Option<int> StreetNumber
        {
            get; init;
        }

        public Option<int> PostalCode
        {
            get; init;
        }

        public Option<Tuple<double, double>> GeoPosition
        {
            get; init;
        }

        public Option<string> RecordToString()
        {
            return this.ToString();
        }
    }
}