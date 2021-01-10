using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Entities
{
    public class RestaurantEntity : IEntity<IDomainRecord>
    {
        private readonly ICommand<IDatabaseRecord<ValueType>> _command;
        private readonly IQuery<IDatabaseRecord<ValueType>> _query;

        public RestaurantEntity(
            ICommand<IDatabaseRecord<ValueType>> command,
            IQuery<IDatabaseRecord<System.ValueType>> query)
        {
            this._command = command;
            this._query = query;
        }

        public async Task<IList<IDomainRecord>> AllDomainRecordsAsync()
        {
            var allDatabaseRecords = await this._query.AllDatabaseRecordsAsync<ValueType>();
            return allDatabaseRecords.MapToDomainRecords<IDomainRecord>();
        }

        public async Task CreateDomainRecordAsync(IDomainRecord domainRecord)
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

        public async Task<IDomainRecord> DomainRecordAsync(ValueType id)
        {
            var databaseRecord = await this._query.DatabaseRecordByIdAsync(id);
            return databaseRecord.MapToDomainRecord<IDomainRecord>();
        }

        public async Task<IList<IDomainRecord>> DomainRecordsAsync(ValueType[] ids)
        {
            var databaseRecords = await this._query.ManyDatabaseRecordByIdsAsync(ids);
            return databaseRecords.MapToDomainRecords<IDomainRecord>();
        }

        public async Task UpdateDomainRecordAsync(IDomainRecord domainRecord)
        {
            //await this._command.UpdateByIdAsync();
        }
    }
}