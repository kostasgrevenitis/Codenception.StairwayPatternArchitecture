namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant
{
    public interface IRestaurantMappers<TRecord, TDatabaseRecord>
        where TRecord : IDomainRecord
        where TDatabaseRecord : IDatabaseRecord<System.ValueType>
    {
        TDatabaseRecord MapToDatabaseRecord(TRecord databaseRecord);

        TRecord MapToRecord(TDatabaseRecord databaseRecord);
    }
}