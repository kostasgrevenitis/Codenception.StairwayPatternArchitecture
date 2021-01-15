using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Codenception.StairwayPatternArchitecture.Domain.Tests.UnitTests
{
    public class RestaurantValidationTests
    {
        //  The test method name should consist of three parts:
        //  --  The name of the item (property or method) under test.
        //  --  The scenario under which it's being tested.
        //  --  The expected behavior when the scenario is invoked.

        [Fact]
        public void AllProperties_ArePropertyHaveValues_PropertyShouldHaveValues()
        {
            // Arrange
            var restaurandDomainRecord = new RestaurantDomainRecord() with
            {
                Name = "Test",
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

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(restaurandDomainRecord);

            //Act
            var exception = Record.Exception(() =>
            {
                Validator.ValidateObject(restaurandDomainRecord, validationContext, true);
            });

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void AllProperties_ArePropertyNull_PropertyShouldBeNull()
        {
            // Arrange
            var restaurandDomainRecord = new RestaurantDomainRecord() with
            {
                Name = null,
                PriceLevel = default,
                RestaurantType = default,
                AddressInfo = null
            };

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(restaurandDomainRecord);

            //Act
            var exception = Record.Exception(() =>
            {
                Validator.ValidateObject(restaurandDomainRecord, validationContext, true);
            });

            // Assert
            Assert.NotNull(exception);
        }
    }
}