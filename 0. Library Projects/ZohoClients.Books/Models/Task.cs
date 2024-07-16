using System.Text.Json.Serialization;

namespace ZohoClients.Books.Models
{
    public class Task
    {
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }

        [JsonPropertyName("currency_id")]
        public long CurrencyId { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }

        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }

        [JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

        [JsonPropertyName("billed_hours")]
        public string BilledHours { get; set; }

        [JsonPropertyName("log_time")]
        public string LogTime { get; set; }

        [JsonPropertyName("un_billed_hours")]
        public string UnBilledHours { get; set; }
    }
}
