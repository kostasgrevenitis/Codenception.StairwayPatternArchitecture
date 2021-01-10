using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;

namespace Codenception.StairwayPatternArchitecture.Domain.Repositories.Restaurant.DatabaseRecords
{
    public record RestaurantDatabaseRecord : IDatabaseRecord<System.ValueType>
    {
        public System.ValueType Id
        {
            get;
            init;
        }
    }
}