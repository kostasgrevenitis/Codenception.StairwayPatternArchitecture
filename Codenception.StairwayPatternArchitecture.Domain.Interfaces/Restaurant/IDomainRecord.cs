namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant
{
    public interface IDomainRecord
    {
        public IDomainRecord Map<TId>(IDatabaseRecord<TId> databaseRecord);

        public string RecordToString();
    }
}