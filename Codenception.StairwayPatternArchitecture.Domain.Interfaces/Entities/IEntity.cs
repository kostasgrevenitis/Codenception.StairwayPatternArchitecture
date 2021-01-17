using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities
{
    public interface IEntity<TDomainRecord> where TDomainRecord : IDomainRecord<ValueType>
    {
        public Task<IList<TDomainRecord>> All();

        public Task CreateRecordAsync([Required] TDomainRecord domainRecord);

        public Task DeleteRecordAsync(ValueType id);

        public Task UpdateRecordAsync(TDomainRecord domainRecord);

        public Task<TDomainRecord> Where(ValueType id);

        public Task<IList<TDomainRecord>> Where(ValueType[] ids);
    }
}