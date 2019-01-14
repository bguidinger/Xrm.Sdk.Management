namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class NewInstance
    {
        [JsonProperty("Type")]
        public InstanceType Type { get; set; }
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }
        [JsonProperty("DomainName")]
        public string DomainName { get; set; }
        [JsonProperty("FriendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty("BaseLanguage")]
        public int BaseLanguage { get; set; }
        [JsonProperty("Currency")]
        public Currency Currency { get; set; }
        [JsonProperty("Templates")]
        public string[] Templates { get; set; }
        [JsonProperty("ServiceVersionId")]
        public string ServiceVersionId { get; set; }
        [JsonProperty("InitialUserEmail")]
        public string InitialUserEmail { get; set; }
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId { get; set; }
        [JsonProperty("AdditionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; set; }
    }
}