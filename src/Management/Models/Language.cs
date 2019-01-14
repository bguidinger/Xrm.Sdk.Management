namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class Language
    {
        [JsonProperty("Lcid")]
        public int Lcid { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("LocalizedName")]
        public string LocalizedName { get; set; }
    }
}