namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant
{
    public interface IDatabaseRecord<TId>
    {
        TId Id
        {
            get; init;
        }
    }
}