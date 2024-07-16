using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class CustomField
    {
        [JsonPropertyName("customfield_id")]
        public string CustomfieldId { get; set; }

        [JsonPropertyName("index")]
        public int? Index { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}