using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codenception.StairwayPatternArchitecture.Infrastructure.Database.Interfaces
{
    public interface IReadActions<TRecord> where TRecord : IDatabaseRecord<ValueType>

    {
        public Task<IList<TRecord>> SelectAsync();
    }
}