using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using ZohoClients.Core.Attributes;

namespace ZohoClients.Books.Models
{
    /// <summary>
    /// Base of object for Zoho contact models.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class ContactBase
    {
        /// <summary>
        /// Display Name of the contact. Max-length [200]
        /// </summary>
        [JsonPropertyName("contact_name")]
        [MaxLength(200)]
        [Required]
        public string ContactName { get; set; }

        /// <summary>
        /// Company Name of the contact. Max-length [200]
        /// </summary>
        [JsonPropertyName("company_name")]
        [MaxLength(200)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The Id of the contact
        /// </summary>
        [JsonPropertyName("has_transaction")]
        public bool HasTransaction { get; set; }

        /// <summary>
        /// Contact type of the contact.
        /// </summary>
        [JsonPropertyName("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// Type of the customer.
        /// </summary>
        [JsonPropertyName("customer_sub_type")]
        public string CustomerSubType { get; set; }

        /// <summary>
        /// Credit limit for a customer.
        /// </summary>
        [JsonPropertyName("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// To enable client portal for the contact. Allowed value is true and false.
        /// </summary>
        [JsonPropertyName("is_portal_enabled")]
        public bool? IsPortalEnabled { get; set; }

        /// <summary>
        /// language of a contact. allowed values de,en,es,fr,it,ja,nl,pt,pt_br,sv,zh,en_gb
        /// </summary>
        [JsonPropertyName("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// US, CA, AU, IN + MX only. Boolean to track the taxability of the customer.
        /// </summary>
        [JsonPropertyName("is_taxable")]
        public bool? IsTaxable { get; set; }

        /// <summary>
        /// IN + US only. ID of the tax or tax group that can be collected from the contact. Tax can be given only if is_taxable is true.
        /// </summary>
        [JsonPropertyName("tax_id")]
        public long? TaxId { get; set; }

        /// <summary>
        /// MX only. ID of the TDS tax.
        /// </summary>
        [JsonPropertyName("tds_tax_id")]
        public string TdsTaxId { get; set; }

        /// <summary>
        /// IN only. Tax name.
        /// </summary>
        [JsonPropertyName("tax_name")]
        public string TaxName { get; set; }

        /// <summary>
        /// Enter tax percentage.
        /// </summary>
        [JsonPropertyName("tax_percentage")]
        public double? TaxPercentage { get; set; }

        /// <summary>
        /// US only. ID of the tax authority. Tax authority depends on the location of the customer. For example, if the customer is located in NY, then the tax authority is NY tax authority.
        /// </summary>
        [JsonPropertyName("tax_authority_id")]
        public long? TaxAuthorityId { get; set; }

        /// <summary>
        /// US, CA, AU, IN only. ID of the tax exemption.
        /// </summary>
        [JsonPropertyName("tax_exemption_id")]
        public long? TaxExemptionId { get; set; }

        /// <summary>
        /// Enter tax authority name.
        /// </summary>
        [JsonPropertyName("tax_authority_name")]
        public string TaxAuthorityName { get; set; }

        /// <summary>
        /// US, CA, AU, IN only. Enter tax exemption code.
        /// </summary>
        [JsonPropertyName("tax_exemption_code")]
        public string TaxExemptionCode { get; set; }

        /// <summary>
        /// IN only. Location of the contact. (This node identifies the place of supply and source of supply when invoices/bills are raised for the customer/vendor respectively. This is not applicable for Overseas contacts)
        /// </summary>
        [JsonPropertyName("place_of_contact")]
        public string PlaceOfContact { get; set; }

        /// <summary>
        /// IN only. 15 digit GST identification number of the customer/vendor.
        /// </summary>
        [JsonPropertyName("gst_no")]
        public string GstNo { get; set; }

        /// <summary>
        /// GB only. VAT treatment of the contact.Allowed Values:  uk (a business that is located in the UK.), eu_vat_registered(a business that is reg for VAT and trade goods between Northern Ireland and EU.This node is available only for organizations enabled for NI protocal in VAT Settings.) and overseas (a business that is located outside UK.Pre Brexit, this was split as eu_vat_registered, eu_vat_not_registered and non_eu ).
        /// </summary>
        [JsonPropertyName("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonPropertyName("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonPropertyName("tax_regime")]
        public string TaxRegime { get; set; }

        [JsonPropertyName("is_tds_registered")]
        public bool? IsTdsRegistered { get; set; }

        [JsonPropertyName("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonPropertyName("is_linked_with_zohocrm")]
        public bool? IsLinkedWithZohocrm { get; set; }

        /// <summary>
        /// Website of the contact.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("owner_id")]
        public long? OwnerId { get; set; }

        [JsonPropertyName("primary_contact_id")]
        public long? PrimaryContactId { get; set; }

        /// <summary>
        /// Net payment term for the customer.
        /// </summary>
        [JsonPropertyName("payment_terms")]
        public int PaymentTerms { get; set; }

        /// <summary>
        /// Label for the paymet due details.
        /// </summary>
        [JsonPropertyName("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        /// <summary>
        /// Currency ID of the customer's currency.
        /// </summary>
        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("opening_balance_amount")]
        public int? OpeningBalanceAmount { get; set; }

        [JsonPropertyName("exchange_rate")]
        public int? ExchangeRate { get; set; }

        [JsonPropertyName("outstanding_receivable_amount")]
        public int? OutstandingReceivableAmount { get; set; }

        [JsonPropertyName("outstanding_receivable_amount_bcy")]
        public int? OutstandingReceivableAmountBcy { get; set; }

        [JsonPropertyName("unused_credits_receivable_amount")]
        public double? UnusedCreditsReceivableAmount { get; set; }

        [JsonPropertyName("unused_credits_receivable_amount_bcy")]
        public double? UnusedCreditsReceivableAmountBcy { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("payment_reminder_enabled")]
        public bool? PaymentReminderEnabled { get; set; }

        [JsonPropertyName("custom_fields")]
        public List<CustomField> CustomFields { get; set; }

        /// <summary>
        /// Billing address of the contact.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Customer's shipping address object.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }

        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// Contact persons of a contact.
        /// </summary>
        [JsonPropertyName("contact_persons")]
        public List<ContactPerson> ContactPersons { get; set; }

        [JsonPropertyName("default_templates")]
        public DefaultTemplates DefaultTemplates { get; set; }

        /// <summary>
        /// Commennts about the payment made by the contact.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("created_time")]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("last_modified_time")]
        public DateTime? LastModifiedTime { get; set; }
    }

    /// <summary>
    /// Zoho contact read model.
    /// </summary>
    public class ContactReadModel : ContactBase
    {
        /// <summary>
        /// ID of the contact
        /// </summary>
        [JsonPropertyName("contact_id")]
        public string ContactId { get; set; }
    }


    /// <summary>
    /// Zoho contact create model.
    /// </summary>
    public class ContactCreateOrUpdateModel : ContactBase
    {
        /// <summary>
        /// Filter all your reports based on the tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// US only. Boolean to track a contact for 1099 reporting.
        /// </summary>
        [JsonPropertyName("track_1099")]
        public bool? Track1099 { get; set; }

        /// <summary>
        /// US only. Tax ID type of the contact, it can be SSN, ATIN, ITIN or EIN.
        /// </summary>
        [JsonPropertyName("tax_id_type")]
        public Enums.TaxIdType TaxIdType { get; set; }

        /// <summary>
        /// US only. Tax ID of the contact.
        /// </summary>
        [JsonPropertyName("tax_id_value")]
        public string TaxIdValue { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ContactSearchModel
    {
        /// <summary>
        /// Search contacts by contact name. Max-length [100] Variants: contact_name_startswith and contact_name_contains.
        /// </summary>
        [QueryStringParameterName("contact_name")]
        [MaxLength(100)]
        public string ContactName { get; set; }

        /// <summary>
        /// Search contacts by company name. Max-length [100] Variants: company_name_startswith and company_name_contains.
        /// </summary>
        [QueryStringParameterName("company_name")]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Search contacts by first name. Max-length [100] Variants: first_name_startswith and first_name_contains.
        /// </summary>
        [QueryStringParameterName("first_name")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Search contacts by last name of the contact person. Max-length [100] Variants: last_name_startswith and last_name_contains.
        /// </summary>
        [QueryStringParameterName( "last_name")]
        [MaxLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Search contacts by any of the address fields. Max-length [100] Variants: address_startswith and address_contains.
        /// </summary>
        [QueryStringParameterName("address")]
        [MaxLength(100)]
        public string Address { get; set; }

        /// <summary>
        /// Search contacts by email of the contact person. Max-length [100] Variants: email_startswith and email_contains.
        /// </summary>
        [QueryStringParameterName("email")]
        [MaxLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// Search contacts by phone number of the contact person. Max-length [100] Variants: phone_startswith and phone_contains.
        /// </summary>
        [QueryStringParameterName("phone")]
        [MaxLength(100)]
        public string Phone { get; set; }

        /// <summary>
        /// Filter contacts by status. Allowed Values: Status.All, Status.Active, Status.Inactive, Status.Duplicate and Status.Crm.
        /// </summary>
        [QueryStringParameterName("filter_by")]
        public FilterByValues FilterBy { get; set; }

        /// <summary>
        /// Search contacts by contact name or notes. Max-length [100].
        /// </summary>
        [QueryStringParameterName("search_text")]
        [MaxLength(100)]
        public string SearchText { get; set; }

        /// <summary>
        /// Sort contacts. Allowed Values: contact_name, first_name, last_name, email, outstanding_receivable_amount, created_time and last_modified_time.
        /// </summary>
        [QueryStringParameterName("sort_column")]
        [MaxLength(100)]
        public SortColumnValues SortColumn { get; set; }

        /// <summary>
        /// CRM Contact ID for the contact.
        /// </summary>
        [QueryStringParameterName("zcrm_contact_id")]
        public string ZCRM_ContactId { get; set; }

        /// <summary>
        /// CRM Account ID for the contact.
        /// </summary>
        [QueryStringParameterName("zcrm_account_id")]
        public string ZCRM_AccountId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public enum FilterByValues
        {
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "Status.All")] 
            StatusAll,

            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "Status.Active")] 
            StatusActive, 

            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "Status.Inactive")] 
            StatusInactive, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "Status.Duplicate")] 
            StatusDuplicate, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "Status.Crm")] 
            StatusCrm
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SortColumnValues
        {
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "contact_name")] contact_name, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "first_name")] first_name, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "last_name")] last_name, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "email")] email, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "outstanding_receivable_amount")] outstanding_receivable_amount, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "created_time")] created_time, 
            
            /// <summary>
            /// 
            /// </summary>
            [EnumMember(Value = "last_modified_time")] last_modified_time
        }
    }
}