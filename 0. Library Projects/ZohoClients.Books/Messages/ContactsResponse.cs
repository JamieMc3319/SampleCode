using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZohoClients.Books.Messages
{
    public class ContactsResponse : PaginatedResponseBaseObject
    {
        [JsonPropertyName("contact_persons")]
        public IEnumerable<Models.ContactReadModel> Contacts { get; set; }
    }
}
