namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class EnvironmentMetadata
    {
        [JsonProperty("Geo")]
        public string Geo { get; set; }
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}