using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities
{
    public interface IEntity<TDomainRecord> where TDomainRecord : IDomainRecord<ValueType>
    {
        public Task<IList<TDomainRecord>> AllDomainRecordsAsync();

        public Task CreateDomainRecordAsync([Required] TDomainRecord domainRecord);

        public Task DeleteDomainRecordAsync(ValueType id);

        public Task<TDomainRecord> DomainRecordAsync(ValueType id);

        public Task<IList<TDomainRecord>> DomainRecordsAsync(ValueType[] ids);

        public Task UpdateDomainRecordAsync(TDomainRecord domainRecord);
    }
}