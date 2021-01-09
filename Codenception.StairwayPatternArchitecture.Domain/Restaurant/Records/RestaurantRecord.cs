using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public record RestaurantRecord : IDomainRecord
    {
        public DateTime Date
        {
            get; init;
        }

        public string Name
        {
            get; init;
        }

        public AddressInfo AddressInfo
        {
            get; init;
        }

        public string RecordToString()
        {
            return this.ToString();
        }
    }
}