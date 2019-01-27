namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class ApplyUser : Message
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/Instances/{InstanceId}/Users/{UserId}/ApplyUser";

        [JsonIgnore]
        public string InstanceId { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}