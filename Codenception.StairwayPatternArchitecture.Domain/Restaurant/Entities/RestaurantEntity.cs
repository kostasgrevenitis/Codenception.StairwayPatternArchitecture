using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.Entities
{
    public class RestaurantEntity : IEntity<IDomainRecord>
    {
        private readonly ICommand<IDatabaseRecord<System.ValueType>, System.ValueType> _command;
        private readonly IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> _query;

        public RestaurantEntity(ICommand<IDatabaseRecord<System.ValueType>, System.ValueType> command, IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> query)
        {
            this._command = command;
            this._query = query;
        }

        public IList<IDomainRecord> AllDomainRecords()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IList<IDomainRecord> ManyDomainRecords(ValueType[] ids)
        {
            throw new NotImplementedException();
        }

        public void UpdateDomainRecord(IDomainRecord domainRecord)
        {
            throw new NotImplementedException();
        }
    }
}