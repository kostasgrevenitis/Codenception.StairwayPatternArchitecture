using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities
{
    public interface IEntity<TDomainRecord> where TDomainRecord : IDomainRecord
    {
        public IList<TDomainRecord> AllDomainRecords();

        public void CreateDomainRecord(TDomainRecord domainRecord);

        public void DeleteDomainRecord(System.ValueType id);

        public TDomainRecord DomainRecord(System.ValueType id);

        public IList<TDomainRecord> ManyDomainRecords(System.ValueType[] ids);

        public void UpdateDomainRecord(TDomainRecord domainRecord);
    }
}