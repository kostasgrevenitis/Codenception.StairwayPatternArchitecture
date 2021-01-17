using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Exceptions;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using Codenception.StairwayPatternArchitecture.Services.Restaurant.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Services.Restaurant
{
    public class RestaurantService : IRestaurantService<IDomainRecord<ValueType>, ValueType>
    {
        private readonly IEntity<IDomainRecord<ValueType>> _restaurantEntity;

        public RestaurantService(IEntity<IDomainRecord<ValueType>> restaurantEntity)
        {
            this._restaurantEntity = restaurantEntity;
        }

        public async Task CreateRestaurantAsync(IDomainRecord<ValueType> restaurantDomainRecord)
        {
            try
            {
                await this._restaurantEntity.CreateDomainRecordAsync(restaurantDomainRecord);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task DeleteRestaurantAsync(ValueType id)
        {
            await this._restaurantEntity.DeleteDomainRecordAsync(id);
        }

        public async Task<IDomainRecord<ValueType>> RestaurantAsync(ValueType id)
        {
            return await this._restaurantEntity.DomainRecordAsync(id);
        }

        public async Task<IList<IDomainRecord<ValueType>>> RestaurantsAsync()
        {
            return await this._restaurantEntity.AllDomainRecordsAsync();
        }

        public async Task<IList<IDomainRecord<ValueType>>> RestaurantsAsync(ValueType[] ids)
        {
            return await this._restaurantEntity.DomainRecordsAsync(ids);
        }

        public async Task UpdateRestaurantAsync(IDomainRecord<ValueType> restaurantDomainRecord)
        {
            await this._restaurantEntity.UpdateDomainRecordAsync(restaurantDomainRecord);
        }
    }
}