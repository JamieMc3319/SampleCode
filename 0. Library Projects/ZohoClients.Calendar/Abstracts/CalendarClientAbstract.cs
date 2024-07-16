using System.Net.Http;

namespace ZohoClients.Calendar.Abstracts
{
    /// <summary>
    /// <see cref="CalendarClientAbstract"/> class.
    /// </summary>
    public abstract class CalendarClientAbstract : Core.ZohoClientsBase
    {
        /// <summary>
        /// <see cref="CalendarClientAbstract"/> constructor.
        /// </summary>
        /// <param name="httpClient"></param>
        protected CalendarClientAbstract(HttpClient httpClient)
            : base(httpClient)
        {
        }
    }
}
