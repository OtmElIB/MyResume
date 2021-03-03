using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces.Core
{
    /// <summary>
    /// Définit l'ensemble des méthodes CRUD (Create, Read, Update, Delete) permetant d'accéder aux données stockées dans une base.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IEntityRepository<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        int Create(TEntity entity);

        int Create(IEnumerable<TEntity> entities);

        Task<int> CreateAsync(TEntity entity);

        Task<int> CreateAsync(IEnumerable<TEntity> entities);

        TEntity ReadFirst();

        TEntity Read(TKey key);

        List<TEntity> Read(params TKey[] keys);

        List<TEntity> Read(Expression<Func<TEntity, bool>> predicate);

        List<TEntity> Read(Expression<Func<TEntity, bool>> predicate, params string[] navigationPropertyPaths);

        Task<List<TEntity>> ReadAsync();

        Task<TEntity> ReadAsync(TKey key);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        int Delete();

        int Delete(TKey key);

        Task<int> DeleteAsync();

        Task<int> DeleteAsync(TKey key);

        int Update(TKey key, TEntity entity);

        Task<int> UpdateAsync(TKey key, TEntity entity);

    }
}
