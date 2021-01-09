using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IRestaurantService<TDomainRecord, TId>
        where TDomainRecord : IDomainRecord
    {
        IDomainRecord Restaurant(TId id);

        IList<IDomainRecord> Restaurants();
    }
}