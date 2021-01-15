using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System;
using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.Tests.UnitTests
{
    public class RestaurantMappingUnitTests
    {
        //  The test method name should consist of three parts:
        //  --  The name of the item (property or method) under test.
        //  --  The scenario under which it's being tested.
        //  --  The expected behavior when the scenario is invoked.

        [Fact]
        public void MapToDatabaseRecord_MapDomainRecordToDatabaseRecord_NewDatabaseRecordCreated()
        {
            // Arrange
            var restaurandDomainRecord = new RestaurantDomainRecord() with
            {
                Name = "Restaurant name",
                PriceLevel = PriceLevel.Cheap,
                RestaurantType = RestaurantType.CasualDining,
                AddressInfo = new RestaurantAddressInfoDomainRecord() with
                {
                    StreetName = "Super street",
                    StreetNumber = 10,
                    PostalCode = 56429,
                    GeoPosition = new Tuple<double, double>(0, 0)
                }
            };

            //Act
            var exception = Record.Exception(() =>
            {
                restaurandDomainRecord.MapToDatabaseRecord();
            });

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void MapToDomainRecord_MapDatabaseToDomainRecord_NewDomainRecordCreated()
        {
            // Arrange
            var restaurantDatabaseRecord = new RestaurantDatabaseRecord()
            {
                Id = 1,
                Name = "Restaurant name",
                PriceLevel = 2,
                RestaurantType = 3,
                StreetNumber = 10,
                PostalCode = 56429,
                StreetName = "Super street",
                GeoPosition = new Tuple<double, double>(0, 0)
            };

            //Act
            var exception = Record.Exception(() =>
            {
                restaurantDatabaseRecord.MapToDomainRecord();
            });

            // Assert
            Assert.Null(exception);
        }
    }
}