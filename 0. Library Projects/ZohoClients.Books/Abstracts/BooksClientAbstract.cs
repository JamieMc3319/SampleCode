using System.Net.Http;

namespace ZohoClients.Books.Abstracts
{
    /// <summary>
    /// <see cref="BooksClientAbstract"/> class.
    /// </summary>
    public abstract class BooksClientAbstract : Core.ZohoClientsBase
    {
        /// <summary>
        /// <see cref="BooksClientAbstract"/> constructor.
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="organizationId"></param>
        /// <param name="httpClient"></param>
        protected BooksClientAbstract(string entityName, string organizationId, HttpClient httpClient)
            : this(entityName, null, organizationId, httpClient)
        {
        }

        /// <summary>
        /// <see cref="BooksClientAbstract"/> constructor.
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="parentEntityName"></param>
        /// <param name="organizationId"></param>
        /// <param name="httpClient"></param>
        protected BooksClientAbstract(string entityName, string parentEntityName, string organizationId, HttpClient httpClient)
            : base(httpClient)
        {
            _entityName = entityName;
            _parentEntityName = parentEntityName;

            Core.Helpers.Validators.EnsureOrganizationIdValid(organizationId, false);

            _organizationId = organizationId;
        }


        protected string GetGrantToken(string scope)
        {
            var uri = ZohoClientsSettings.Default.ZohoBooksApiOAuthBaseUri + "/token?client_id=" + ZohoClientsSettings.Default.ClientId +
                        "&client_secret=" + ZohoClientsSettings.Default.ClientSecret +
                        "&grant_type=client_credentials&scope=" + ZohoClientsSettings.Default.OAuthScope + "&soid=ZohoCRM.600 * ****434";

//                        "&state=" + ZohoClientsSettings.Default.OAuthState + "&response_type=" + ZohoClientsSettings.Default.OAuthResponseType +
//                        "&redirect_uri=" + ZohoClientsSettings.Default.OAuthRedirectUri + "&access_type=" + ZohoClientsSettings.Default.OAuthAccessType;

            return HttpClientHelpers.PostUsingEndpointUriAsync<string>(uri).Result;
        }


        /// <summary>
        /// The Entity Name (e.g. Sales Order, Task, Expenses, etc.) 
        /// </summary>
        protected readonly string _entityName;

        /// <summary>
        /// The Parent Entity Name (e.g. Sales Order, Task, Expenses, etc.) 
        /// </summary>
        protected readonly string _parentEntityName;

        /// <summary>
        /// The organisation id of the request.
        /// </summary>
        protected readonly string _organizationId;
    }
}
