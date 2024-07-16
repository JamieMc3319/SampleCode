using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class Address
    {
        [JsonPropertyName("attention")]
        public string Attention { get; set; }

        [JsonPropertyName("address")]
        [MaxLength(500)]
        public string Street1 { get; set; }

        [JsonPropertyName("street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// City of the customer’s billing address.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }

        /// <summary>
        /// State of the customer’s billing address.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Zip code of the customer’s billing address.
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Country of the customer’s billing address.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Customer's fax number.
        /// </summary>
        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Search contacts by phone number of the contact person. Variants: phone_startswith and phone_contains.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
