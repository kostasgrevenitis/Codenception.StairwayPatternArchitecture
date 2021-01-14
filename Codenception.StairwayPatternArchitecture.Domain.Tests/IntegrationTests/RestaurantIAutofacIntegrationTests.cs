using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.Tests.IntegrationTests
{
    public class RestaurantIAutofacIntegrationTests
    {
        //  The test method name should consist of three parts:
        //  --  The name of the method being tested.
        //  --  The scenario under which it's being tested.
        //  --  The expected behavior when the scenario is invoked.

        [Fact]
        public void MapToDomainRecord_MapDatabaseRecordToDomainRecord_NewDomainRecordCreated()
        {
            // Arrange

            //Act
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            var exception = Record.Exception(() =>
            {
                //var domainRecord = mapper.Map<RestaurantDomainRecord>(restaurantDatabaseRecord);
                //var databaseRecord = mapper.Map<RestaurantDatabaseRecord>(restaurandDomainRecord);
            });

            // Assert
            Assert.Null(exception);
        }
    }
}