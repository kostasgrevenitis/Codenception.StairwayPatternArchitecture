using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces
{
    public interface IReadFromDbActions<TDatabaseRecord, TId> where TDatabaseRecord : IDatabaseRecord<ValueType>

    {
        public Task<IList<TDatabaseRecord>> AllAsync();

        public Task<IList<TDatabaseRecord>> WhereAsync(TId[] ids);

        public Task<TDatabaseRecord> WhereAsync(TId id);
    }
}