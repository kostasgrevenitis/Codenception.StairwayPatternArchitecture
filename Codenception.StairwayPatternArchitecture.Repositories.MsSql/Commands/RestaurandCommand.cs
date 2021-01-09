using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.Commands
{
    public class RestaurantCommand : ICommand<IDatabaseRecord<ValueType>>
    {
        public void Create(IDatabaseRecord<ValueType> entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(ValueType id)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(IDatabaseRecord<ValueType> entity)
        {
            throw new NotImplementedException();
        }
    }
}