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

        public async Task<IList<RestaurantDatabaseRecord>> All<T>()
        {
            try
            {
                var databaseRecords = await this._readActions.All();
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public async Task<IList<RestaurantDatabaseRecord>> Where(ValueType[] ids)
        {
            try
            {
                var databaseRecords = await this._readActions.Where(ids);
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }

        public async Task<RestaurantDatabaseRecord> Where(ValueType id)
        {
            try
            {
                var databaseRecords = await this._readActions.Where(id);
                return databaseRecords;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("", ex);
            }
        }
    }
}