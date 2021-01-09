using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods;
using System;
using System.Collections.Generic;

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
            return this._query.AllDatabaseRecords<System.ValueType>().MapToDomainRecordsList();
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
            return this._query.DatabaseRecordById(id).MapToDomainRecord();
        }

        public IList<IDomainRecord> ManyDomainRecords(ValueType[] ids)
        {
            return this._query.ManyDatabaseRecordByIds(ids).MapToDomainRecordsList();
        }

        public void UpdateDomainRecord(IDomainRecord domainRecord)
        {
            throw new NotImplementedException();
        }
    }
}