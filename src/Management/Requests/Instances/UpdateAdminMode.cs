namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class UpdateAdminMode : Request
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/Instances/{InstanceId}/UpdateAdminMode?validate={Validate.ToString().ToLower()}";

        [JsonIgnore]
        public string InstanceId { get; set; }
        [JsonIgnore]
        public bool Validate { get; set; } = false;

        [JsonProperty("AdminMode")]
        public bool AdminMode { get; set; }
        [JsonProperty("BackgroundOperationsEnabled")]
        public bool BackgroundOperationsEnabled { get; set; }
        [JsonProperty("NotificationText")]
        public string NotificationText { get; set; }
        [JsonProperty("OverrideUserObjectId")]
        public string OverrideUserObjectId { get; set; }
    }
}