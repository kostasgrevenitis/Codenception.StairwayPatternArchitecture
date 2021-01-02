﻿using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Records
{
    public record RestaurantRecord : IRecord
    {
        public DateTime Date
        {
            get; init;
        }
        public string Name
        {
            get; init;
        }

        public AddressInfo AddressInfo
        {
            get; init;
        }

        public IRecord Map<TId>(IDatabaseRecord<TId> databaseRecord)
        {
            return new RestaurantRecord();
        }

        public string RecordToString()
        {
            return this.ToString();
        }
    }
}