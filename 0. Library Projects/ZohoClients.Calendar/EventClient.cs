using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZohoClients.Calendar
{
    public class EventClient : CalendarClient
    {
        public EventClient(HttpClient httpClient) 
            : base(httpClient)
        {
        }

        public Task<HttpResponseMessage> CreateAsync(Messages.PostEventsMessageBody events, string calendarUID)
        {
            //var s = JsonSerializer.Serialize(events);
            //var c = new StringContent(s);

            //var uri = ZohoClientsSettings.Default.ZohoCalendarBaseApi.Replace("", calendarUID);
            //var postResponse = _httpClientHelpers.PostUsingEndpointUriAsync<HttpClient>(uri, c);

            return Task.Run(() => new HttpResponseMessage());
        }
    }
}
