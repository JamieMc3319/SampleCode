using System.Text;
using AzureFunctions.Enums;

namespace AzureFunctions.Helpers;

internal static class CreateCalendarEventFromSalesOrderHelpers
{
    internal static CalendarModels.Event CreateInstallEventFromSalesOrder(BooksModels.SalesOrder salesOrder, IEnumerable<BooksModels.ContactPerson> salesOrderContactPersons)
    {
        var eventType = salesOrder.InstallDate()! == string.Empty ? EventType.InstallationDraft : EventType.InstallationConfirmed;
        var calEvent = CreateBasicEventFromSalesOrder(salesOrder, eventType, salesOrderContactPersons);

        return calEvent;
    }

    internal static CalendarModels.Event CreateRemovalEventFromSalesOrder(BooksModels.SalesOrder salesOrder, IEnumerable<BooksModels.ContactPerson> salesOrderContactPersons)
    {
        var eventType = salesOrder.RemovalDate()! == string.Empty ? EventType.RemovalDraft : EventType.RemovalConfirmed;
        var calEvent = CreateBasicEventFromSalesOrder(salesOrder, eventType, salesOrderContactPersons);

        return calEvent;
    }

    private static CalendarModels.Event CreateBasicEventFromSalesOrder(BooksModels.SalesOrder salesOrder, EventType eventType, IEnumerable<BooksModels.ContactPerson> salesOrderContactPersons)
    {
        CalendarModels.Event basicEvent = new()
        {
            Title = GetEventTitleFromSalesOrder(salesOrder, eventType),
            Dateandtime = new()
            {
                Start = GetEventDateFromSalesOrder(salesOrder, eventType),
                End = GetEventDateFromSalesOrder(salesOrder, eventType),
                Timezone = "Europe/Dublin"
            },
            Organizer = "office@ccc.ie",
            Location = salesOrder.ShippingAddress.AddressFlattened(),
            Description = GetEventDescriptionFromSalesOrder(salesOrder),
            CreatedBy = "office@ccc.ie",
            IsAllDay = true,
            IsRep = false,
            Attendees = salesOrderContactPersons.Select(d => new CalendarModels.Attendee
            {
                Email = d.Email,
                ContactPersonId = d.ContactPersonId,
                Permission = CalendarEnums.AttendeePermissions.Invite,
                Attendence = CalendarEnums.AttendeeAttendances.OptionalParticipant
            }),
            SendNotification = false,  // TODO: An email will be sent where appropriate (i.e. date confirmed)
        };

        return basicEvent;
    }

    private static string GetEventTitleFromSalesOrder(BooksModels.SalesOrder salesOrder, EventType eventType)
    {
        return eventType switch
        {
            EventType.InstallationDraft => $"(Draft) {salesOrder.CustomerName} Install ({salesOrder.ShippingAddress.EventTitleAreaName()})",
            EventType.InstallationConfirmed => $"{salesOrder.CustomerName} Install ({salesOrder.ShippingAddress.EventTitleAreaName()})",
            EventType.RemovalDraft => $"(Draft) {salesOrder.CustomerName} Removal ({salesOrder.ShippingAddress.EventTitleAreaName()})",
            EventType.RemovalConfirmed => $"{salesOrder.CustomerName} Removal ({salesOrder.ShippingAddress.EventTitleAreaName()})",
            _ => throw new NotImplementedException(),
        };
    }

    private static string GetEventDateFromSalesOrder(BooksModels.SalesOrder salesOrder, EventType eventType)
    {
        return eventType switch
        {
            EventType.InstallationDraft => Constants.DefaultEventInstallDate,
            EventType.InstallationConfirmed => salesOrder.InstallDate()!,
            EventType.RemovalDraft => Constants.DefaultEventRemovalDate,
            EventType.RemovalConfirmed => salesOrder.RemovalDate()!,
            _ => throw new NotImplementedException(),
        };
    }

    private static string GetEventDescriptionFromSalesOrder(BooksModels.SalesOrder salesOrder)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Sales Order No. {salesOrder.SalesorderNumber}");
        sb.AppendLine();

        foreach (var lineItem in salesOrder.LineItems.Select((item, index) => new { item, index }))
        {
            sb.AppendLine($"Item {lineItem.index + 1}");
            sb.AppendLine("======");
            sb.AppendLine();
            sb.AppendLine("Name: " + lineItem.item.Name);
            sb.AppendLine("Qty: " + lineItem.item.Quantity);
            sb.AppendLine();
            sb.AppendLine(lineItem.item.Description);
            sb.AppendLine();
            sb.AppendLine();
        }

        return sb.ToString();
    }
}
