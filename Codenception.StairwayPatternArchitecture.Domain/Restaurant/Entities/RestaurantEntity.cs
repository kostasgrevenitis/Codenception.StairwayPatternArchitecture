using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.DatabaseRecords;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
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
            var allDatabaseRecords = await this._query.AllDatabaseRecordsAsync<ValueType>();
            return allDatabaseRecords.MapToDomainRecords<RestaurantDomainRecord>();
        }

        public async Task CreateDomainRecordAsync(RestaurantDomainRecord domainRecord)
        {
            //try
            //{
            //    //await this._command.CreateAsync(domainRecord);
            //}
            //catch (ex)
            //{
            //    throw;
            //}
        }

        public async Task DeleteDomainRecordAsync(ValueType id)
        {
            await this._command.DeleteByIdAsync(id);
        }

        public async Task<RestaurantDomainRecord> DomainRecordAsync(ValueType id)
        {
            var databaseRecord = await this._query.DatabaseRecordByIdAsync(id);
            return databaseRecord.MapToDomainRecord<RestaurantDomainRecord>();
        }

        public async Task<IList<RestaurantDomainRecord>> DomainRecordsAsync(ValueType[] ids)
        {
            var databaseRecords = await this._query.ManyDatabaseRecordByIdsAsync(ids);
            return databaseRecords.MapToDomainRecords<RestaurantDomainRecord>();
        }

        public async Task UpdateDomainRecordAsync(RestaurantDomainRecord domainRecord)
        {
            //await this._command.UpdateByIdAsync();
        }
    }
}