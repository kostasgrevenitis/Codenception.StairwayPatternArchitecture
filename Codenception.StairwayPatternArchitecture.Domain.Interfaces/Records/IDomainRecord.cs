using LanguageExt;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IDomainRecord
    {
        public Option<string> RecordToString();
    }
}