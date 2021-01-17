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
    public class RestaurantService : IService<IDomainRecord<ValueType>, ValueType>
    {
        private readonly IEntity<IDomainRecord<ValueType>> _restaurantEntity;

        public RestaurantService(IEntity<IDomainRecord<ValueType>> restaurantEntity)
        {
            this._restaurantEntity = restaurantEntity;
        }

        public async Task<IList<IDomainRecord<ValueType>>> AllAsync()
        {
            try
            {
                return await this._restaurantEntity.AllDomainRecordsAsync();
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task CreateAsync(IDomainRecord<ValueType> restaurantDomainRecord)
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

        public async Task DeleteAsync(ValueType id)
        {
            try
            {
                await this._restaurantEntity.DeleteDomainRecordAsync(id);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task UpdateAsync(IDomainRecord<ValueType> restaurantDomainRecord)
        {
            try
            {
                await this._restaurantEntity.UpdateDomainRecordAsync(restaurantDomainRecord);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task<IList<IDomainRecord<ValueType>>> Where(ValueType[] ids)
        {
            try
            {
                return await this._restaurantEntity.DomainRecordsAsync(ids);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task<IDomainRecord<ValueType>> Where(ValueType id)
        {
            try
            {
                return await this._restaurantEntity.DomainRecordAsync(id);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }
    }
}