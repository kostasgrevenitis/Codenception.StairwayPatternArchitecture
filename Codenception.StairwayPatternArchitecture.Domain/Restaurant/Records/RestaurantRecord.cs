using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using LanguageExt;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records
{
    public record RestaurantRecord : IDomainRecord
    {
        public DateTime Date
        {
            get; init;
        }

        public Option<string> Name
        {
            get; init;
        }

        public AddressInfo AddressInfo
        {
            get; init;
        }

        public Option<string> RecordToString()
        {
            return this.ToString();
        }
    }
}