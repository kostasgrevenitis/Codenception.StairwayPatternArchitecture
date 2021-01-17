using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IService<TDomainRecord, TId>
        where TDomainRecord : IDomainRecord<ValueType>
    {
        Task<IList<IDomainRecord<ValueType>>> AllAsync();

        Task CreateAsync(IDomainRecord<ValueType> restaurantDomainRecord);

        Task DeleteAsync(TId id);

        Task UpdateAsync(IDomainRecord<ValueType> restaurantDomainRecord);

        Task<IList<IDomainRecord<ValueType>>> WhereAsync(TId[] ids);

        Task<IDomainRecord<ValueType>> WhereAsync(TId id);
    }
}