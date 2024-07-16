using ZohoClients.Books.Models;

namespace AzureFunctions.ModelExtensions;

internal static class SalesOrderExtensions
{
    internal static bool IsInstallRequired(this SalesOrder s) => s.CustomFields.First(cf => cf.CustomfieldId == "cf_isinstallrequired").Value == "Yes";

    internal static string InstallDate(this SalesOrder s) => s.CustomFields.First(cf => cf.CustomfieldId == "cf_installdate").Value;

    internal static bool IsRemovalRequired(this SalesOrder s) => s.CustomFields.First(cf => cf.CustomfieldId == "cf_isremovalrequired").Value == "Yes";

    internal static string RemovalDate(this SalesOrder s) => s.CustomFields.First(cf => cf.CustomfieldId == "cf_removaldate").Value;
}
