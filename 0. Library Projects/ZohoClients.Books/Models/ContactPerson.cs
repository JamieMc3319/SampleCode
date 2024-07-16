using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    /// <summary>
    /// Contact Person model.
    /// </summary>
    public class ContactPerson
    {
        /// <summary>
        /// ID of the contact.
        /// </summary>
        [JsonPropertyName("contact_id")]
        public long ContactId { get; set; }

        /// <summary>
        /// ID of the custom person.
        /// </summary>
        [JsonPropertyName("contact_person_id")]
        public string ContactPersonId { get; set; }

        /// <summary>
        /// Salutation for the contact.
        /// </summary>
        [JsonPropertyName("salutation")]
        public string Salutation { get; set; }

        /// <summary>
        /// First name for the contact. Max Length 100.
        /// </summary>
        [JsonPropertyName("first_name")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name for the contact. Max Length 100.
        /// </summary>
        [JsonPropertyName("last_name")]
        [MaxLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Email address of the contact person.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Search contacts by phone number of the contact person. Variants: phone_startswith and phone_contains.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Search contacts by mobile number of the contact person.
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// To mark contact person as primary for contact. Allowed value is true only.
        /// </summary>
        [JsonPropertyName("is_primary_contact")]
        public bool IsPrimaryContact { get; set; }

        /// <summary>
        /// Skype details for the contact person.
        /// </summary>
        [JsonPropertyName("skype")]
        public string Skype { get; set; }

        /// <summary>
        /// Designation for the contact person.
        /// </summary>
        [JsonPropertyName("designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Department for the contact person.
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("is_added_in_portal")]
        public bool? IsAddedInPortal { get; set; }

        /// <summary>
        /// To enable client portal for the primary contact. Allowed value is true and false.
        /// </summary>
        [JsonPropertyName("enable_portal")]
        public bool EnablePortal { get; set; }
    }
}