using System.Text.Json.Serialization;

namespace ZohoClients.Books.Messages
{
    public class ContactPersonResponse : ResponseBaseObject
    {
        [JsonPropertyName("contact_person")]
        public Models.ContactPerson ContactPerson { get; set; }
    }
}
