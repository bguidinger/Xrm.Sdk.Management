namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class InstanceRestorePoint
    {
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId { get; set; }
        [JsonProperty("InstanceBackupId")]
        public string InstanceBackupId { get; set; }
        [JsonProperty("Label")]
        public string Label { get; set; }
        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }
    }
}