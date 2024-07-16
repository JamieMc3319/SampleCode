using Bogus;
using System.Net;
using System.Text.Json;
using static ZohoClients.Books.Models.ContactSearchModel;

namespace ZohoClients.Books.UnitTests.Helpers;

internal static class ContactHelpers
{
    internal static BooksModels.ContactCreateOrUpdateModel CreateContactCreateOrUpdateModel()
    {
        var faker = new Faker<BooksModels.ContactCreateOrUpdateModel>(locale: "en");

        return faker
            .RuleForType(typeof(string), u => u.Random.String2(10))
            .RuleForType(typeof(long), u => u.Random.Long())
            .RuleForType(typeof(bool), u => u.Random.Bool())
            .Generate();
    }

    internal static BooksModels.ContactSearchModel CreateContactSearchModel()
    {
        var faker = new Faker<BooksModels.ContactSearchModel>(locale: "en");

        return faker
            .RuleForType(typeof(string), u => u.Random.String2(10))
            .RuleForType(typeof(long), u => u.Random.Long())
            .RuleForType(typeof(bool), u => u.Random.Bool())
            .RuleForType(typeof(FilterByValues), u => u.Random.Enum<FilterByValues>())
            .RuleForType(typeof(SortColumnValues), u => u.Random.Enum<SortColumnValues>())
            .Generate();
    }

    internal static HttpResponseMessage CreateZohoCreateOrUpdateResponse
        (HttpStatusCode httpStatusCode, int zohoStatusCode, BooksModels.ContactCreateOrUpdateModel Contact, string? message = null)
    {
        Messages.ContactResponse zohoResponseContent = new()
        {
            Code = zohoStatusCode,
            Contact = null,
            Message = message
        };

        HttpResponseMessage zohoResponse = new()
        {
            StatusCode = httpStatusCode,
            Content = new StringContent(JsonSerializer.Serialize(zohoResponseContent))
        };

        return zohoResponse;
    }

    internal static HttpResponseMessage CreateZohoListResponse
        (HttpStatusCode httpStatusCode, int zohoStatusCode, string? message = null)
    {
        Messages.ContactsResponse zohoResponseContent = new()
        {
            Code = zohoStatusCode,
            Contacts = null,
            Message = message
        };

        HttpResponseMessage zohoResponse = new()
        {
            StatusCode = httpStatusCode,
            Content = new StringContent(JsonSerializer.Serialize(zohoResponseContent))
        };

        return zohoResponse;
    }
}