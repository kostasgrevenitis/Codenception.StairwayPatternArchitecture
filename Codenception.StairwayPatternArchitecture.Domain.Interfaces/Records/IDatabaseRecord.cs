using LanguageExt;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IDatabaseRecord<TId>
    {
        Option<TId> Id
        {
            get; init;
        }
    }
}