namespace AzureFunctions.ModelExtensions;

internal static class Address
{
    internal static string AddressFlattened(this BooksModels.Address a) =>
        $"{a.Street1}, {a.Street2}, {a.City}, Co. {a.State}, {a.Zip}".ReplaceLineEndings(", ");

    internal static string EventTitleAreaName(this BooksModels.Address a)
    {
        if (string.Equals(a.State, "Dublin", StringComparison.InvariantCultureIgnoreCase) && 
            a.Zip.StartsWith('D'))
        {
            return a.Zip;
        }
        else 
        { 
            return a.City + ", Co. "+ a.State; 
        }
    }
}
