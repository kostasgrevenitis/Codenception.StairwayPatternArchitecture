using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.ExtensionMethods.Mappers
{
    public static class RestaurantDatabaseRecordExtensionMethods
    {
        public static IDomainRecord ToDomainRecord(this IDatabaseRecord<System.ValueType> databaseRecord)
        {
            return new RestaurantRecord() with
            {
                Name = "",
                AddressInfo = new AddressInfo(),
                Date = DateTime.Now
            };
        }
    }
}