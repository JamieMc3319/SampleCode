using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class LineItem
    {
        [JsonPropertyName("item_order")]
        public int? ItemOrder { get; set; }

        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        [JsonPropertyName("rate")]
        public int? Rate { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        [JsonPropertyName("hsn_or_sac")]
        public int? HsnOrSac { get; set; }

        [JsonPropertyName("sat_item_key_code")]
        public int? SatItemKeyCode { get; set; }

        [JsonPropertyName("unitkey_code")]
        public string UnitkeyCode { get; set; }

        [JsonPropertyName("warehouse_id")]
        public string WarehouseId { get; set; }

        [JsonPropertyName("warehouse_name")]
        public string WarehouseName { get; set; }

        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }

        [JsonPropertyName("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("item_custom_fields")]
        public List<CustomField> ItemCustomFields { get; set; }

        [JsonPropertyName("tax_exemption_id")]
        public string TaxExemptionId { get; set; }

        [JsonPropertyName("tax_exemption_code")]
        public string TaxExemptionCode { get; set; }

        [JsonPropertyName("tax_treatment_code")]
        public string TaxTreatmentCode { get; set; }

        [JsonPropertyName("avatax_exempt_no")]
        public string AvataxExemptNo { get; set; }

        [JsonPropertyName("avatax_use_code")]
        public string AvataxUseCode { get; set; }

        [JsonPropertyName("project_id")]
        public long? ProjectId { get; set; }
    }
}