namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class DeleteInstance : Message
    {
        internal override HttpMethod Method => HttpMethod.Delete;
        internal override string RequestUri => $"/Instances/{InstanceId}/Delete?validate={Validate}";

        [JsonIgnore]
        public string InstanceId { get; set; }
        [JsonIgnore]
        public bool Validate { get; set; } = false;
    }
}