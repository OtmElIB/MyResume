using Repository.Repositories.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Core
{
    public abstract class EntityService<TEntity, TKey> : ServiceBase, IEntityService<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        #region Properties


        /// <summary>
        /// Obtient le dépot  de TEntity.
        /// </summary>
        protected readonly IEntityRepository<TEntity, TKey> Repository;

        /// <summary>
        /// Obtient le cache mémoire
        /// </summary>
        // protected readonly IMemoryCache MemoryCache;


        /// <summary>
        /// Obtient le Logger
        /// </summary>
        // protected readonly ILogger Logger;


        private EventHandler _PostExecuted;

        /// <summary>
        /// Se produit après l'ajout d'un TEntity.
        /// </summary>
        public event EventHandler PostExecuted
        {
            add { _PostExecuted += value; }
            remove { _PostExecuted -= value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialise une nouvelle instance de EntityService/>.
        /// </summary>
        /// <param name="repository">Le dépot de TEntity</param>
        /// <param name="validator">Le validateur de TEntity</param>
        /// <param name="memoryCache"></param>
        /// <param name="logger"></param>
        protected EntityService(IEntityRepository<TEntity, TKey> repository)
        {
            this.Repository = repository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtient la clée de cache pour une méthode et paramètres donnés.
        /// </summary>
        /// <param name="methodName">Nom de la méthode.</param>
        /// <param name="parameterValues">Valeurs des paramètres.</param>
        /// <returns></returns>
        public string GetCacheKey(string methodName, params object[] parameterValues)
        {
            return $"{this.GetType().Name}_{methodName}_{string.Join("_", parameterValues)}";
        }

        /// <summary>
        /// Obtient la liste de tous les TEntity
        /// </summary>
        /// <returns>
        /// Liste de TEntity
        /// </returns>
        public virtual IActionResponse<List<TEntity>> Get()
        {
            IActionResponse<List<TEntity>> actionResponse;

            List<TEntity> items;

            try
            {
                items = this.Repository.Read();

                actionResponse = this.Ok(items);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<List<TEntity>>(e);
            }

            return actionResponse;

        }

        /// <summary>
        /// Obtient un TEntity à partir de sa clée TKey
        /// </summary>
        /// <param name="key">TKey</param>
        /// <returns>
        /// <typeparamref name="TEntity" />
        /// </returns>
        public virtual IActionResponse<TEntity> Get(TKey key)
        {
            IActionResponse<TEntity> actionResponse;

            try
            {
                var item = this.Repository.Read(key);
                actionResponse = item != null ? this.Ok(item) : this.NotFound<TEntity>();
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<TEntity>(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Obtient une liste de  TEntityà partir d'une liste de clées TKey
        /// </summary>
        /// <param name="keys">Liste de TKey</param>
        /// <returns>
        /// <typeparamref name="TEntity" />
        /// </returns>
        public virtual IActionResponse<List<TEntity>> Get(params TKey[] keys)
        {
            IActionResponse<List<TEntity>> actionResponse;

            try
            {
                var items = this.Repository.Read(keys);
                actionResponse = items.Any() ? this.Ok(items) : new ActionResponse<List<TEntity>>(ActionStatusCode.NoContent, items);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<List<TEntity>>(e);
            }

            return actionResponse;
        }



        public virtual IActionResponse<TEntity> Post(TEntity entity, string validatorRuleSet = "*")
        {

            IActionResponse<TEntity> actionResponse;


            
                try
                {
                    this.Repository.Create(entity);
                    actionResponse = this.Created<TEntity>(entity);
                }
                catch (Exception e)
                {
                    actionResponse = this.InternalServerError<TEntity>(e);
                }

            this.OnPostExecuted(actionResponse, EventArgs.Empty);

            return actionResponse;
        }

        public virtual async Task<IActionResponse> PostAsync(TEntity entity)
        {
            var actionResponse = this.Ok();

            try
            {
                await this.Repository.CreateAsync(entity);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Mise à jour d'un TEntity
        /// </summary>
        /// <param name="key">Identifiant de TEntity</param>
        /// <param name="entity">TEntity à mettre à jour</param>
        /// <param name="validatorRuleSet">Nom du jeu de règle de validation du TEntity</param>
        /// <returns>IActionResponse contenant un TEntity si ActionStatusCode = 200 (Ok)</returns>
        public virtual IActionResponse<TEntity> Put(TKey key, TEntity entity, string validatorRuleSet = "*")
        {
            IActionResponse<TEntity> actionResponse;
            
            try
            {
                this.Repository.Update(key, entity);
                actionResponse = this.Created(entity);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<TEntity>(e);
            }
            

            return actionResponse;
        }

        /// <summary>
        /// Mise à jour d'un TEntity
        /// </summary>
        /// <param name="key">Identifiant de TEntity</param>
        /// <param name="entity">TEntity à mettre à jour</param>
        /// <returns>ActionResponse</returns>
        public virtual async Task<IActionResponse> PutAsync(TKey key, TEntity entity)
        {

            var actionResponse = this.Ok();

            try
            {
                await this.Repository.UpdateAsync(key, entity);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Supprime toutes les TEntity
        /// </summary>
        /// <returns>ActionResponse</returns>
        public virtual IActionResponse Delete()
        {
            IActionResponse actionResponse = this.NoContent();
            try
            {
                this.Repository.Delete();
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Supprime un TEntity
        /// </summary>
        /// <param name="key">Identifiant de TEntity></param>
        /// <returns>ActionResponse</returns>
        public virtual IActionResponse Delete(TKey key)
        {
            IActionResponse actionResponse = this.NoContent();
            try
            {
                this.Repository.Delete(key);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Supprime toutes les TEntity de manière asynchrone
        /// </summary>
        /// <returns>ActionResponse</returns>
        public virtual async Task<IActionResponse> DeleteAsync()
        {
            IActionResponse actionResponse = this.NoContent();
            try
            {
                await this.Repository.DeleteAsync();
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError(e);
            }

            return actionResponse;
        }



        /// <summary>
        /// Supprime un TEntity de manière asynchrone
        /// </summary>
        /// <param name="key">Identifiant de TEntity</param>
        /// <returns>ActionResponse</returns>
        public virtual async Task<IActionResponse> DeleteAsync(TKey key)
        {
            IActionResponse actionResponse = this.NoContent();

            try
            {
                await this.Repository.DeleteAsync(key);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Obtient le premeier element de TEntity
        /// </summary>
        /// <returns>
        /// TEntity
        /// </returns>
        public virtual IActionResponse<TEntity> FirstOrDefault()
        {
            IActionResponse<TEntity> actionResponse;

            try
            {
                actionResponse = this.Ok(this.Repository.ReadFirst());
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<TEntity>(e);
            }

            return actionResponse;

        }

        /// <summary>
        /// Retourne le premier élément de la séquence à satisfaire à une condition ou une valeur par défaut si aucun élément correspondant n’est trouvé.
        /// </summary>
        /// <param name="predicate">Fonction permettant de tester chaque élément par rapport à une condition..</param>
        /// <returns>default(TEntity) si source est vide ou si aucun élément ne réussit le test spécifié par predicate ; sinon, le premier élément de source qui réussit le test spécifié par predicate</returns>
        public virtual IActionResponse<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            IActionResponse<TEntity> actionResponse;

            try
            {
                var item = this.Repository.FirstOrDefault(predicate);
                actionResponse = item != null ? this.Ok(item) : this.NotFound<TEntity>();
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<TEntity>(e);
            }

            return actionResponse;
        }

        /// <summary>
        /// Filtre une séquence de valeurs selon un prédicat.
        /// </summary>
        /// <param name="predicate">Fonction permettant de tester chaque élément par rapport à une condition.</param>
        /// <returns>IActionResponse qui contient des éléments de la séquence d'entrée satisfaisant à la condition.</returns>
        public virtual IActionResponse<List<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            IActionResponse<List<TEntity>> actionResponse;

            try
            {
                var items = this.Repository.Read(predicate);
                actionResponse = items.Any() ? this.Ok(items) : new ActionResponse<List<TEntity>>(ActionStatusCode.NoContent, items);
            }
            catch (Exception e)
            {
                actionResponse = this.InternalServerError<List<TEntity>>(e);
            }

            return actionResponse;
        }

        protected virtual void OnPostExecuted(object sender, EventArgs eventArgs)
        {
            if (_PostExecuted != null)
            {
                this._PostExecuted(sender, eventArgs);
            }
        }

        #endregion

    }
}
