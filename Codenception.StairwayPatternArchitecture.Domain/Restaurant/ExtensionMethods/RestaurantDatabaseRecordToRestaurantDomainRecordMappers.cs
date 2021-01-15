using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods
{
    public static class RestaurantDatabaseRecordToRestaurantDomainRecordMappers
    {
        public static RestaurantDomainRecord MapToDomainRecord(this RestaurantDatabaseRecord databaseRecord)
        {
            return new RestaurantDomainRecord() with
            {
                Name = databaseRecord.Name,
                PriceLevel = (PriceLevel)databaseRecord.PriceLevel,
                RestaurantType = (RestaurantType)databaseRecord.RestaurantType,
                AddressInfo = new RestaurantAddressInfoDomainRecord() with
                {
                    StreetName = databaseRecord.StreetName,
                    StreetNumber = databaseRecord.StreetNumber,
                    PostalCode = databaseRecord.PostalCode,
                    GeoPosition = databaseRecord.GeoPosition
                }
            };
        }

        public static IList<RestaurantDomainRecord> MapToDomainRecords(this IList<RestaurantDatabaseRecord> databaseRecords)
        {
            var domainRecords = new List<RestaurantDomainRecord>();

            foreach (var databaseRecord in databaseRecords)
            {
                domainRecords.Add(new RestaurantDomainRecord()
                {
                    Name = databaseRecord.Name,
                    PriceLevel = (PriceLevel)databaseRecord.PriceLevel,
                    RestaurantType = (RestaurantType)databaseRecord.RestaurantType,
                    AddressInfo = new RestaurantAddressInfoDomainRecord() with
                    {
                        StreetName = databaseRecord.StreetName,
                        StreetNumber = databaseRecord.StreetNumber,
                        PostalCode = databaseRecord.PostalCode,
                        GeoPosition = databaseRecord.GeoPosition
                    }
                });
            }

            return domainRecords;
        }
    }
}