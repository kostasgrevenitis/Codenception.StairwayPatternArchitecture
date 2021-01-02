using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.DatabaseRecords
{
    public record RestaurantDatabaseRecord : IDatabaseRecord<int>
    {
        public int Id
        {
            get;
            init;
        }
    }
}