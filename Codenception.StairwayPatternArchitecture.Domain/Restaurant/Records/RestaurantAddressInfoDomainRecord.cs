using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using PostSharp.Patterns.Contracts;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public record RestaurantAddressInfoDomainRecord : IDomainRecord
    {
        [Required]
        public string StreetName
        {
            get; init;
        }

        [Required]
        public int StreetNumber
        {
            get; init;
        }

        [Required]
        public int PostalCode
        {
            get; init;
        }

        [Required]
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