namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class CreateTenantApplicationIdentity : Request
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/TenantApplicationIdentities/";

        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("TenantId")]
        public string TenantId { get; set; }
        [JsonProperty("AadApplicationId")]
        public string AadApplicationId { get; set; }
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn { get; set; }
    }
}