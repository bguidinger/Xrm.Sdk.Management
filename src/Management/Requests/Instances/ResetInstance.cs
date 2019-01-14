namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;

    public class ResetInstance : Request
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/Instances/{InstanceId}/Reset";

        [JsonIgnore]
        public string InstanceId { get; set; }

        [JsonProperty("DomainName")]
        public string DomainName { get; set; }
        [JsonProperty("FriendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty("PreferredCulture")]
        public int PreferredCulture { get; set; }
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId { get; set; }
        [JsonProperty("TargetRelease")]
        public string TargetRelease { get; set; }
        [JsonProperty("BaseLanguageCode")]
        public int BaseLanguageCode { get; set; }
        [JsonProperty("Currency")]
        public Currency Currency { get; set; }
        [JsonProperty("ApplicationNames")]
        public string[] ApplicationNames { get; set; }
        [JsonProperty("AdditionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; set; }
    }
}