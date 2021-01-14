using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.Tests.UnitTests
{
    public class RestaurantMappingUnitTests
    {
        //  The test method name should consist of three parts:
        //  --  The name of the method being tested.
        //  --  The scenario under which it's being tested.
        //  --  The expected behavior when the scenario is invoked.

        [Fact]
        public void MapToDatabaseRecord_MapDomainRecordToDatabaseRecord_NewDatabaseRecordCreated()
        {
            // Arrange
            var restaurandDomainRecord = new RestaurantDomainRecord() with
            {
            };

            //Act
            var exception = Record.Exception(() =>
            {
                restaurandDomainRecord.MapToDatabaseRecord<RestaurantDatabaseRecord>();
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
            };

            //Act
            var exception = Record.Exception(() =>
            {
                restaurantDatabaseRecord.MapToDomainRecord<RestaurantDomainRecord>();
            });

            // Assert
            Assert.Null(exception);
        }
    }
}