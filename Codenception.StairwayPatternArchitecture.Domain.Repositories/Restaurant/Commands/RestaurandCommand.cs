using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Repositories.Restaurant.Commands
{
    public class RestaurantCommand : ICommand<IDatabaseRecord<ValueType>>
    {
        public RestaurantCommand()
        {
        }

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