using Codenception.StairwayPatternArchitecture.Domain.Interfaces.Records;
using System;

namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Cqrs
{
    public interface ICommand<TRecord> where TRecord : IDatabaseRecord<ValueType>
    {
        void Create<T>(TRecord entity);

        void DeleteById(ValueType id);

        void UpdateById<T>(TRecord entity);
    }
}