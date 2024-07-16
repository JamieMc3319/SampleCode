using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class DefaultTemplates
    {
        [JsonPropertyName("invoice_template_id")]
        public long? InvoiceTemplateId { get; set; }

        [JsonPropertyName("estimate_template_id")]
        public long? EstimateTemplateId { get; set; }

        [JsonPropertyName("creditnote_template_id")]
        public long? CreditnoteTemplateId { get; set; }

        [JsonPropertyName("purchaseorder_template_id")]
        public long? PurchaseorderTemplateId { get; set; }

        [JsonPropertyName("salesorder_template_id")]
        public long? SalesorderTemplateId { get; set; }

        [JsonPropertyName("retainerinvoice_template_id")]
        public long? RetainerinvoiceTemplateId { get; set; }

        [JsonPropertyName("paymentthankyou_template_id")]
        public long? PaymentthankyouTemplateId { get; set; }

        [JsonPropertyName("retainerinvoice_paymentthankyou_template_id")]
        public long? RetainerinvoicePaymentthankyouTemplateId { get; set; }

        [JsonPropertyName("invoice_email_template_id")]
        public long? InvoiceEmailTemplateId { get; set; }

        [JsonPropertyName("estimate_email_template_id")]
        public long? EstimateEmailTemplateId { get; set; }

        [JsonPropertyName("creditnote_email_template_id")]
        public long? CreditnoteEmailTemplateId { get; set; }

        [JsonPropertyName("purchaseorder_email_template_id")]
        public long? PurchaseorderEmailTemplateId { get; set; }

        [JsonPropertyName("salesorder_email_template_id")]
        public long? SalesorderEmailTemplateId { get; set; }

        [JsonPropertyName("retainerinvoice_email_template_id")]
        public long? RetainerinvoiceEmailTemplateId { get; set; }

        [JsonPropertyName("paymentthankyou_email_template_id")]
        public long? PaymentthankyouEmailTemplateId { get; set; }

        [JsonPropertyName("retainerinvoice_paymentthankyou_email_template_id")]
        public long? RetainerinvoicePaymentthankyouEmailTemplateId { get; set; }
    }
}
