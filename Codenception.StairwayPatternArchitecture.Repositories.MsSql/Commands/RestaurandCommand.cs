﻿using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs;
using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Repositories.MsSql.Commands
{
    public class RestaurantCommand : ICommand<IDatabaseRecord<ValueType>>
    {
        public async Task CreateAsync(IDatabaseRecord<ValueType> entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteByIdAsync(ValueType id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateByIdAsync(IDatabaseRecord<ValueType> entity)
        {
            throw new NotImplementedException();
        }
    }
}