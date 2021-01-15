using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Commands
{
    public class RestaurantCommand : ICommand<IDatabaseRecord<ValueType>>
    {
        public async Task CreateAsync(IDatabaseRecord<ValueType> entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteByIdAsync(ValueType id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateByIdAsync(ValueType id, IDatabaseRecord<ValueType> entity)
        {
            throw new NotImplementedException();
        }
    }
}