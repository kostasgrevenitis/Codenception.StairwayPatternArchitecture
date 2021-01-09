using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<IDomainRecord, System.ValueType>
    {
        private readonly IEntity<IDomainRecord> _restaurantEntity;

        public RestaurantService(IEntity<IDomainRecord> restaurantEntity)
        {
            this._restaurantEntity = restaurantEntity;
        }

        public IDomainRecord Restaurant(System.ValueType id)
        {
            return this._restaurantEntity.DomainRecord(id);
        }

        public IList<IDomainRecord> Restaurants()
        {
            return this._restaurantEntity.AllDomainRecords();
        }
    }
}