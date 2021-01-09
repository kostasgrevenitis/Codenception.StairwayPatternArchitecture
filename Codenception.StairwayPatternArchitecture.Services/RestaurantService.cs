using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<IDomainRecord, ValueType>
    {
        private readonly IEntity<IDomainRecord> _restaurantEntity;

        public RestaurantService(IEntity<IDomainRecord> restaurantEntity)
        {
            this._restaurantEntity = restaurantEntity;
        }

        public async Task CreateRestaurantAsync(IDomainRecord restaurantDomainRecord)
        {
            await this._restaurantEntity.CreateDomainRecordAsync(restaurantDomainRecord);
        }

        public async Task DeleteRestaurantAsync(ValueType id)
        {
            await this._restaurantEntity.DeleteDomainRecordAsync(id);
        }

        public async Task<IDomainRecord> RestaurantAsync(ValueType id)
        {
            return await this._restaurantEntity.DomainRecordAsync(id);
        }

        public async Task<IList<IDomainRecord>> RestaurantsAsync()
        {
            return await this._restaurantEntity.AllDomainRecordsAsync();
        }

        public async Task<IList<IDomainRecord>> RestaurantsAsync(ValueType[] ids)
        {
            return await this._restaurantEntity.DomainRecordsAsync(ids);
        }

        public async Task UpdateRestaurantAsync(IDomainRecord restaurantDomainRecord)
        {
            await this._restaurantEntity.UpdateDomainRecordAsync(restaurantDomainRecord);
        }
    }
}