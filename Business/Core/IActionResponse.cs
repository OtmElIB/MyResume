using System;

namespace Business.Core
{
    /// <summary>
    /// Définit la réponse d'une action
    /// </summary>
    public interface IActionResponse
    {
        /// <summary>
        /// Obtient une valeur indiquant si la résponse est l'état succès (ActionStatusCode 200 à 206)
        /// </summary>
        bool IsSuccess { get; }

        /// <summary>
        /// Obtient une valeur indiquant si la résponse est une erreure cliente (ActionStatusCode 400 à 405)
        /// </summary>
        bool IsClientError { get; }

        /// <summary>
        /// Obtient une valeur indiquant si la résponse est une erreur serveur (ActionStatusCode 500)
        /// </summary>
        bool IsServerError { get; }

        /// <summary>
        /// Obtient l'exception de la résponse
        /// </summary>
        Exception Exception { get; }

        /// <summary>
        /// Obtient le message de la réponse
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Obtient la description du statut de la résponse
        /// </summary>
        string StatusDescription { get; }

        /// <summary>
        /// Obtient le statut de la résponse
        /// </summary>
        ActionStatusCode StatusCode { get; }

    }

    /// <summary>
    /// Définit la réponse d'une action ayant du contenu de type spécifié
    /// </summary>
    /// <typeparam name="T">Contenu de la réponse</typeparam>
    public interface IActionResponse<out T> : IActionResponse
    {
        /// <summary>
        /// Obtient le contenu du type spécifié de la réponse 
        /// </summary>
        T Content { get; }

    }
}
