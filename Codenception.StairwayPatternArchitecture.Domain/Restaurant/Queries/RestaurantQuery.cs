using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Exceptions;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Queries
{
    public class RestaurantQuery : IQuery<RestaurantDatabaseRecord>
    {
        private readonly IReadFromDbActions<RestaurantDatabaseRecord, ValueType> _readActions;

        public RestaurantQuery(IReadFromDbActions<RestaurantDatabaseRecord, ValueType> readActions)
        {
            this._readActions = readActions;
        }

        public async Task<IList<RestaurantDatabaseRecord>> AllAsync<T>()
        {
            try
            {
                var databaseRecords = await this._readActions.AllAsync();
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public async Task<IList<RestaurantDatabaseRecord>> WhereAsync(ValueType[] ids)
        {
            try
            {
                var databaseRecords = await this._readActions.WhereAsync(ids);
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public async Task<RestaurantDatabaseRecord> WhereAsync(ValueType id)
        {
            try
            {
                var databaseRecords = await this._readActions.WhereAsync(id);
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }
    }
}