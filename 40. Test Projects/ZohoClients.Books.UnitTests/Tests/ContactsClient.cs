using Moq;
using Moq.Protected;
using System.Linq.Expressions;
using System.Net;

namespace ZohoClients.Books.UnitTests.Tests;

public class ContactsClient
{
    [Fact]
    public void Initialize_Valid()
    {
        // Assign + Act
        BooksClients.ContactsClient client = new("123456789", null);

        // Assert
        Assert.IsType<BooksClients.ContactsClient>(client);
    }


    [InlineData("", typeof(ArgumentNullException))]
    [InlineData("123", typeof(ArgumentException))]
    [Theory]
    public void Initialize_Invalid(string orgId, Type exceptionType)
    {
        // Act + Assert
        _ = Assert.Throws(exceptionType!, () =>
        {
            BooksClients.ContactsClient client = new(orgId, null);
        });
    }

    [Fact]
    public async Task Create()
    {
        // Assign
        var model = Helpers.ContactHelpers.CreateContactCreateOrUpdateModel();
        var zohoResponse = Helpers.ContactHelpers.CreateZohoCreateOrUpdateResponse(HttpStatusCode.OK, 0, model);
        var httpClient = GetMockHttpClient(ItExpr.IsAny<HttpRequestMessage>(), zohoResponse);

        BooksClients.ContactsClient client = new(Constants.OrganizationId, httpClient);

        // Act
        var response = await client.CreateAsync(model);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(0, response.Code);
    }

    [Fact]
    public async Task ListContacts()
    {
        // Assign
        var model = Helpers.ContactHelpers.CreateContactSearchModel();
        var zohoResponse = Helpers.ContactHelpers.CreateZohoListResponse(HttpStatusCode.OK, 0);
        var httpClient = GetMockHttpClient(ItExpr.IsAny<HttpRequestMessage>(), zohoResponse);

        BooksClients.ContactsClient client = new(Constants.OrganizationId, httpClient);

        // Act
        var response = await client.GetListAsync(model);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(0, response.Code);
    }

    private static HttpClient GetMockHttpClient(Expression zohoRequestExpression, HttpResponseMessage zohoResponse)
    {
        var mockHttpMessageHandler = new Mock<HttpMessageHandler>();

        mockHttpMessageHandler.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", zohoRequestExpression, ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(zohoResponse);

        HttpClient httpClient = new(mockHttpMessageHandler.Object);
        return httpClient;
    }
}