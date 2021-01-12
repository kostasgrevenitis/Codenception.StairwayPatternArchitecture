using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Repositories.Restaurant.DatabaseRecords
{
    public record RestaurantDatabaseRecord : IDatabaseRecord<ValueType>
    {
        public ValueType Id
        {
            get;
            init;
        }
    }
}