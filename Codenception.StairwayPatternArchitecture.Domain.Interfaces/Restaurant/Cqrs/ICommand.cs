﻿namespace Codenception.StairwayPatternArchitecture.Domain.Interfaces.Restaurant.Cqrs
{
    public interface ICommand<TRecord, TId> where TRecord : class
    {
        void Create<T>(TRecord entity);

        void DeleteById(TId id);

        void UpdateById<T>(TRecord entity);
    }
}