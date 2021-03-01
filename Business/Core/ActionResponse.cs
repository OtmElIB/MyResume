using System;

namespace Business.Core
{
    /// <summary>
    /// Représente une réponse d'une action
    /// </summary>
    public class ActionResponse : IActionResponse
    {
        #region Properties

        /// <summary>
        /// Obtient une valeur indiquant si la résponse est l'état succès (ActionStatusCode 200 à 206)
        /// </summary>
        public bool IsSuccess { get; protected set; }

        /// <summary>
        /// Obtient une valeur indiquant si la résponse est une erreure cliente (ActionStatusCode 400 à 406)
        /// </summary>
        public bool IsClientError { get; protected set; }

        /// <summary>
        /// Obtient une valeur indiquant si la résponse est une erreur serveur (ActionStatusCode 500)
        /// </summary>
        public bool IsServerError { get; protected set; }

        /// <summary>
        /// Obtient l'exception de la résponse
        /// </summary>
        public Exception Exception { get; protected set; }

        /// <summary>
        /// Obtient le message de la réponse
        /// </summary>
        public string Message { get; protected set; }

        /// <summary>
        /// Obtient la description du statut de la résponse
        /// </summary>
        public string StatusDescription { get; protected set; }

        /// <summary>
        /// Obtient le statut de la résponse
        /// </summary>
        public ActionStatusCode StatusCode { get; protected set; }




        #endregion

        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">Code du status de la réponse de l'action.</param>
        /// <param name="message">Message</param>
        public ActionResponse(ActionStatusCode actionStatusCode, string message = null)
        {

            this.Message = message;
            this.StatusCode = actionStatusCode;
            this.IsSuccess = (int)this.StatusCode >= 200 && (int)this.StatusCode <= 206;
            this.IsClientError = (int)this.StatusCode >= 400 && (int)this.StatusCode <= 406;
            this.IsServerError = (int)this.StatusCode >= 400 && (int)this.StatusCode <= 406;
        }


        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">Code du status de la réponse de l'action.</param>
        /// <param name="exception">Exception</param>
        public ActionResponse(ActionStatusCode actionStatusCode, Exception exception)
            : this(actionStatusCode)
        {
            this.Exception = exception;
            this.Message = exception?.Message;
            this.StatusCode = actionStatusCode;
            this.IsSuccess = (int)this.StatusCode >= 200 && (int)this.StatusCode <= 206;
            this.IsClientError = (int)this.StatusCode >= 400 && (int)this.StatusCode <= 406;
            this.IsServerError = (int)this.StatusCode >= 400 && (int)this.StatusCode <= 406;
        }


    }

    /// <summary>
    /// Représente une réponse d'une action avec un contenu de type spécifié
    /// </summary>
    /// <typeparam name="T">Contenu de la réponse si OK</typeparam>
    public class ActionResponse<T> : ActionResponse, IActionResponse<T>
    {
        #region Properties

        /// <summary>
        /// Obtient le contenu spécifié de la réponse 
        /// </summary>
        public T Content { get; protected set; }


        #endregion

        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">The action status code.</param>
        public ActionResponse(ActionStatusCode actionStatusCode)
            : base(actionStatusCode)
        {

        }

        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">The action status code.</param>
        /// <param name="message">Message</param>
        public ActionResponse(ActionStatusCode actionStatusCode, string message)
            : base(actionStatusCode, message)
        {

        }

        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">The action status code.</param>
        /// <param name="content">le contenu spécifié de la réponse </param>
        /// <param name="message">Message</param>
        public ActionResponse(ActionStatusCode actionStatusCode, T content, string message = null)
            : base(actionStatusCode, message)
        {
            Content = content;
        }

        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">The action status code.</param>
        /// <param name="content">le contenu spécifié de la réponse </param>
        /// <param name="validationResult">Resultat de la validation</param>
        public ActionResponse(ActionStatusCode actionStatusCode, T content)
            : base(actionStatusCode)
        {
            Content = content;
        }

        /// <summary>
        /// Initialise une nouvelle instance de ActionResponse.
        /// </summary>
        /// <param name="actionStatusCode">The action status code.</param>
        /// <param name="e">Exception</param>
        public ActionResponse(ActionStatusCode actionStatusCode, Exception e)
            : base(actionStatusCode)
        {
            Exception = e;
        }


    }
}
