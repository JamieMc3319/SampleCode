using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZohoClients.Calendar.Messages
{
    public class PostEventsMessageBody
    {
        [JsonPropertyName("events")]
        public List<Models.Event> Events { get; } = new List<Models.Event>();
    }
}