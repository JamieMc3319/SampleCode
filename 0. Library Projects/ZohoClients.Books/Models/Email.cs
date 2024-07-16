using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class Email
    {
        [JsonPropertyName("send_from_org_email_id")]
        public bool SendFromOrgEmailId { get; set; }

        [JsonPropertyName("to_mail_ids")]
        public List<string> ToMailIds { get; set; }

        [JsonPropertyName("cc_mail_ids")]
        public List<string> CcMailIds { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
