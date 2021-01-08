using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using LanguageExt;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities
{
    public interface IEntity<TRestaurantRecord, TAddressInfo, TRecordValidationResult>
        where TRestaurantRecord : IDomainRecord
        where TAddressInfo : IDomainRecord
        where TRecordValidationResult : IRecordValidationResult<IValidationError>
    {
        public Option<IRecordValidationResult<IValidationError>> RecordValidationResult(TRestaurantRecord restaurantRecord);

        public Option<TRestaurantRecord> WithUpdatedAddressInfo(TRestaurantRecord restaurantRecord, TAddressInfo addressInfo);

        public Option<TRestaurantRecord> WithUpdatedName(TRestaurantRecord restaurantRecord, string name);
    }
}