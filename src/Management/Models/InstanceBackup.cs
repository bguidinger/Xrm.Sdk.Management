namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class InstanceBackup
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Label")]
        public string Label { get; set; }
        [JsonProperty("Notes")]
        public string Notes { get; set; }
        [JsonProperty("Status")]
        public string Status { get; set; }
        [JsonProperty("Version")]
        public string Version { get; set; }
        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }
        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }
        [JsonProperty("ExpiresOn")]
        public string ExpiresOn { get; set; }
        [JsonProperty("IsAzureBackup")]
        public bool IsAzureBackup { get; set; }
        [JsonProperty("AzureStorageInformation")]
        public AzureStorage AzureStorageInformation { get; set; }
    }
}