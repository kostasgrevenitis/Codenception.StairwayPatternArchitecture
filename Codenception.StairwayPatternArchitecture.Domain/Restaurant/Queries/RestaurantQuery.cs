using Codenception.StairwayPatternArchitecture.Domain.Exceptions;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Queries
{
    public class RestaurantQuery : IQuery<RestaurantDatabaseRecord>
    {
        private readonly IReadActions<RestaurantDatabaseRecord> _readActions;

        public RestaurantQuery(IReadActions<RestaurantDatabaseRecord> readActions)
        {
            this._readActions = readActions;
        }

        public async Task<IList<RestaurantDatabaseRecord>> AllDatabaseRecordsAsync<T>()
        {
            try
            {
                var databaseRecords = await this._readActions.SelectAsync();
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public Task<RestaurantDatabaseRecord> DatabaseRecordByIdAsync(ValueType id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<RestaurantDatabaseRecord>> DatabaseRecordByIdsAsync(ValueType[] ids)
        {
            try
            {
                var databaseRecords = await this._readActions.SelectAsync();
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }
    }
}