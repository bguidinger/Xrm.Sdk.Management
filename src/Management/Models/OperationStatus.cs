namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class OperationStatus
    {
        [JsonProperty("OperationId")]
        public string OperationId { get; set; }
        [JsonProperty("OperationLocation")]
        public string OperationLocation { get; set; }
        [JsonProperty("ResouerceLocation")]
        public string ResouerceLocation { get; set; }
        [JsonProperty("Status")]
        public OperationState Status { get; set; }
        [JsonProperty("Context")]
        public OperationContext Context { get; set; }
        [JsonProperty("Errors")]
        public IEnumerable<ItemDescription> Errors { get; set; }
        [JsonProperty("Information")]
        public IEnumerable<ItemDescription> Information { get; set; }
    }
}