//using Moq;
//using Moq.Protected;
//using System.Linq.Expressions;
//using System.Net;

//namespace ZohoClients.Books.UnitTests.Tests;

//public class ContactPersonsClient
//{
//    [Fact]
//    public void Initialize_Valid()
//    {
//        // Assign + Act
//        BooksClients.Con client = new("123456789", null);

//        // Assert
//        Assert.IsType<BooksClients.ContactPersonsClient>(client);
//    }


//    [InlineData("", typeof(ArgumentNullException))]
//    [InlineData("123", typeof(ArgumentException))]
//    [Theory]
//    public void Initialize_Invalid(string orgId, Type exceptionType)
//    {
//        // Act + Assert
//        _ = Assert.Throws(exceptionType!, () =>
//        {
//            BooksClients.ContactPersonsClient client = new(orgId, null);
//        });
//    }

//    [Fact]
//    public async void Create()
//    {
//        // Assign
//        var contactPerson = ContactPersonHelpers.CreateContactPerson();
//        var zohoResponse = ContactPersonHelpers.CreateZohoCreateOrUpdateResponse(HttpStatusCode.OK, 0, contactPerson);
//        var httpClient = GetMockHttpClient(ItExpr.IsAny<HttpRequestMessage>(), zohoResponse);

//        BooksClients.ContactPersonsClient client = new(Constants.OrganizationId, httpClient);

//        // Act
//        var response = await client.CreateAsync(contactPerson);

//        // Assert
//        Assert.NotNull(response);
//        Assert.Equal(0, response.Code);
//    }

//    private static HttpClient GetMockHttpClient(Expression zohoRequestExpression, HttpResponseMessage zohoResponse)
//    {
//        var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
//        mockHttpMessageHandler.Protected()
//            .Setup<Task<HttpResponseMessage>>("SendAsync", zohoRequestExpression, ItExpr.IsAny<CancellationToken>())
//            .ReturnsAsync(zohoResponse);

//        HttpClient httpClient = new(mockHttpMessageHandler.Object);
//        return httpClient;
//    }
//}