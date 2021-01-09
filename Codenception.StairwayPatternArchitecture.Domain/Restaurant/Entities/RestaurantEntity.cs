using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IList<IDomainRecord> AllDomainRecords()
        {
            return this.MapToDomainRecordsList(this._query.AllDatabaseRecords<System.ValueType>());
        }

        public void CreateDomainRecord(IDomainRecord domainRecord)
        {
            throw new NotImplementedException();
        }

        public void DeleteDomainRecord(ValueType id)
        {
            throw new NotImplementedException();
        }

        public IDomainRecord DomainRecord(ValueType id)
        {
            return this.MapToDomainRecord(this._query.DatabaseRecordById(id));
        }

        public IList<IDomainRecord> ManyDomainRecords(ValueType[] ids)
        {
            return this.MapToDomainRecordsList(this._query.ManyDatabaseRecordByIds(ids));
        }

        public void UpdateDomainRecord(IDomainRecord domainRecord)
        {
            throw new NotImplementedException();
        }

        private IDomainRecord MapToDomainRecord(IDatabaseRecord<ValueType> databaseRecord)
        {
            var databaseRecordProperties = databaseRecord.GetType().GetProperties();
            var type = typeof(IDomainRecord);
            var domainRecord = Activator.CreateInstance(type);
            var domainRecordPropeties = domainRecord.GetType().GetProperties();

            for (int i = 0; i < databaseRecordProperties.Length; i++)
            {
                var databaseRecordProperty = databaseRecordProperties[i];
                var domainRecordProperty = domainRecordPropeties
                    .Single(p => p.Name.Equals(databaseRecordProperty.Name));

                domainRecordProperty.SetValue(domainRecord, databaseRecordProperty.GetValue(databaseRecord));
            }

            return (IDomainRecord)domainRecord;
        }

        private IList<IDomainRecord> MapToDomainRecordsList(IList<IDatabaseRecord<ValueType>> databaseRecords)
        {
            var domainRecords = new List<IDomainRecord>();

            foreach (var databaseRecord in databaseRecords)
            {
                var databaseRecordProperties = databaseRecord.GetType().GetProperties();

                for (int i = 0; i < databaseRecordProperties.Length; i++)
                {
                    var databaseRecordProperty = databaseRecordProperties[i];
                    var type = typeof(IDomainRecord);
                    var domainRecord = Activator.CreateInstance(type);
                    var domainRecordPropeties = domainRecord.GetType().GetProperties();
                    var domainRecordProperty = domainRecordPropeties
                        .Single(p => p.Name.Equals(databaseRecordProperty.Name));

                    domainRecordProperty.SetValue(domainRecord, databaseRecordProperty.GetValue(databaseRecord));
                    domainRecords.Add((IDomainRecord)domainRecord);
                }
            }

            return domainRecords;
        }
    }
}