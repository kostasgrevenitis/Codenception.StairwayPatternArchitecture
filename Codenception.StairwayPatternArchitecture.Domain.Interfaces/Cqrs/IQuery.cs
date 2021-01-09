using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface IQuery<TDatabaseRecord> where TDatabaseRecord : IDatabaseRecord<ValueType>
    {
        IList<TDatabaseRecord> AllDatabaseRecords<T>();

        TDatabaseRecord DatabaseRecordById(ValueType id);

        IList<TDatabaseRecord> ManyDatabaseRecordByIds(ValueType[] ids);
    }
}