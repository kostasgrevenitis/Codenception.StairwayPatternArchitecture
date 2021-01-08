using LanguageExt;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IValidationError
    {
        public Option<object> AttemptedValue
        {
            get;
        }

        public Option<string> ErrorCode
        {
            get;
        }

        public Option<string> ErrorMessage
        {
            get;
        }

        public Option<string> PropertyName
        {
            get;
        }
    }
}