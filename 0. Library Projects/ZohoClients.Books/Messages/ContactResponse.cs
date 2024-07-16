using System.Text.Json.Serialization;

namespace ZohoClients.Books.Messages
{
    /// <summary>
    /// 
    /// </summary>
    public class ContactResponse : ResponseBaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("contact")]
        public Models.ContactReadModel Contact { get; set; }
    }
}
