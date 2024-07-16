using System;

namespace ZohoClients.Core.Helpers
{
    public static class Validators
    {
        public static void EnsureOrganizationIdValid(string organizationId, bool allowEmpty)
        {
            if (string.IsNullOrWhiteSpace(organizationId) && !allowEmpty)
            {
                throw new ArgumentNullException(nameof(organizationId));
            }

            if (organizationId.Length != 9)
            {
                throw new ArgumentException(nameof(organizationId));
            }
        }
    }
}
