using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IRestaurantService<TDomainRecord, TId>
        where TDomainRecord : IDomainRecord<ValueType>
    {
        Task CreateRestaurantAsync(IDomainRecord<ValueType> restaurantDomainRecord);

        Task DeleteRestaurantAsync(TId id);

        Task<IDomainRecord<ValueType>> RestaurantAsync(TId id);

        Task<IList<IDomainRecord<ValueType>>> RestaurantsAsync();

        Task<IList<IDomainRecord<ValueType>>> RestaurantsAsync(TId[] ids);

        Task UpdateRestaurantAsync(IDomainRecord<ValueType> restaurantDomainRecord);
    }
}