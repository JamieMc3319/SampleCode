using System.Net.Http;

namespace ZohoClients.Calendar
{
    public abstract class CalendarClient : Abstracts.CalendarClientAbstract
    {
        protected CalendarClient(HttpClient httpClient) 
            : base(httpClient)
        {
        }
    }
}
