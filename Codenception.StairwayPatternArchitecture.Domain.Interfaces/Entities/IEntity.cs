using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using PostSharp.Patterns.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities
{
    public interface IEntity<TDomainRecord> where TDomainRecord : IDomainRecord
    {
        public Task<IList<TDomainRecord>> AllDomainRecordsAsync();

        public Task CreateDomainRecordAsync([Required] TDomainRecord domainRecord);

        public Task DeleteDomainRecordAsync(System.ValueType id);

        public Task<TDomainRecord> DomainRecordAsync(System.ValueType id);

        public Task<IList<TDomainRecord>> DomainRecordsAsync(System.ValueType[] ids);

        public Task UpdateDomainRecordAsync(TDomainRecord domainRecord);
    }
}