using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Repositories.MsSql.DatabaseRecords;
using System;

namespace Codenception.StairwayPatternArchitecture.ExtensionMethods.Mappers
{
    public static class RestaurantDatabaseRecordExtensionMethods
    {
        public static IDomainRecord ToDomainRecord(this RestaurantDatabaseRecord databaseRecord)
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