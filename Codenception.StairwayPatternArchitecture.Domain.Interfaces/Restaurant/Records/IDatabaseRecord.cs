namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Records
{
    public interface IDatabaseRecord<TId>
    {
        TId Id
        {
            get; init;
        }
    }
}