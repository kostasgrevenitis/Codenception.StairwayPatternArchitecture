using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.ComponentModel.DataAnnotations;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public record RestaurantAddressInfoDomainRecord : IDomainRecord<ValueType>
    {
        [Required]
        public virtual string StreetName
        {
            get; init;
        }

        [Required]
        public virtual int StreetNumber
        {
            get; init;
        }

        [Required]
        public virtual int PostalCode
        {
            get; init;
        }

        [Required]
        public virtual Tuple<double, double> GeoPosition
        {
            get; init;
        }
        public ValueType Id
        {
            get; init;
        }
    }
}