using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IRestaurantService<TId>
    {
        string Restaurant(TId id);

        ICollection<string> Restaurants();
    }
}