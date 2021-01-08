namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records
{
    public interface IValidationError
    {
        public object AttemptedValue
        {
            get;
        }

        public string ErrorCode
        {
            get;
        }

        public string ErrorMessage
        {
            get;
        }

        public string PropertyName
        {
            get;
        }
    }
}