using Codenception.StairwayPatternArchitecture.Domain.Repositories.Restaurant.DatabaseRecords;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.UnitTests
{
    public class RestaurantUnitTests
    {
        //  The test method name should consist of three parts:
        //  --  The name of the method being tested.
        //  --  The scenario under which it's being tested.
        //  --  The expected behavior when the scenario is invoked.

        [Fact]
        //[ExpectedException(typeof(AuthenticationException))]
        public void MapToDomainRecord_MapDatabaseRecordToDomainRecord_NewDomainRecordCreated()
        {
            // Arrange
            var restaurantDatabaseRecord = new RestaurantDatabaseRecord();

            // Act
            var restaurandDomainRecord = restaurantDatabaseRecord.MapToDomainRecord<RestaurantDomainRecord>();

            // Assert
            //Assert.(IDomainRecord, restaurandDomainRecord);
        }
    }
}