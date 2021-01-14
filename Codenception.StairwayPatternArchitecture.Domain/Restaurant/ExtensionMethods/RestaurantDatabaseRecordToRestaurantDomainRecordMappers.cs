using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using Codenception.StairwayPatternArchitecture.Infrastructure.Database.MsSql.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods
{
    public static class RestaurantDatabaseRecordToRestaurantDomainRecordMappers
    {
        public static T MapToDomainRecord<T>(this RestaurantDatabaseRecord databaseRecord)
        {
            var databaseRecordProperties = databaseRecord.GetType().GetProperties();
            var type = typeof(T);
            var domainRecord = Activator.CreateInstance(type);
            var domainRecordPropeties = domainRecord.GetType().GetProperties();

            for (int i = 0; i < databaseRecordProperties.Length; i++)
            {
                var databaseRecordProperty = databaseRecordProperties[i];
                var domainRecordProperty = domainRecordPropeties
                    .Single(p => p.Name.Equals(databaseRecordProperty.Name));

                domainRecordProperty.SetValue(domainRecord, databaseRecordProperty.GetValue(databaseRecord));
            }

            return (T)domainRecord;
        }

        public static IList<T> MapToDomainRecords<T>(this IList<RestaurantDatabaseRecord> databaseRecords)
        {
            var domainRecords = new List<IDomainRecord>();

            foreach (var databaseRecord in databaseRecords)
            {
                var databaseRecordProperties = databaseRecord.GetType().GetProperties();
                var type = typeof(T);
                var domainRecord = Activator.CreateInstance(type);

                for (int i = 0; i < databaseRecordProperties.Length; i++)
                {
                    var databaseRecordProperty = databaseRecordProperties[i];
                    var domainRecordPropeties = domainRecord.GetType().GetProperties();
                    var domainRecordProperty = domainRecordPropeties
                        .Single(p => p.Name.Equals(databaseRecordProperty.Name));

                    domainRecordProperty.SetValue(domainRecord, databaseRecordProperty.GetValue(databaseRecord));
                    domainRecords.Add((IDomainRecord)domainRecord);
                }
            }

            return (IList<T>)domainRecords;
        }
    }
}