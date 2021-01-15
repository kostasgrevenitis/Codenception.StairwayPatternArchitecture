using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods
{
    public static class RestaurantDomainRecordToRestaurantDatabaseRecordMappers
    {
        public static RestaurantDatabaseRecord MapToDatabaseRecord(this RestaurantDomainRecord domainRecord)
        {
            return new RestaurantDatabaseRecord() with
            {
                Name = domainRecord.Name,
                PriceLevel = (int)domainRecord.PriceLevel,
                RestaurantType = (int)domainRecord.RestaurantType,
                PostalCode = domainRecord.AddressInfo.PostalCode,
                StreetName = domainRecord.AddressInfo.StreetName,
                StreetNumber = domainRecord.AddressInfo.StreetNumber,
                GeoPosition = domainRecord.AddressInfo.GeoPosition
            };
        }

        public static IList<RestaurantDatabaseRecord> MapToDatabaseRecords(this IList<RestaurantDomainRecord> domainRecords)
        {
            var databaseRecords = new List<RestaurantDatabaseRecord>();

            foreach (var domainRecord in domainRecords)
            {
                databaseRecords.Add(new RestaurantDatabaseRecord() with
                {
                    Name = domainRecord.Name,
                    PriceLevel = (int)domainRecord.PriceLevel,
                    RestaurantType = (int)domainRecord.RestaurantType,
                    PostalCode = domainRecord.AddressInfo.PostalCode,
                    StreetName = domainRecord.AddressInfo.StreetName,
                    StreetNumber = domainRecord.AddressInfo.StreetNumber,
                    GeoPosition = domainRecord.AddressInfo.GeoPosition
                });
            }

            return databaseRecords;
        }
    }
}