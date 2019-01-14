namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class RestoreInstance : Request
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/Instances/{TargetInstanceId}/Restore";

        [JsonIgnore]
        public string TargetInstanceId { get; set; }

        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId { get; set; }
        [JsonProperty("Label")]
        public string Label { get; set; }
        [JsonProperty("InstanceBackupId")]
        public string InstanceBackupId { get; set; }
        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }
    }
}