﻿using Core.Entities;
using Core.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> GetEntityWithSpec(ISpecyfication<T> spec);

        Task<IReadOnlyList<T>> ListAsync(ISpecyfication<T> spec);

        Task<int> CountAsync(ISpecyfication<T> spec);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
