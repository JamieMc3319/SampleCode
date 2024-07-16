using System.Text.Json.Serialization;

namespace ZohoClients.Calendar.Models
{
    public class Attendee
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("zid")]
        public string ContactPersonId { get; set; }

        [JsonPropertyName("permission")]
        public Enums.AttendeePermissions Permission { get; set; }

        [JsonPropertyName("attendence")]
        public Enums.AttendeeAttendances Attendence { get; set; }
    }
}
