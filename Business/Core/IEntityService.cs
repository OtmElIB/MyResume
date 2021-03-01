using Repository.Repositories.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Core
{
    /// <summary>
    /// Définit les methodes de bases SCRUD sur les Entitées 
    /// </summary>
    /// <typeparam name="TEntity">Type de l'EntIty.</typeparam>
    /// <typeparam name="TKey">Type de la clée de l'Entity.</typeparam>
    public interface IEntityService<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// Obtient la liste de tous les TEntity
        /// </summary>
        /// <returns>IActionResponse contenant la liste de TEntity si ActionStatusCode Ok (200)</returns>
        IActionResponse<List<TEntity>> Get();

        /// <summary>
        /// Obtient un TEntity à partir de sa clée TKey
        /// </summary>
        /// <param name="key">TKey</param>
        /// <returns>IActionResponse contenant une TEntity si ActionStatusCode Ok (200)</returns>
        IActionResponse<TEntity> Get(TKey key);

        IActionResponse<List<TEntity>> Get(params TKey[] keys);

        IActionResponse<TEntity> Post(TEntity entity, string validatorRuleSet = "*");

        Task<IActionResponse> PostAsync(TEntity entity);

        IActionResponse<TEntity> Put(TKey key, TEntity entity, string validatorRuleSet = "*");

        Task<IActionResponse> PutAsync(TKey key, TEntity entity);

        IActionResponse Delete(TKey key);

        IActionResponse Delete();

        Task<IActionResponse> DeleteAsync(TKey key);

        Task<IActionResponse> DeleteAsync();

        IActionResponse<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        IActionResponse<List<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);

    }
}
