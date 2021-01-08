using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using LanguageExt;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.DatabaseRecords
{
    public record RestaurantDatabaseRecord : IDatabaseRecord<System.ValueType>
    {
        public Option<System.ValueType> Id
        {
            get;
            init;
        }
    }
}