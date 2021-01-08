namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IDatabaseRecord<TId>
    {
        TId Id
        {
            get; init;
        }
    }
}