using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant
{
    public class RestaurantReadFromDbActions : IReadFromDbActions<RestaurantDatabaseRecord, ValueType>
    {
        public Task<IList<RestaurantDatabaseRecord>> All()
        {
            throw new NotImplementedException();
        }

        public Task<IList<RestaurantDatabaseRecord>> Where(ValueType[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantDatabaseRecord> Where(ValueType id)
        {
            throw new NotImplementedException();
        }
    }
}