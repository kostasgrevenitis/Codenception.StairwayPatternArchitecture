using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant
{
    public interface IQuery<TDatabaseRecord, TId> where TDatabaseRecord : IDatabaseRecord<TId>
    {
        ICollection<TDatabaseRecord> All<T>();

        TDatabaseRecord ById(TId id);

        ICollection<TDatabaseRecord> ManyById(TId id);
    }
}