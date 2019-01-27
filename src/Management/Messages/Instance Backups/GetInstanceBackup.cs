namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetInstanceBackup : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/InstanceBackups/{InstanceId}/{BackupId}";

        [JsonIgnore]
        public string InstanceId { get; set; }
        [JsonIgnore]
        public string BackupId { get; set; }
    }
}