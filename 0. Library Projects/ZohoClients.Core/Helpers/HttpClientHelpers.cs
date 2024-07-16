using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using ZohoClients.Core.Attributes;

namespace ZohoClients.Core.Helpers
{
    public class HttpClientHelpers
    {
        /// <summary>
        /// Http client used to connect to Zoho Apis
        /// </summary>
        private static HttpClient _httpClient;

        public HttpClientHelpers(HttpClient httpClient)
        {
            _httpClient = _httpClient ?? httpClient;
        }


        /// <summary>
        /// Sends POST to specified Uri.
        /// </summary>
        /// <typeparam name="TResponse">The type of response from Zoho API</typeparam>
        /// <param name="endpointUri"></param>
        /// <param name="entity"></param>
        /// <returns>The response from Zoho API</returns>
        public async ValueTask<TResponse> PostUsingEndpointUriAsync<TResponse>(string endpointUri, object entity = null)
        {
            StringContent stringContent = null;

            if (entity != null)
            {
                var content = JsonSerializer.Serialize(entity);
                stringContent = new StringContent(content);
            }

            var responseMessage = await _httpClient.PostAsync(endpointUri, stringContent);

            responseMessage.EnsureSuccessStatusCode();
            var responseContentStream = await responseMessage.Content.ReadAsStreamAsync();

            var result = await JsonSerializer.DeserializeAsync<TResponse>(responseContentStream);
            return result;
        }

        /// <summary>
        /// Sends GET to specified Uri.
        /// </summary>
        /// <typeparam name="TResponse">The type of response from Zoho API</typeparam>
        /// <param name="endpointUri"></param>
        /// <returns>The response from Zoho API</returns>
        public async ValueTask<TResponse> GetUsingEndpointUriAsync<TResponse>(string endpointUri)
        {
            var responseMessage = await _httpClient.GetAsync(endpointUri);

            responseMessage.EnsureSuccessStatusCode();
            var responseContentStream = await responseMessage.Content.ReadAsStreamAsync();

            var response = await responseMessage.Content.ReadAsStringAsync();

            return await JsonSerializer.DeserializeAsync<TResponse>(responseContentStream);
        }

        /// <summary>
        /// Sends PUT to specified Uri.
        /// </summary>
        /// <typeparam name="TResponse">The type of response from Zoho API</typeparam>
        /// <param name="endpointUri"></param>
        /// <param name="entity"></param>
        /// <returns>The response from Zoho API</returns>
        public async ValueTask<TResponse> PutUsingEndpointUriAsync<TResponse>(string endpointUri, object entity = null)
        {
            StringContent stringContent = null;

            if (entity != null)
            {
                var content = JsonSerializer.Serialize(entity);
                stringContent = new StringContent(content);
            }

            var responseMessage = await _httpClient.PutAsync(endpointUri, stringContent);

            responseMessage.EnsureSuccessStatusCode();
            var responseContentStream = await responseMessage.Content.ReadAsStreamAsync();

            var result = await JsonSerializer.DeserializeAsync<TResponse>(responseContentStream);
            return result;
        }

        /// <summary>
        /// Sends DELETE to specified Uri.
        /// </summary>
        /// <typeparam name="TResponse">The type of response from Zoho API</typeparam>
        /// <param name="endpointUri"></param>
        /// <returns>The response from Zoho API</returns>
        public async ValueTask<TResponse> DeleteUsingEndpointUriAsync<TResponse>(string endpointUri)
        {
            var responseMessage = await _httpClient.DeleteAsync(endpointUri);

            responseMessage.EnsureSuccessStatusCode();
            var responseContentStream = await responseMessage.Content.ReadAsStreamAsync();

            var result = await JsonSerializer.DeserializeAsync<TResponse>(responseContentStream);
            return result;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0019:Use pattern matching", Justification = "Produces unreadable code.")]
        public string AddParamsToQueryString(object model)
        {
            var propInfos = model.GetType().GetProperties();
            var qs = new List<string>(); 

            foreach (var propInfo in propInfos)
            {
                var propParamNameAttr = propInfo.GetCustomAttributes(typeof(QueryStringParameterNameAttribute), false).FirstOrDefault() as QueryStringParameterNameAttribute;

                var qsName = propParamNameAttr == null ? propInfo.Name : propParamNameAttr.ParameterName;

                var propValue = propInfo.GetValue(model, null);

                if (propValue == null)
                {
                    continue;
                }

                if (propInfo.PropertyType.IsEnum)
                {
                    var enumValue = propValue.GetType()
                        .GetTypeInfo()
                        .DeclaredMembers
                        .SingleOrDefault(e => e.Name == propValue.ToString())?
                        .GetCustomAttribute<EnumMemberAttribute>(false)?
                        .Value;

                    qs.Add(qsName + "=" + enumValue);
                }
                else if (propInfo.PropertyType == typeof(bool))
                {
                    qs.Add(qsName + "=" + propValue.ToString().ToLower());
                }
                else
                {
                    qs.Add(qsName + "=" + propValue.ToString());
                }
            }

            return string.Join("&", qs.ToArray());
        }   
    }
}
