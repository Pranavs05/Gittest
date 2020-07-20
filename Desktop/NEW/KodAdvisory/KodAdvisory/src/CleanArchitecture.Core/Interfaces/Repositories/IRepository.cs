using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity: class
    {
        ValueTask<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> ListAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where);
        TEntity Get<TProperty>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TProperty>> include);
        IEnumerable<TEntity> GetMany<TProperty>(List<Expression<Func<TEntity, bool>>> where, List<Expression<Func<TEntity, TProperty>>> includes = null);
    }
}