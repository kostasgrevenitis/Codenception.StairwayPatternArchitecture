using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using LanguageExt;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface IQuery<TDatabaseRecord, TId> where TDatabaseRecord : IDatabaseRecord<TId>
    {
        IList<Option<TDatabaseRecord>> All<T>();

        Option<TDatabaseRecord> ById(TId id);

        IList<TDatabaseRecord> ManyById(TId id);
    }
}