using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IRestaurantService<TDomainRecord, TId>
        where TDomainRecord : IDomainRecord
    {
        Task CreateRestaurantAsync(IDomainRecord restaurantDomainRecord);

        Task DeleteRestaurantAsync(TId id);

        Task<IDomainRecord> RestaurantAsync(TId id);

        Task<IList<IDomainRecord>> RestaurantsAsync();

        Task<IList<IDomainRecord>> RestaurantsAsync(TId[] ids);

        Task UpdateRestaurantAsync(IDomainRecord restaurantDomainRecord);
    }
}