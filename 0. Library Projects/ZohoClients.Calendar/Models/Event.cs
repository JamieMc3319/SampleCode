using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZohoClients.Calendar.Models
{
    public class Event
    {
        /// <summary>
        /// Title of the event to be added.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Send JSON Object of the start time, end time in Unix time format along with the time zone information, in case, different from the current user time zone.
        /// <code>
        /// dateandtime:
        /// {
        ///     timezone: Asia/Calcutta",
        ///     start: 20170719T153000+0530,
        ///     end : 20170719T163000+0530
        /// }
        /// </code>
        /// </summary>
        [JsonPropertyName("dateandtime")]
        public DateAndTime Dateandtime { get; set; }

        /// <summary>
        /// Hex-color for the event. In case, a specific color needs to be provided for the event, different from the default color.
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// Details of the event organizer. In case, it is different from the current user.
        /// </summary>    
        [JsonPropertyName("organizer")]
        public string Organizer { get; set; }

        /// <summary>
        /// Whether the event is a repeating event (True) or a one-time event (False).
        /// </summary>
        [JsonPropertyName("isrep")]
        public bool? IsRep { get; set; }

        /// <summary>
        /// Whether the event is an all-day event (True) or not(False).
        /// </summary>
        [JsonPropertyName("isallday")]
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// Whether the event is a private event (True) or not (False). If set as private, the event details will not be shared even when the calendar is made public or shared with others with view permission.
        /// </summary>
        [JsonPropertyName("isprivate")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// URL details that need to be shared for the event, along with the description, if any.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rrule")]
        public string Rrule { get; set; }

        /// <summary>
        /// Email addresses of the attendees to whom the event invitation should be sent in JSON Object format.
        /// </summary>
        [JsonPropertyName("attendees")]
        public IEnumerable<Attendee> Attendees { get; set; }

        /// <summary>
        /// Group attendees' addresses to whom the event invitation should be sent as JSON Object format.
        /// </summary>
        [JsonPropertyName("group_attendees")]
        public object GroupAttendees { get; set; }

        [JsonPropertyName("createdby")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("recurrenceid")]
        public string RecurrenceId { get; set; }

        [JsonPropertyName("sendnotification")]
        public bool? SendNotification { get; set; }

        [JsonPropertyName("reminders")]
        public List<object> Reminders { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Details of the time zone in which the event details should be displayed if it is a global event.
        /// </summary>
        [JsonPropertyName("display_in_timezone")]
        public string DisplayInTimezone { get; set; }

        [JsonPropertyName("calendar_alarm")]
        public bool? CalendarAlarm { get; set; }

        [JsonPropertyName("enable_eventmanagement")]
        public bool? EnableEventmanagement { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("group_list")]
        public List<object> GroupList { get; set; }

        [JsonPropertyName("entityid")]
        public string EntityId { get; set; }


        // Additional

        [JsonPropertyName("etype")]
        public object Etype { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("calid")]
        public string Calid { get; set; }

        [JsonPropertyName("has_attachment")]
        public bool? HasAttachment { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("lastmodifiedtime")]
        public string Lastmodifiedtime { get; set; }

        [JsonPropertyName("createdtime")]
        public string Createdtime { get; set; }

        [JsonPropertyName("attRSVPNotifyType")]
        public int? AttRSVPNotifyType { get; set; }

        [JsonPropertyName("estatus")]
        public string Estatus { get; set; }

        [JsonPropertyName("transparency")]
        public int? Transparency { get; set; }

        [JsonPropertyName("modifiedby")]
        public string Modifiedby { get; set; }

        [JsonPropertyName("caluid")]
        public string Caluid { get; set; }

        [JsonPropertyName("multiday")]
        public bool? Multiday { get; set; }
    }
}