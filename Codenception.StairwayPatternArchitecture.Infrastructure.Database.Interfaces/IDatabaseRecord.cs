namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces
{
    public interface IDatabaseRecord<TId>
    {
        TId Id
        {
            get; init;
        }
    }
}