﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Core.Interfaces
{
    /// <summary>
    /// Interface para repositório de dados
    /// </summary>
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

        Task<List<TEntity>> GetAllAsync(int page, int limit);
        Task<TEntity> GetByIdAsync(TKey id);
    }
}
