using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface IQuery<TDatabaseRecord, TId> where TDatabaseRecord : IDatabaseRecord<TId>
    {
        IList<TDatabaseRecord> All<T>();

        TDatabaseRecord ById(TId id);

        IList<TDatabaseRecord> ManyById(TId id);
    }
}