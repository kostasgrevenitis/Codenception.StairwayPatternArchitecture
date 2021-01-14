using Codenception.StairwayPatternArchitecture.Domain.Exceptions;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Queries
{
    public class RestaurantQuery : IQuery<IDatabaseRecord<ValueType>>
    {
        public RestaurantQuery()
        {
        }

        public async Task<IList<IDatabaseRecord<ValueType>>> AllDatabaseRecordsAsync<T>()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public async Task<IDatabaseRecord<ValueType>> DatabaseRecordByIdAsync(ValueType id)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public async Task<IList<IDatabaseRecord<ValueType>>> ManyDatabaseRecordByIdsAsync(ValueType[] ids)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }
    }
}