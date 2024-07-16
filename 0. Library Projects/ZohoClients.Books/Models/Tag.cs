using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class Tag
    {
        [JsonPropertyName("is_tag_mandatory")]
        public bool? IsTagMandatory { get; set; }

        [JsonPropertyName("tag_id")]
        public long? TagId { get; set; }

        [JsonPropertyName("tag_name")]
        public string TagName { get; set; }

        [JsonPropertyName("tag_option_id")]
        public long? TagOptionId { get; set; }

        [JsonPropertyName("tag_option_name")]
        public string TagOptionName { get; set; }
    }
}
