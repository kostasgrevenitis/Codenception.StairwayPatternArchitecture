using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface ICommand<TRecord> where TRecord : IDatabaseRecord<ValueType>
    {
        Task CreateAsync(TRecord entity);

        Task DeleteByIdAsync(ValueType id);

        Task UpdateByIdAsync(TRecord entity);
    }
}