using System.Text.Json.Serialization;

namespace ZohoClients.Books.Messages
{
    public abstract class ResponseBaseObject
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
