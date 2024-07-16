using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace AzureFunctions.Functions;

public class CreateCalendarEventsFromSalesOrder(IConfiguration configuration, IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory)
{
    private readonly IConfiguration _configuration = configuration;
    private readonly ILogger _logger = loggerFactory.CreateLogger<CreateCalendarEventsFromSalesOrder>();
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient();

    [Function("CreateCalendarEventsFromSalesOrder")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
    {
        _logger.LogInformation("C# HTTP trigger function received a request.");

        IEnumerable<BooksModels.SalesOrder> salesOrders;

        try
        {
            var requestBody = new StreamReader(req.Body).ReadToEndAsync().Result;
            salesOrders = JsonSerializer.Deserialize<IEnumerable<BooksModels.SalesOrder>>(requestBody)!;
        }
        catch (JsonException je)
        {
            _logger.LogError(je, "There was an error.");
            return req.CreateResponse(HttpStatusCode.BadRequest);
        }

        if (!salesOrders.Any())
        {
            _logger.LogError("C# HTTP trigger function returned no content.");
            return req.CreateResponse(HttpStatusCode.UnprocessableContent);
        }

        var salesOrder = salesOrders.First();

        if (!salesOrder.IsInstallRequired() && !salesOrder.IsRemovalRequired())
        {
            _logger.LogInformation("C# HTTP trigger function returned no content.");
            return req.CreateResponse(HttpStatusCode.NoContent);
        }

        try
        {
            var salesOrderContactPersons = GetSalesOrderContactPersonsAsync(salesOrder.CustomerId, salesOrder.ContactPersonIds);
            CalendarMessages.PostEventsMessageBody messageBody = new();

            if (salesOrder.IsInstallRequired())
            {
                var calendarEvent = CreateCalendarEventFromSalesOrderHelpers.CreateInstallEventFromSalesOrder(salesOrder, salesOrderContactPersons);
                messageBody.Events.Add(calendarEvent);
            }

            if (salesOrder.IsRemovalRequired())
            {
                var calendarEvent = CreateCalendarEventFromSalesOrderHelpers.CreateRemovalEventFromSalesOrder(salesOrder, salesOrderContactPersons);
                messageBody.Events.Add(calendarEvent);
            }

            PostEventsAsync(messageBody);

            var response = req.CreateResponse();
            _ = response.WriteAsJsonAsync(messageBody, HttpStatusCode.Accepted);
            
            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "There was an error.");
            
            var response = req.CreateResponse(HttpStatusCode.InternalServerError);
            response.WriteString(ex.ToString());

            return response;
        }
    }

    private IEnumerable<BooksModels.ContactPerson> GetSalesOrderContactPersonsAsync(string contactId, List<string> contactPersonIds)
    {
        // TODO: Replace placeholder.
        return [];
    }

    private Task<HttpResponseMessage> PostEventsAsync(CalendarMessages.PostEventsMessageBody events)
    {
        CalendarClients.EventClient client = new(_httpClient);

        var calendarId = _configuration["CreateCalendarEventsFromSalesOrder:CalendarId"];
        return client.CreateAsync(events, calendarId);
    }
}
