namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant
{
    public interface IRecord
    {
        public IRecord Map<TId>(IDatabaseRecord<TId> databaseRecord);

        public string RecordToString();
    }
}