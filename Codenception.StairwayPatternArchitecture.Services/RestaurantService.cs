using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<System.ValueType>
    {
        private readonly IRestaurantMappers<IDomainRecord, IDatabaseRecord<System.ValueType>> _mappers;
        private readonly IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> _query;
        private readonly IRestaurantEntity<IDomainRecord, IDomainRecord> _restaurantEntity;

        public RestaurantService(IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> query, IRestaurantEntity<IDomainRecord, IDomainRecord> restaurantEntity)
        {
            this._query = query;
            this._restaurantEntity = restaurantEntity;
        }

        public string Restaurant(System.ValueType id)
        {
            var restaurantDatabaseRecord = this._query.ById(id);
            var restaurantRecord = this._mappers.MapToRecord(restaurantDatabaseRecord);
            this._restaurantEntity.Validate(restaurantRecord);
            return restaurantRecord.RecordToString();
        }

        public ICollection<string> Restaurants()
        {
            var restaurants = new List<string>();

            foreach (var restaurantDatabaseRecord in this._query.All<IDatabaseRecord<int>>())
            {
                var restaurantRecord = this._mappers.MapToRecord(restaurantDatabaseRecord);
                this._restaurantEntity.Validate(restaurantRecord);
                restaurants.Add(restaurantRecord.RecordToString());
            }

            return restaurants;
        }
    }
}