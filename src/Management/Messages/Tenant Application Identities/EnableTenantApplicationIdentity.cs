namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class EnableTenantApplicationIdentity : Message
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/TenantApplicationIdentities/{Id}/Enable";

        [JsonIgnore]
        public string Id { get; set; }
    }
}