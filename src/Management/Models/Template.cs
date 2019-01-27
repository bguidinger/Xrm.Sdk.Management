namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class Template
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("LocalizedName")]
        public string LocalizedName { get; set; }
        [JsonProperty("LocalizedDescription")]
        public string LocalizedDescription { get; set; }
        [JsonProperty("SupportedReleases")]
        public SupportedRelease[] SupportedReleases { get; set; }
    }
}