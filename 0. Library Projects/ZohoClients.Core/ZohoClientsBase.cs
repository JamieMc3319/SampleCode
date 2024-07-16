using System.ComponentModel;
using System.Net.Http;

namespace ZohoClients.Core
{
    /// <summary>
    /// Contains methods to call get, post, put and delete to an endpoint.
    /// </summary>
    [LicenseProvider]
    public abstract class ZohoClientsBase
    {
        /// <summary>
        /// <see cref="ZohoClientsBase" /> constructor.
        /// </summary>
        /// <param name="httpClient">Http client used to connect to Zoho Apis</param>
        protected ZohoClientsBase(HttpClient httpClient)
        {
            HttpClientHelpers = new Helpers.HttpClientHelpers(httpClient);
        }

        protected Helpers.HttpClientHelpers HttpClientHelpers { get; private set; }
    }
}
