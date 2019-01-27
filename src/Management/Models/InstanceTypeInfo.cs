namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class InstanceTypeInfo
    {
        [JsonProperty("Type")]
        public InstanceType Type { get; set; }
        [JsonProperty("Consumed")]
        public int Consumed { get; set; }
        [JsonProperty("Total")]
        public int Total { get; set; }
    }
}