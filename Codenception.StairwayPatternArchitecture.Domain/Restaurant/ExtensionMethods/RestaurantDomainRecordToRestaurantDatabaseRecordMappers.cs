using Codenception.StairwayPatternArchitecture.Domain.Restaurant.Records;
using System.Collections.Generic;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods
{
    public static class RestaurantDomainRecordToRestaurantDatabaseRecordMappers
    {
        public static T MapToDatabaseRecord<T>(this RestaurantDomainRecord domainRecord)
        {
            return default(T);
        }

        public static IList<T> MapToDatabaseRecords<T>(this IList<RestaurantDomainRecord> domainRecord)
        {
            return (IList<T>)default(T);
        }
    }
}