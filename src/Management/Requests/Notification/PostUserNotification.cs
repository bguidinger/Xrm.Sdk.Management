namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class PostUserNotification : Request
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/Notifications/";

        [JsonProperty("NotificationId")]
        public string NotificationId { get; set; }
        [JsonProperty("TenantId")]
        public string TenantId { get; set; }
        [JsonProperty("OrgId")]
        public string OrgId { get; set; }
        [JsonProperty("AdminId")]
        public string AdminId { get; set; }
        [JsonProperty("Content")]
        public NotificationContent Content { get; set; }
        [JsonProperty("State")]
        public NotificationState State { get; set; }
        [JsonProperty("Priority")]
        public NotificationPriority Priority { get; set; }
        [JsonProperty("Environments")]
        public EnvironmentMetadata[] Environments { get; set; }
        [JsonProperty("CreatedAt")]
        public string CreatedAt { get; set; }
    }
}