using Bogus;
using System.Net;
using System.Text.Json;

namespace ZohoClients.Books.UnitTests.Helpers;

internal static class ContactPersonHelpers
{
    internal static BooksModels.ContactPerson CreateContactPerson()
    {
        var faker = new Faker<BooksModels.ContactPerson>(locale: "en");

        return faker
            .RuleForType(typeof(string), u => u.Random.String2(10))
            .RuleForType(typeof(long), u => u.Random.Long())
            .RuleFor(u => u.IsPrimaryContact, true)
            .RuleForType(typeof(bool), u => u.Random.Bool())
            .Generate();
    }

    internal static HttpResponseMessage CreateZohoResponse
        (HttpStatusCode httpStatusCode, int zohoStatusCode, BooksModels.ContactPerson contactPerson, string? message = null)
    {
        Messages.ContactPersonResponse zohoResponseContent = new()
        {
            Code = zohoStatusCode,
            ContactPerson = contactPerson,
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