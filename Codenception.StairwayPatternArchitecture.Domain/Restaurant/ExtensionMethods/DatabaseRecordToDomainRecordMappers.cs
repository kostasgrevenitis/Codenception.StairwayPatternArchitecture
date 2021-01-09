using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenception.StairwayPatternArchitecture.Domain.Restaurant.ExtensionMethods
{
    internal static class DatabaseRecordToDomainRecordMappers
    {
        internal static IDomainRecord MapToDomainRecord(this IDatabaseRecord<ValueType> databaseRecord)
        {
            var databaseRecordProperties = databaseRecord.GetType().GetProperties();
            var type = typeof(IDomainRecord);
            var domainRecord = Activator.CreateInstance(type);
            var domainRecordPropeties = domainRecord.GetType().GetProperties();

            for (int i = 0; i < databaseRecordProperties.Length; i++)
            {
                var databaseRecordProperty = databaseRecordProperties[i];
                var domainRecordProperty = domainRecordPropeties
                    .Single(p => p.Name.Equals(databaseRecordProperty.Name));

                domainRecordProperty.SetValue(domainRecord, databaseRecordProperty.GetValue(databaseRecord));
            }

            return (IDomainRecord)domainRecord;
        }

        internal static IList<IDomainRecord> MapToDomainRecordsList(this IList<IDatabaseRecord<ValueType>> databaseRecords)
        {
            var domainRecords = new List<IDomainRecord>();

            foreach (var databaseRecord in databaseRecords)
            {
                var databaseRecordProperties = databaseRecord.GetType().GetProperties();
                var type = typeof(IDomainRecord);
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

            return domainRecords;
        }
    }
}