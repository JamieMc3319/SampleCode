using System.Collections.Generic;
using System.Text.Json.Serialization;
using System;

namespace ZohoClients.Books.Models
{
    public class SalesOrder
    {
        [JsonPropertyName("salesorder_id")]
        public string SalesorderId { get; set; }

        [JsonPropertyName("documents")]
        public List<string> Documents { get; set; }

        [JsonPropertyName("is_pre_gst")]
        public bool? IsPreGst { get; set; }

        [JsonPropertyName("gst_no")]
        public string GstNo { get; set; }

        [JsonPropertyName("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonPropertyName("place_of_supply")]
        public string PlaceOfSupply { get; set; }

        [JsonPropertyName("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonPropertyName("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonPropertyName("zcrm_potential_id")]
        public string ZcrmPotentialId { get; set; }

        [JsonPropertyName("zcrm_potential_name")]
        public string ZcrmPotentialName { get; set; }

        [JsonPropertyName("salesorder_number")]
        public string SalesorderNumber { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("shipment_date")]
        public string ShipmentDate { get; set; }

        [JsonPropertyName("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Array of IDs of contact person(s) for whom sales order has to be sent.
        /// contact_persons in JSON
        /// </summary>
        [JsonPropertyName("contact_persons")]
        public List<string> ContactPersonIds { get; set; }

        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("exchange_rate")]
        public double? ExchangeRate { get; set; }

        [JsonPropertyName("discount_amount")]
        public int? DiscountAmount { get; set; }

        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        [JsonPropertyName("discount_applied_on_amount")]
        public int? DiscountAppliedOnAmount { get; set; }

        [JsonPropertyName("is_discount_before_tax")]
        public bool? IsDiscountBeforeTax { get; set; }

        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        [JsonPropertyName("estimate_id")]
        public string EstimateId { get; set; }

        [JsonPropertyName("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonPropertyName("delivery_method_id")]
        public string DeliveryMethodId { get; set; }

        [JsonPropertyName("is_inclusive_tax")]
        public bool? IsInclusiveTax { get; set; }

        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; set; }

        [JsonPropertyName("shipping_charge")]
        public int? ShippingCharge { get; set; }

        [JsonPropertyName("adjustment")]
        public double? Adjustment { get; set; }

        [JsonPropertyName("adjustment_description")]
        public string AdjustmentDescription { get; set; }

        [JsonPropertyName("sub_total")]
        public int? SubTotal { get; set; }

        [JsonPropertyName("tax_total")]
        public int? TaxTotal { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("taxes")]
        public List<Tax> Taxes { get; set; }

        [JsonPropertyName("price_precision")]
        public int? PricePrecision { get; set; }

        [JsonPropertyName("is_emailed")]
        public bool? IsEmailed { get; set; }

        [JsonPropertyName("billing_address")]
        public Address BillingAddress { get; set; }

        [JsonPropertyName("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("terms")]
        public string Terms { get; set; }

        [JsonPropertyName("custom_fields")]
        public List<CustomField> CustomFields { get; set; }

        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }

        [JsonPropertyName("page_width")]
        public string PageWidth { get; set; }

        [JsonPropertyName("page_height")]
        public string PageHeight { get; set; }

        [JsonPropertyName("orientation")]
        public string Orientation { get; set; }

        [JsonPropertyName("template_type")]
        public string TemplateType { get; set; }

        [JsonPropertyName("created_time")]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("last_modified_time")]
        public DateTime? LastModifiedTime { get; set; }

        [JsonPropertyName("created_by_id")]
        public string CreatedById { get; set; }

        [JsonPropertyName("attachment_name")]
        public string AttachmentName { get; set; }

        [JsonPropertyName("can_send_in_mail")]
        public bool? CanSendInMail { get; set; }

        [JsonPropertyName("salesperson_id")]
        public string SalespersonId { get; set; }

        [JsonPropertyName("salesperson_name")]
        public string SalespersonName { get; set; }

        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }
    }
}