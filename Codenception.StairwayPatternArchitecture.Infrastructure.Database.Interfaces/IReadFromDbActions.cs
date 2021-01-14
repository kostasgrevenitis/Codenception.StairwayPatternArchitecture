using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces
{
    public interface IReadFromDbActions<TDatabaseRecord> where TDatabaseRecord : IDatabaseRecord<ValueType>

    {
        public Task<IList<TDatabaseRecord>> SelectAsync();
    }
}