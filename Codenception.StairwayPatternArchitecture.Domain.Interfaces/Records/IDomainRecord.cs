namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IDomainRecord<TId>
    {
        TId Id
        {
            get; init;
        }
    }
}