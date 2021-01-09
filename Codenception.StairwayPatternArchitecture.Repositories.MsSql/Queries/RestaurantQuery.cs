using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.Queries
{
    public class RestaurantQuery : IQuery<IDatabaseRecord<ValueType>>
    {
        public Task<IList<IDatabaseRecord<ValueType>>> AllDatabaseRecordsAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseRecord<ValueType>> DatabaseRecordByIdAsync(ValueType id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<IDatabaseRecord<ValueType>>> ManyDatabaseRecordByIdsAsync(ValueType[] ids)
        {
            throw new NotImplementedException();
        }
    }
}