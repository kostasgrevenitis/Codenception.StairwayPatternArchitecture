using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Mappers;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Mappers
{
    public class RestaurantMapper : IMapper<IDomainRecord, IDatabaseRecord<System.ValueType>>
    {
        public IDatabaseRecord<ValueType> MapToDatabaseRecord(IDomainRecord databaseRecord)
        {
            throw new NotImplementedException();
        }

        public IDomainRecord MapToRecord(IDatabaseRecord<ValueType> databaseRecord)
        {
            throw new NotImplementedException();
        }
    }
}