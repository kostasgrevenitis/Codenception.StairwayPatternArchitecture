using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities
{
    public interface IEntity<TRestaurantRecord, TAddressInfo, TRecordValidationResult>
        where TRestaurantRecord : IDomainRecord
        where TAddressInfo : IDomainRecord
        where TRecordValidationResult : IRecordValidationResult<IValidationError>
    {
        public IRecordValidationResult<IValidationError> RecordValidationResult(TRestaurantRecord restaurantRecord);

        public TRestaurantRecord WithUpdatedAddressInfo(TRestaurantRecord restaurantRecord, TAddressInfo addressInfo);

        public TRestaurantRecord WithUpdatedName(TRestaurantRecord restaurantRecord, string name);
    }
}