using Autofac;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Repositories.Restaurant.DatabaseRecords;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using System;
using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.Tests.IntegrationTests
{
    public class MappingTestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RestaurantDomainRecord>().As<IDomainRecord>();
            builder.RegisterType<RestaurantDatabaseRecord>().As<IDatabaseRecord<ValueType>>();
        }
    }

    public class RestaurantIntegrationTests
    {
        //https://juristr.com/blog/2011/12/writing-ioc-supported-integration-tests/
        private IContainer _autofacContainer;

        public RestaurantIntegrationTests()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new MappingTestModule());
            this._autofacContainer = builder.Build();
            this._autofacContainer.BeginLifetimeScope();
        }

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

            // Assert
            var exception = Record.Exception(() => restaurantDatabaseRecord.MapToDomainRecord<IDomainRecord>()); //Act
            Assert.Null(exception);
        }
    }
}