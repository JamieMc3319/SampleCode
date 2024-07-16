using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZohoClients.Books.Clients
{
    /// <summary>
    /// The list of contacts created.
    /// <br /><br />
    /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#overview">here</see>.
    /// </summary>
    public class ContactsClient : Abstracts.BooksClientAbstract
    {
        /// <summary>
        /// The list of contacts created.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#overview">here</see>.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="httpClient"></param>>
        public ContactsClient(string organizationId, HttpClient httpClient = null, string accessToken = null, string refreshToken = null)
            : base("contacts", organizationId, httpClient)
        {
        }



        /// <summary>
        /// Create a contact with given information.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#create-a-contact">here</see>.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns>Response from Zoho API when bank rule is created.</returns>
        public async ValueTask<Messages.ContactResponse> CreateAsync(Models.ContactCreateOrUpdateModel contact)
        {
            var grantToken = GetGrantToken("ZohoBooks.invoices.CREATE");

            return await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ContactResponse>(CreateUri(), contact);
        }

        /// <summary>
        /// List all contacts with pagination.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#list-contacts">here</see>.
        /// </summary>
        /// <returns>All contacts with pagination.</returns>
        public async ValueTask<Messages.ContactsResponse> GetListAsync(Models.ContactSearchModel contactSearchModel) =>
            await HttpClientHelpers.GetUsingEndpointUriAsync<Messages.ContactsResponse>(GetListUri(contactSearchModel));


        /// <summary>
        /// Update an existing contact. To delete a contact person, remove it from the contact_persons list.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#update-a-contact">here</see>.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="contact"></param>
        /// <returns>Response from Zoho API when bank rule is updated.</returns>
        public async ValueTask<Messages.ContactResponse> UpdateAsync(string contactId, Models.ContactCreateOrUpdateModel contact) =>
            await HttpClientHelpers.PutUsingEndpointUriAsync<Messages.ContactResponse>(UpdateUri(contactId), contact);


        /// <summary>
        /// Get details of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#get-contact">here</see>.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>Details of a contact.</returns>
        public async ValueTask<Messages.ContactResponse> GetSingleAsync(string contactId) =>
            await HttpClientHelpers.GetUsingEndpointUriAsync<Messages.ContactResponse>(GetSingleUri(contactId));


        /// <summary>
        /// Delete an existing contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#delete-a-contact">here</see>.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public async ValueTask<Messages.ResponseBaseObject> DeleteAsync(string contactId) =>
            await HttpClientHelpers.DeleteUsingEndpointUriAsync<Messages.ResponseBaseObject>(DeleteUri(contactId));


        /// <summary>
        /// Mark a contact as active.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#mark-as-active">here</see>.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> MarkAsActiveAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(MarkAsActiveUri(contactId));


        /// <summary>
        /// Mark a contact as inactive.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#mark-as-inactive">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> MarkAsInactiveAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(MarkAsInactiveUri(contactId));


        /// <summary>
        /// Enable portal access for a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#enable-portal-access">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <param name="contactPersonIds">The contactPersonIds</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> EnablePortalAccessAsync(string contactId, IEnumerable<string> contactPersonIds)
        {
            var contactPersons = contactPersonIds.Select(contactPersonId => new
            {
                contact_person_id = contactPersonId
            });

            var body = new
            {
                contact_persons = contactPersons
            };

            return await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(EnablePortalAccessUri(contactId), body);
        }


        /// <summary>
        /// Gets Url to Enable automated payment reminders for a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#enable-payment-reminders">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> EnablePaymentRemindersAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(EnablePaymentRemindersUri(contactId));
        

        /// <summary>
        /// Gets Url to Disable automated payment reminders for a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#disable-payment-reminders">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> DisablePaymentRemindersAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(DisablePaymentsReminderUri(contactId));


        /// <summary>
        /// Gets Url to Email statement to the contact. If JSONString is not inputted, mail will be sent with the default mail content.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#email-statement">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> EmailStatementAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(EmailStatementUri(contactId));


        /// <summary>
        /// Gets Url to Get the statement mail content.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#get-statement-mail-content">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> GetStatementMailContentAsync(string contactId) =>
            await HttpClientHelpers.GetUsingEndpointUriAsync<Messages.ResponseBaseObject>(GetStatementMailContentUri(contactId));


        /// <summary>
        /// Gets Url to Send email to contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#email-contact">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> EmailContactAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(EmailContactUri(contactId));


        /// <summary>
        /// Gets Url to List recent activities of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#list-comments">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> ListCommentsAsync(string contactId) =>
            await HttpClientHelpers.GetUsingEndpointUriAsync<Messages.ResponseBaseObject>(ListCommentsUri(contactId));


        /// <summary>
        /// Gets Url to Add an additional address for a contact using the arguments below.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#add-additional-address">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> AddAdditionalAddressAsync(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(AddAdditionalAddressUri(contactId));


        /// <summary>
        /// Gets Url to Get addresses of a contact including its Shipping Address, Billing Address and other additional addresses.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#get-contact-addresses">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> GetContactAddressesAsync(string contactId) =>
            await HttpClientHelpers.GetUsingEndpointUriAsync<Messages.ResponseBaseObject>(GetContactAddressesUri(contactId));


        /// <summary>
        /// Gets Url to Edit the additional address of a contact using the arguments below.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#edit-additional-address">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <param name="addressId">ID of the address</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> EditAdditionalAddressAsync(string contactId, string addressId) =>
            await HttpClientHelpers.PutUsingEndpointUriAsync<Messages.ResponseBaseObject>(EditAdditionalAddressUri(contactId, addressId));


        /// <summary>
        /// Gets Url to Delete the additional address of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#delete-additional-address">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <param name="addressId">ID of the address</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> DeleteAdditionalAddressAsync(string contactId, string addressId) =>
            await HttpClientHelpers.DeleteUsingEndpointUriAsync<Messages.ResponseBaseObject>(DeleteAdditionalAddressUri(contactId, addressId));


        /// <summary>
        /// Gets Url to List the refund history of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#list-refunds">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> ListRefundsAsync(string contactId) =>
            await HttpClientHelpers.GetUsingEndpointUriAsync<Messages.ResponseBaseObject>(ListRefundsUri(contactId));


        /// <summary>
        /// Gets Url to Track a contact for 1099 reporting: (Note: This API is only available when the organization's country is U.S.A).
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#track-1099">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> Track1099Async(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(Track1099Uri(contactId));


        /// <summary>
        /// Gets Url to stop tracking payments to a vendor for 1099 reporting. (Note: This API is only available when the organization's country is U.S.A).
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#untrack-1099">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>A <see cref="Messages.ResponseBaseObject" /> containing the results of the operation.</returns>
        public virtual async ValueTask<Messages.ResponseBaseObject> Untrack1099Async(string contactId) =>
            await HttpClientHelpers.PostUsingEndpointUriAsync<Messages.ResponseBaseObject>(Untrack1099Uri(contactId));


        // Uri Getters

        /// <summary>
        /// Gets Url to create a contact with given information.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#create-a-contact">here</see>.
        /// </summary>
        /// <returns>Url to create a contact with given information.</returns>
        public string CreateUri() =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to list all contacts with pagination.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#list-contacts">here</see>.
        /// </summary>
        /// <returns>Url to list all contacts with pagination.</returns>
        public string GetListUri(Models.ContactSearchModel contactSearchModel) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}?organization_id={_organizationId}&{HttpClientHelpers.AddParamsToQueryString(contactSearchModel)}";

        /// <summary>
        /// Gets Url to update an existing contact. To delete a contact person, remove it from the contact_persons list.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#update-a-contact">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to make changes to the rule, add or modify it and update.</returns>
        public string UpdateUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to Get details of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/bank-rules/#get-a-rule">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Get details of a contact.</returns>
        public string GetSingleUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to Delete an existing contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/bank-contacts/#delete-contact">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Delete an existing contact.</returns>
        public string DeleteUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to Mark a contact as active.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#mark-as-active">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Mark a contact as active.</returns>
        public string MarkAsActiveUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/active?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to Mark a contact as inactive.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#mark-as-inactive">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Mark a contact as inactive.</returns>
        public string MarkAsInactiveUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/inactive?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to Enable portal access for a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#enable-portal-access">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Enable portal access for a contact.</returns>
        public string EnablePortalAccessUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/portal/enable?organization_id={_organizationId}";

        /// <summary>
        /// Gets Url to Enable automated payment reminders for a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#enable-payment-reminders">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Enable automated payment reminders for a contact.</returns>
        public string EnablePaymentRemindersUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/paymentreminder/enable?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Disable automated payment reminders for a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#disable-payment-reminders">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Disable automated payment reminders for a contact.</returns>
        public string DisablePaymentsReminderUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/paymentreminder/disable?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Email statement to the contact. If JSONString is not inputted, mail will be sent with the default mail content.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#email-statement">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Email statement to the contact. If JSONString is not inputted, mail will be sent with the default mail content.</returns>
        public string EmailStatementUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/statements/email?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Get the statement mail content.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#get-statement-mail-content">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Get the statement mail content.</returns>
        public string GetStatementMailContentUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/statements/email?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Send email to contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#email-contact">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Send email to contact.</returns>
        public string EmailContactUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/email?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to List recent activities of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#list-comments">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to List recent activities of a contact.</returns>
        public string ListCommentsUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/comments?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Add an additional address for a contact using the arguments below.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#add-additional-address">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Add an additional address for a contact using the arguments below.</returns>
        public string AddAdditionalAddressUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/address?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Get addresses of a contact including its Shipping Address, Billing Address and other additional addresses.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#get-contact-addresses">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Get addresses of a contact including its Shipping Address, Billing Address and other additional addresses.</returns>
        public string GetContactAddressesUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/address?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Edit the additional address of a contact using the arguments below.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#edit-additional-address">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <param name="addressId">ID of the address</param>
        /// <returns>Url to Edit the additional address of a contact using the arguments below.</returns>
        public string EditAdditionalAddressUri(string contactId, string addressId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/address/{addressId}?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Delete the additional address of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#delete-additional-address">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <param name="addressId">ID of the address</param>
        /// <returns>Url to Delete the additional address of a contact.</returns>
        public string DeleteAdditionalAddressUri(string contactId, string addressId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/address/{addressId}?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to List the refund history of a contact.
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#list-refunds">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to List the refund history of a contact.</returns>
        public string ListRefundsUri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/refunds?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to Track a contact for 1099 reporting: (Note: This API is only available when the organization's country is U.S.A).
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#track-1099">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to Track a contact for 1099 reporting: (Note: This API is only available when the organization's country is U.S.A).</returns>
        public string Track1099Uri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/track1099?organization_id={_organizationId}";


        /// <summary>
        /// Gets Url to stop tracking payments to a vendor for 1099 reporting. (Note: This API is only available when the organization's country is U.S.A).
        /// <br /><br />
        /// Zoho Documentation click <see href="https://www.zoho.com/books/api/v3/contacts/#untrack-1099">here</see>.
        /// </summary>
        /// <param name="contactId">ID of the contact</param>
        /// <returns>Url to stop tracking payments to a vendor for 1099 reporting. (Note: This API is only available when the organization's country is U.S.A).</returns>
        public string Untrack1099Uri(string contactId) =>
            $"{ZohoClientsSettings.Default.ZohoBooksApiUriBase}/{_entityName}/{contactId}/untrack1099?organization_id={_organizationId}";
    }
}
