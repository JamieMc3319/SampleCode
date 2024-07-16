using System.Text.Json.Serialization;

namespace ZohoClients.Books.Messages
{
    public class PageContextBaseObject
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("has_more_page")]
        public bool HasMorePage { get; set; }

        [JsonPropertyName("sort_column")]
        public string SortColumn { get; set; }

        [JsonPropertyName("sort_order")]
        public string SortOrder { get; set; }
    }
}