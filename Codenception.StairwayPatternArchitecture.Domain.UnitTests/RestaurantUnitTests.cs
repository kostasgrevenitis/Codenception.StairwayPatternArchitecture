using Codenception.StairwayPatternArchitecture.Repositories.MsSql.DatabaseRecords;
using System.Collections.Generic;
using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.UnitTests
{
    public class RestaurantUnitTests
    {
        //  The name of your test should consist of three parts:
        //  --  The name of the method being tested.
        //  --  The scenario under which it's being tested.
        //  --  The expected behavior when the scenario is invoked.

        [Fact]
        public void MapToDomainRecord_MapDatabaseRecordToDomainRecord_NewDomainRecordCreated()
        {
            // Arrange
            var restaurantDatabaseRecords = new List<RestaurantDatabaseRecord>
            {
                new RestaurantDatabaseRecord(),
                new RestaurantDatabaseRecord(),
                new RestaurantDatabaseRecord(),
                new RestaurantDatabaseRecord(),
                new RestaurantDatabaseRecord()
            };
            // Act

            // Assert
        }
    }
}