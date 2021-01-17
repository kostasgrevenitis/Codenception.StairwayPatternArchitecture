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
                return await this._restaurantEntity.AllAsync();
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
                await this._restaurantEntity.CreateRecordAsync(restaurantDomainRecord);
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
                await this._restaurantEntity.DeleteRecordAsync(id);
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
                await this._restaurantEntity.UpdateRecordAsync(restaurantDomainRecord);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task<IList<IDomainRecord<ValueType>>> WhereAsync(ValueType[] ids)
        {
            try
            {
                return await this._restaurantEntity.WhereAsync(ids);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }

        public async Task<IDomainRecord<ValueType>> WhereAsync(ValueType id)
        {
            try
            {
                return await this._restaurantEntity.WhereAsync(id);
            }
            catch (DomainException ex)
            {
                throw new ServiceException("", ex);
            }
        }
    }
}