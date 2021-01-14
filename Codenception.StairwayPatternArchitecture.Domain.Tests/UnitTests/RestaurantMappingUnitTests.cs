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
        public void MapToDomainRecord_MapDatabaseRecordToDomainRecord_NewDomainRecordCreated()
        {
            // Arrange
            var restaurantDatabaseRecord = new RestaurantDatabaseRecord();
            var RestaurantDomainRecord.MapToDa

            //Act
            var exception = Record.Exception(() =>
            {
                restaurantDatabaseRecord.MapToDomainRecord<RestaurantDomainRecord>();
                //var domainRecord = mapper.Map<RestaurantDomainRecord>(restaurantDatabaseRecord);
                //var databaseRecord = mapper.Map<RestaurantDatabaseRecord>(restaurandDomainRecord);
            });

            // Assert
            Assert.Null(exception);
        }
    }
}