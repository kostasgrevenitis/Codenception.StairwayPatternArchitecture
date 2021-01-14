using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface IQuery<TDatabaseRecord> where TDatabaseRecord : IDatabaseRecord<ValueType>
    {
        Task<IList<TDatabaseRecord>> AllDatabaseRecordsAsync<T>();

        Task<TDatabaseRecord> DatabaseRecordByIdAsync(ValueType id);

        Task<IList<TDatabaseRecord>> DatabaseRecordByIdsAsync(ValueType[] ids);
    }
}