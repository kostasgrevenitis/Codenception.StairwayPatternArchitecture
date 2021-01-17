using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface IQuery<TDatabaseRecord> where TDatabaseRecord : IDatabaseRecord<ValueType>
    {
        Task<IList<TDatabaseRecord>> AllAsync<T>();

        Task<TDatabaseRecord> WhereAsync(ValueType id);

        Task<IList<TDatabaseRecord>> WhereAsync(ValueType[] ids);
    }
}