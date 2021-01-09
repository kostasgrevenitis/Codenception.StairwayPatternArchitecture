using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<IDomainRecord, ValueType>
    {
        private readonly IEntity<IDomainRecord> _restaurantEntity;

        public RestaurantService(IEntity<IDomainRecord> restaurantEntity)
        {
            this._restaurantEntity = restaurantEntity;
        }

        public void CreateRestaurant(IDomainRecord restaurantDomainRecord)
        {
            this._restaurantEntity.CreateDomainRecord(restaurantDomainRecord);
        }

        public void DeleteRestaurant(ValueType id)
        {
            this._restaurantEntity.DeleteDomainRecord(id);
        }

        public IDomainRecord Restaurant(ValueType id)
        {
            return this._restaurantEntity.DomainRecord(id);
        }

        public IList<IDomainRecord> Restaurants()
        {
            return this._restaurantEntity.AllDomainRecords();
        }

        public IList<IDomainRecord> Restaurants(ValueType[] ids)
        {
            return this._restaurantEntity.ManyDomainRecords(ids);
        }

        public void UpdateRestaurant(IDomainRecord restaurantDomainRecord)
        {
            this._restaurantEntity.UpdateDomainRecord(restaurantDomainRecord);
        }
    }
}