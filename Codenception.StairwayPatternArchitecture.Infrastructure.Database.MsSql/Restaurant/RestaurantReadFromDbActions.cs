using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant
{
    public class RestaurantReadFromDbActions : IReadFromDbActions<RestaurantDatabaseRecord, ValueType>
    {
        public Task<IList<RestaurantDatabaseRecord>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<RestaurantDatabaseRecord>> WhereAsync(ValueType[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantDatabaseRecord> WhereAsync(ValueType id)
        {
            throw new NotImplementedException();
        }
    }
}