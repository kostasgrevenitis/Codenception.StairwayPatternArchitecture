using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using Codenception.StairwayPatternArchitecture.Services.Restaurant;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codenception.StairwayPatternArchitecture.Clients.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDomainRecord<ValueType>, RestaurantDomainRecord>()
                .AddSingleton<IEntity<RestaurantDomainRecord>, RestaurantEntity>()
                .AddSingleton<IRestaurantService<IDomainRecord<ValueType>, ValueType>, RestaurantService>()
                .BuildServiceProvider();
        }
    }
}