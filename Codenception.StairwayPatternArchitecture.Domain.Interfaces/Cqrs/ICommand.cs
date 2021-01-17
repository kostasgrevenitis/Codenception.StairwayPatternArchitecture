using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface ICommand<TDatabaseRecord> where TDatabaseRecord : IDatabaseRecord<ValueType>
    {
        Task CreateAsync(TDatabaseRecord entity);

        Task DeleteByIdAsync(ValueType id);

        Task UpdateByIdAsync(TDatabaseRecord entity);
    }
}