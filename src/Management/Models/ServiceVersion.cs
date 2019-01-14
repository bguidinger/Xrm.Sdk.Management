namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class ServiceVersion
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("LCID")]
        public int Lcid { get; set; }
        [JsonProperty("LocalizedName")]
        public string LocalizedName { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Version")]
        public string Version { get; set; }
    }
}