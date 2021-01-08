using LanguageExt;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services.Interfaces
{
    public interface IRestaurantService<TId>
    {
        Option<string> Restaurant(TId id);

        IList<Option<string>> Restaurants();
    }
}