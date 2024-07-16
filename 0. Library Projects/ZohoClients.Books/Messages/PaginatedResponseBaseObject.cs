using System.Text.Json.Serialization;

namespace ZohoClients.Books.Messages
{
    public abstract class PaginatedResponseBaseObject : ResponseBaseObject
    {
        [JsonPropertyName("page_context")]
        public PageContextBaseObject PageContext { get; set; }
    }
}