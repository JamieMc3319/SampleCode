namespace AzureFunctions;

internal static class Constants
{
    internal static readonly string DefaultEventInstallDate = new DateTime(DateTime.Now.Year, 12, 31).ToString("yyyy-MM-dd");
    internal static readonly string DefaultEventRemovalDate = new DateTime(DateTime.Now.Year + 1, 1, 1).ToString("yyyy-MM-dd");
}
