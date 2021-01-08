using Codenception.StairwayPatternArchitecture.Domain.ExtensionMethods.Mappers;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<System.ValueType>
    {
        private readonly IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> _query;
        private readonly IEntity<IDomainRecord, IDomainRecord, IRecordValidationResult<IValidationError>> _restaurantEntity;

        public RestaurantService(
            IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> query,
            IEntity<IDomainRecord, IDomainRecord, IRecordValidationResult<IValidationError>> restaurantEntity)
        {
            this._query = query;
            this._restaurantEntity = restaurantEntity;
        }

        public string Restaurant(System.ValueType id)
        {
            var restaurantRecord = this._query.ById(id).ToDomainRecord();
            this._restaurantEntity.RecordValidationResult(restaurantRecord);
            return restaurantRecord.RecordToString();
        }

        public IList<string> Restaurants()
        {
            var restaurants = new List<string>();

            foreach (var restaurantDatabaseRecord in this._query.All<IDatabaseRecord<int>>())
            {
                var restaurantRecord = restaurantDatabaseRecord.ToDomainRecord();
                this._restaurantEntity.RecordValidationResult(restaurantRecord);
                restaurants.Add(restaurantRecord.RecordToString());
            }

            return restaurants;
        }
    }
}