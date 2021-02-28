namespace Repository.Repositories.Interfaces
{
    /// <summary>
    /// Définit une entité horodatable
    /// </summary>
    /// <typeparam name="TKey">Type de la clée d'identification</typeparam>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// Obtient ou définit l'identifiant
        /// </summary>
        TKey ID { get; set; }
    }
}
