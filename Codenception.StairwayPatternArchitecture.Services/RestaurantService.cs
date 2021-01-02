using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<int>
    {
        private readonly IQuery<IDatabaseRecord<int>, int> _query;
        private readonly IRestaurantEntity<IRecord, IRecord> _restaurantEntity;

        public RestaurantService(IQuery<IDatabaseRecord<int>, int> query, IRestaurantEntity<IRecord, IRecord> restaurantEntity)
        {
            this._query = query;
            this._restaurantEntity = restaurantEntity;
        }

        public string Restaurant(int id)
        {
            return this.Map(this._query.ById(id)).RecordToString();
        }

        public ICollection<string> Restaurants()
        {
            var restaurants = new List<string>();

            foreach (var restaurandDatabaseRecord in this._query.All<IDatabaseRecord<int>>())
            {
                var restaurandRecord = this.Map(restaurandDatabaseRecord);
                this._restaurantEntity.Validate(restaurandRecord);
                restaurants.Add(restaurandRecord.RecordToString());
            }

            return restaurants;
        }
    }
}