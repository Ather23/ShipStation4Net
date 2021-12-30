using Newtonsoft.Json;

namespace ShipStation4Net.Domain.Entities
{
    public class BulkOrderResult
    {
        [JsonProperty("orderId")]
        public int? OrderId { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("orderKey")]
        public string OrderKey { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
