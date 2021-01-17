﻿using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Exceptions;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Entities
{
    public class RestaurantEntity : IEntity<RestaurantDomainRecord>
    {
        private readonly ICommand<RestaurantDatabaseRecord> _command;
        private readonly IQuery<RestaurantDatabaseRecord> _query;

        public RestaurantEntity(ICommand<RestaurantDatabaseRecord> command, IQuery<RestaurantDatabaseRecord> query)
        {
            this._command = command;
            this._query = query;
        }

        public async Task<IList<RestaurantDomainRecord>> AllDomainRecordsAsync()
        {
            try
            {
                var allDatabaseRecords = await this._query.AllDatabaseRecordsAsync<ValueType>();
                return allDatabaseRecords.MapToDomainRecords();
            }
            catch (RepositoryException ex)
            {
                throw new DomainException("", ex);
            }
        }

        public async Task CreateDomainRecordAsync(RestaurantDomainRecord domainRecord)
        {
            try
            {
                await this._command.CreateAsync(domainRecord.MapToDatabaseRecord());
            }
            catch (RepositoryException ex)
            {
                throw new DomainException("", ex);
            }
        }

        public async Task DeleteDomainRecordAsync(ValueType id)
        {
            try
            {
                await this._command.DeleteByIdAsync(id);
            }
            catch (RepositoryException ex)
            {
                throw new DomainException("", ex);
            }
        }

        public async Task<RestaurantDomainRecord> DomainRecordAsync(ValueType id)
        {
            try
            {
                var databaseRecord = await this._query.DatabaseRecordByIdAsync(id);
                return databaseRecord.MapToDomainRecord();
            }
            catch (RepositoryException ex)
            {
                throw new DomainException("", ex);
            }
        }

        public async Task<IList<RestaurantDomainRecord>> DomainRecordsAsync(ValueType[] ids)
        {
            try
            {
                var databaseRecords = await this._query.DatabaseRecordByIdsAsync(ids);
                return databaseRecords.MapToDomainRecords();
            }
            catch (RepositoryException ex)
            {
                throw new DomainException("", ex);
            }
        }

        public async Task UpdateDomainRecordAsync(RestaurantDomainRecord domainRecord)
        {
            try
            {
                await this._command.UpdateByIdAsync(domainRecord.MapToDatabaseRecord());
            }
            catch (RepositoryException ex)
            {
                throw new DomainException("", ex);
            }
        }
    }
}