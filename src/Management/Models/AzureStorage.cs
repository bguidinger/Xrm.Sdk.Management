namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class AzureStorage
    {
        [JsonProperty("StorageAccountName")]
        public string StorageAccountName { get; set; }
        [JsonProperty("StorageAccountKey")]
        public string StorageAccountKey { get; set; }
        [JsonProperty("ContainerName")]
        public string ContainerName { get; set; }
    }
}