using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces
{
    public interface IReadFromDbActions<TDatabaseRecord, TId> where TDatabaseRecord : IDatabaseRecord<ValueType>

    {
        public Task<IList<TDatabaseRecord>> All();

        public Task<IList<TDatabaseRecord>> Where(TId[] ids);

        public Task<TDatabaseRecord> Where(TId id);
    }
}