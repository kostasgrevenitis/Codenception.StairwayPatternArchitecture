using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IRestaurantService<TDomainRecord, TId>
        where TDomainRecord : IDomainRecord
    {
        void CreateRestaurant(IDomainRecord restaurantDomainRecord);

        void DeleteRestaurant(TId id);

        IDomainRecord Restaurant(TId id);

        IList<IDomainRecord> Restaurants();

        IList<IDomainRecord> Restaurants(TId[] ids);

        void UpdateRestaurant(IDomainRecord restaurantDomainRecord);
    }
}