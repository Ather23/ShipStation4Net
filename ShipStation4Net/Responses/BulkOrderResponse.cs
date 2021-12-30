using Newtonsoft.Json;
using ShipStation4Net.Domain.Entities;
using System.Collections.Generic;

namespace ShipStation4Net.Responses
{
    public class BulkOrderResponse
    {
        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }

        [JsonProperty("results")]
        public List<BulkOrderResult> Results { get; set; }
    }
}
