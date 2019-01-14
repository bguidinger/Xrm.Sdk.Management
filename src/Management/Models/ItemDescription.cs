namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class ItemDescription
    {
        [JsonProperty("Subject")]
        public string Subject { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}