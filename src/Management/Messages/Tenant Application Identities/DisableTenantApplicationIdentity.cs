namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class DisableTenantApplicationIdentity : Message
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/TenantApplicationIdentities/{Id}/Disable";

        [JsonIgnore]
        public string Id { get; set; }
    }
}