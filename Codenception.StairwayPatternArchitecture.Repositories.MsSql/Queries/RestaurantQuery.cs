using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.Queries
{
    public class RestaurantQuery : IQuery<IDatabaseRecord<ValueType>>
    {
        public IList<IDatabaseRecord<ValueType>> AllDatabaseRecords<T>()
        {
            throw new NotImplementedException();
        }

        public IDatabaseRecord<ValueType> DatabaseRecordById(ValueType id)
        {
            throw new NotImplementedException();
        }

        public IList<IDatabaseRecord<ValueType>> ManyDatabaseRecordByIds(ValueType[] ids)
        {
            throw new NotImplementedException();
        }
    }
}