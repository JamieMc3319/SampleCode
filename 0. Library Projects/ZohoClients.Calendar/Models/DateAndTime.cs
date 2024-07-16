using System.Text.Json.Serialization;

namespace ZohoClients.Calendar.Models
{
    public class DateAndTime
    {
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("start")]
        public string Start { get; set; }

        [JsonPropertyName("end")]
        public string End { get; set; }
    }
}
