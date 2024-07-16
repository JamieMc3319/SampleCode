using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class Tax
    {
        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }

        [JsonPropertyName("tax_name")]
        public string TaxName { get; set; }

        [JsonPropertyName("tax_amount")]
        public int? TaxAmount { get; set; }
    }
}