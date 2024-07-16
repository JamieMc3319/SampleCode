namespace ZohoClients.Books.ModelExtensions
{
    public static class ContactPerson
    {
        public static string FullName(this Models.ContactPerson cp)
            => $"{cp.FirstName} {cp.LastName}";

        public static string EmailAddressWithFullName(this Models.ContactPerson cp)
            => $"{cp.FirstName} {cp.LastName} <{cp.Email}>";
    }
}
