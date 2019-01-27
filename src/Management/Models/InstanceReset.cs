namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class InstanceReset
    {
        [JsonProperty("ApplicationNames")]
        public string[] ApplicationNames { get; set; }
        [JsonProperty("BaseLanguageCode")]
        public int BaseLanguageCode { get; set; }
        [JsonProperty("Currency")]
        public Currency Currency { get; set; }
        [JsonProperty("DomainName")]
        public string DomainName { get; set; }
        [JsonProperty("FriendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }
        [JsonProperty("PreferredCulture")]
        public int PreferredCulture { get; set; }
        [JsonProperty("TargetRelease")]
        public string TargetRelease { get; set; }
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId { get; set; }
        [JsonProperty("AdditionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; set; }
    }
}