namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetTenantApplicationIdentity : Request
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/TenantApplicationIdentities/{Id}";

        [JsonIgnore]
        public string Id { get; set; }
    }
}