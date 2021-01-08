using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.DatabaseRecords
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