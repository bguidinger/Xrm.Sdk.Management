namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class NotificationContent
    {
        [JsonProperty("TemplateId")]
        public string TemplateId { get; set; }
        [JsonProperty("TemplateType")]
        public string TemplateType { get; set; }
        [JsonProperty("Slugs")]
        public string Slugs { get; set; }
    }
}