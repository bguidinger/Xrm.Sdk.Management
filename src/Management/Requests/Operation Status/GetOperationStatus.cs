namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetOperationStatus : Request
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/Operation/{Id}";

        [JsonIgnore]
        public string Id { get; set; }
    }
}