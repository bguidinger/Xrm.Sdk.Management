namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class SupportedRelease
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Types")]
        public string[] Types { get; set; }
    }
}