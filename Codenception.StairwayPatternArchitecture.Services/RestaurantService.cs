using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Entities;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Mappers;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Records;
using Codenception.StairwayPatternArchitecture.Services.Interfaces;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Services
{
    public class RestaurantService : IRestaurantService<System.ValueType>
    {
        private readonly IMapper<IDomainRecord, IDatabaseRecord<System.ValueType>> _mapper;
        private readonly IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> _query;
        private readonly IEntity<IDomainRecord, IDomainRecord> _restaurantEntity;

        public RestaurantService(
            IQuery<IDatabaseRecord<System.ValueType>, System.ValueType> query,
            IEntity<IDomainRecord, IDomainRecord> restaurantEntity,
            IMapper<IDomainRecord, IDatabaseRecord<System.ValueType>> mapper)
        {
            this._query = query;
            this._restaurantEntity = restaurantEntity;
            this._mapper = mapper;
        }

        public string Restaurant(System.ValueType id)
        {
            var restaurantDatabaseRecord = this._query.ById(id);
            var restaurantRecord = this._mapper.MapToRecord(restaurantDatabaseRecord);
            this._restaurantEntity.Validate(restaurantRecord);
            return restaurantRecord.RecordToString();
        }

        public ICollection<string> Restaurants()
        {
            var restaurants = new List<string>();

            foreach (var restaurantDatabaseRecord in this._query.All<IDatabaseRecord<int>>())
            {
                var restaurantRecord = this._mapper.MapToRecord(restaurantDatabaseRecord);
                this._restaurantEntity.Validate(restaurantRecord);
                restaurants.Add(restaurantRecord.RecordToString());
            }

            return restaurants;
        }
    }
}