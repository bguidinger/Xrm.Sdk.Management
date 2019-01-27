namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class BackupInstance : Message
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/InstanceBackups";

        [JsonProperty("InstanceId")]
        public string InstanceId { get; set; }
        [JsonProperty("Label")]
        public string Label { get; set; }
        [JsonProperty("Notes")]
        public string Notes { get; set; }
        [JsonProperty("IsAzureBackup")]
        public bool IsAzureBackup { get; set; }
        [JsonProperty("AzureStorageInformation")]
        public AzureStorage AzureStorageInformation { get; set; }
    }
}