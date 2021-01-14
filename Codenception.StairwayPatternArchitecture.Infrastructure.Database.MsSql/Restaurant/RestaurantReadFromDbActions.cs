using Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant
{
    public class RestaurantReadFromDbActions : IReadFromDbActions<RestaurantDatabaseRecord>
    {
        public Task<IList<RestaurantDatabaseRecord>> SelectAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}