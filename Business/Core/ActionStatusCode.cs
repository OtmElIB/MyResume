namespace Business.Core
{
    /// <summary>
    /// Contient les valeurs des codes d'état définis pour une action.
    /// </summary>
    public enum ActionStatusCode
    {
        /// <summary>
        /// Équivalent de l'état HTTP 200. Le champ OK indique que la requête a abouti et que les informations demandées figurent dans la réponse. Ceci constitue le code d'état le plus fréquemment reçu.
        /// </summary>
        OK = 200,

        /// <summary>
        /// Équivalent de l’état HTTP 201. Le champ Created indique que la requête a provoqué la création d'une nouvelle ressource avant l'envoi de la réponse.
        /// </summary>
        Created = 201,

        /// <summary>
        /// Équivalent de l'état HTTP 202. Le champ Accepted indique que le traitement de la requête peut se poursuivre.
        /// </summary>
        Accepted = 202,

        /// <summary>
        /// Équivalent de l'état HTTP 204. Le champ NoContent indique que la requête a été correctement traitée et que la réponse vide est intentionnelle.
        /// </summary>
        NoContent = 204,

        /// <summary>
        /// Équivalent de l'état HTTP 206. Le champ PartialContent indique que la réponse est une réponse partielle, comme indiqué par une requête GET qui spécifie une plage d'octets.
        /// </summary>
        PartialContent = 206,

        /// <summary>
        /// Équivalent de l'état HTTP 400. Le champ BadRequest indique que le serveur n'a pas pu interpréter la requête. Le champ BadRequest est envoyé lorsque aucune autre erreur n'est applicable, ou si l'erreur exacte est inconnue ou n'a pas son propre code d'erreur.
        /// </summary>
        BadRequest = 400,

        /// <summary>
        /// Équivalent de l'état HTTP 401. Le champ Unauthorized indique que les ressources demandées requièrent une authentification. L'en-tête WWW-Authenticate contient les détails nécessaires à l'authentification.
        /// </summary>
        Unauthorized = 401,

        /// <summary>
        /// Équivalent de l'état HTTP 403. Le champ Forbidden indique que le serveur refuse de donner suite à la requête.
        /// </summary>
        Forbidden = 403,

        /// <summary>
        /// Équivalent de l'état HTTP 404. Le champ NotFound indique que la ressource demandée n'existe pas sur le serveur.
        /// </summary>
        NotFound = 404,

        /// <summary>
        /// Équivalent de l’état HTTP 405. Le champ MethodNotAllowed indique que la méthode de requête (POST ou GET) n'est pas autorisée sur la ressource demandée.
        /// </summary>
        MethodNotAllowed = 405,

        /// <summary>
        /// Équivalent de l’état HTTP 406. Le champ NotAcceptable indique que le client a spécifié, par le biais d'en-têtes Accept, qu'il n'acceptera aucune des représentations disponibles pour la ressource.
        /// </summary>
        NotAcceptable = 406,

        /// <summary>
        /// Équivalent de l'état HTTP 409. Le champ Conflict indique que la requête n'a pas pu être exécutée en raison d'un conflit sur le serveur.
        /// </summary>
        Conflict = 409,

        /// <summary>
        /// Équivalent de l'état HTTP 500. Le champ InternalServerError indique qu'une erreur générique s'est produite sur le serveur.
        /// </summary>
        InternalServerError = 500,

        /// <summary>
        /// Équivalent de l'état HTTP 501. Le champ NotImplemented indique que le serveur ne prend pas en charge la fonction demandée.
        /// </summary>
        NotImplemented = 501

    }
}
