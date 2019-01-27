namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class DeleteTenantApplicationIdentity : Message
    {
        internal override HttpMethod Method => HttpMethod.Delete;
        internal override string RequestUri => $"/TenantApplicationIdentities/{Id}";

        [JsonIgnore]
        public string Id { get; set; }
    }
}