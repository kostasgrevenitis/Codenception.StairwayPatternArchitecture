using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface IQuery<TDatabaseRecord> where TDatabaseRecord : IDatabaseRecord<ValueType>
    {
        Task<IList<TDatabaseRecord>> All<T>();

        Task<TDatabaseRecord> Where(ValueType id);

        Task<IList<TDatabaseRecord>> Where(ValueType[] ids);
    }
}