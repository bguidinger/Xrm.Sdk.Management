namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class TenantApplicationIdentity
    {
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