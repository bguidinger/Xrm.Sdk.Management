namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetInstanceBackups : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/InstanceBackups?instanceId={InstanceId}";

        [JsonIgnore]
        public string InstanceId { get; set; }
    }
}