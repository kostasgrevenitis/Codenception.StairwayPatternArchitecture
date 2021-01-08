using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Mappers
{
    public interface IMapper<TRecord, TDatabaseRecord>
        where TRecord : IDomainRecord
        where TDatabaseRecord : IDatabaseRecord<System.ValueType>
    {
        TDatabaseRecord MapToDatabaseRecord(TRecord databaseRecord);

        TRecord MapToRecord(TDatabaseRecord databaseRecord);
    }
}