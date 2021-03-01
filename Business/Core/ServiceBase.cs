using System;

namespace Business.Core
{
    /// <summary>
    /// Definit la classe de base de tous les services
    /// </summary>
    public abstract class ServiceBase
    {

        /// <summary>
        /// Obtient une réponse 200 OK avec le contenu de type spécifié.
        /// </summary>
        /// <typeparam name="T">Type du contenu attendu</typeparam>
        /// <param name="actionStatusCode">Code Statut de la réponse</param>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> StatusCode<T>(ActionStatusCode actionStatusCode, string message = null)
        {
            return new ActionResponse<T>(actionStatusCode, message);
        }

        #region Success

        /// <summary>
        /// Obtient une réponse 200 OK avec le contenu de type spécifié.
        /// </summary>
        /// <typeparam name="T">Type du contenu attendu</typeparam>
        /// <param name="content">Contenu de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> Ok<T>(T content)
        {
            return new ActionResponse<T>(ActionStatusCode.OK, content);
        }

        /// <summary>
        /// Obtient une réponse 200 OK.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse Ok()
        {
            return new ActionResponse(ActionStatusCode.OK);
        }

        /// <summary>
        /// Obtient une réponse 201 Created.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse Created()
        {
            return new ActionResponse(ActionStatusCode.Created);
        }

        /// <summary>
        /// Obtient une réponse 201 Created.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse<T> Created<T>(T content)
        {
            return new ActionResponse<T>(ActionStatusCode.Created, content);
        }

        /// <summary>
        /// Obtient une réponse 202 Accepted.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse Accepted()
        {
            return new ActionResponse(ActionStatusCode.Accepted);
        }

        /// <summary>
        /// Obtient une réponse 204 NoContent.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse NoContent(string message = null)
        {
            return new ActionResponse(ActionStatusCode.NoContent, message);
        }

        /// <summary>
        /// Obtient une réponse 204 NoContent.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse<T> NoContent<T>(string message = null)
        {
            return new ActionResponse<T>(ActionStatusCode.NoContent, message);
        }

        /// <summary>
        /// Obtient une réponse 206 PartialContent avec du contenu spécifié
        /// </summary>
        /// <param name="content">Contenu de la réponse de type spécifié</param>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> PartialContent<T>(T content, string message)
        {
            return new ActionResponse<T>(ActionStatusCode.PartialContent, content, message);
        }

        #endregion

        #region Client Error



        /// <summary>
        /// Obtient une réponse 400 BadRequest.
        /// Erreur générale pour toute demande
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse BadRequest(string message = null)
        {
            return new ActionResponse(ActionStatusCode.BadRequest, message);
        }

        /// <summary>
        /// Obtient une réponse 400 BadRequest.
        /// Erreur générale pour toute demande
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> BadRequest<T>(string message = null)
        {
            return new ActionResponse<T>(ActionStatusCode.BadRequest, message);
        }

        /// <summary>
        /// Obtient une réponse 400 BadRequest avec le résultat de la validation IValidationResult
        /// </summary>
        /// <param name="validationResult">Résulta de la validation</param>
        /// <returns></returns>
        protected virtual IActionResponse BadRequest()
        {
            return new ActionResponse(ActionStatusCode.BadRequest);
        }

        /// <summary>
        /// Obtient une réponse 400 BadRequest avec le résultat de la validation IValidationResult
        /// </summary>
        /// <param name="content">Contenu de la réponse</param>
        /// <param name="validationResult">Résulta de la validation</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> BadRequest<T>(T content = null) where T : class
        {
            return new ActionResponse<T>(ActionStatusCode.BadRequest, content);
        }

        /// <summary>
        /// Obtient une réponse 401 Unauthorized.
        /// Je ne vous connais pas, dites-moi qui vous êtes et je vérifierai votre permission.
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse Unauthorized(string message = null)
        {
            return new ActionResponse(ActionStatusCode.Unauthorized, message);
        }

        /// <summary>
        /// Obtient une réponse 401 Unauthorized.
        /// Je ne vous connais pas, dites-moi qui vous êtes et je vérifierai votre permission.
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> Unauthorized<T>(string message = null)
        {
            return new ActionResponse<T>(ActionStatusCode.Unauthorized, message);
        }

        /// <summary>
        /// Obtient une réponse 403 Forbidden.
        /// Vos droits ne sont pas suffisants pour accéder à cette ressource.
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse Forbidden(string message = null)
        {
            return new ActionResponse(ActionStatusCode.Forbidden, message);
        }

        /// <summary>
        /// Obtient une réponse 403 Forbidden.
        /// Vos droits ne sont pas suffisants pour accéder à cette ressource.
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> Forbidden<T>(string message = null)
        {
            return new ActionResponse<T>(ActionStatusCode.Forbidden, message);
        }

        /// <summary>
        /// Obtient une réponse 404 NotFound.
        /// La ressource demandée n'existe pas.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse NotFound(string message = null)
        {
            return new ActionResponse(ActionStatusCode.NotFound, message);
        }

        /// <summary>
        /// Obtient une réponse 404 NotFound.
        /// La ressource demandée n'existe pas.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse<T> NotFound<T>(string message = null)
        {
            return new ActionResponse<T>(ActionStatusCode.NotFound, message);
        }

        /// <summary>
        /// Obtient une réponse 405 MethodNotAllowed.
        /// Cela n'a aucun sens d'appeler une telle méthode sur cette ressource ou l'utilisateur authentifié n'a pas le droit de le faire.
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse MethodNotAllowed(string message = null)
        {
            return new ActionResponse(ActionStatusCode.MethodNotAllowed, message);
        }

        /// <summary>
        /// Obtient une réponse 405 MethodNotAllowed.
        /// Cela n'a aucun sens d'appeler une telle méthode sur cette ressource ou l'utilisateur authentifié n'a pas le droit de le faire.
        /// </summary>
        /// <param name="message">Message de la réponse</param>
        /// <returns></returns>
        protected virtual IActionResponse<T> MethodNotAllowed<T>(string message = null)
        {
            return new ActionResponse<T>(ActionStatusCode.MethodNotAllowed, message);
        }

        #endregion

        #region Server Error

        /// <summary>
        /// Obtient une réponse 500 InternalServerError.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse InternalServerError(Exception e)
        {
            return new ActionResponse(ActionStatusCode.InternalServerError, e);
        }

        /// <summary>
        /// Obtient une réponse 500 InternalServerError.
        /// </summary>
        /// <returns></returns>
        protected virtual IActionResponse<T> InternalServerError<T>(Exception e)
        {
            return new ActionResponse<T>(ActionStatusCode.InternalServerError, e);
        }

        #endregion
    }
}
