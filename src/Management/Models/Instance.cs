namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Instance
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("UniqueName")]
        public string UniqueName { get; set; }
        [JsonProperty("Version")]
        public string Version { get; set; }
        [JsonProperty("ApplicationUrl")]
        public string ApplicationUrl { get; set; }
        [JsonProperty("ApiUrl")]
        public string ApiUrl { get; set; }
        [JsonProperty("DomainName")]
        public string DomainName { get; set; }
        [JsonProperty("FriendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty("Type")]
        public InstanceType Type { get; set; }
        [JsonProperty("State")]
        public InstanceState State { get; set; }
        [JsonProperty("StateIsSupportedForDelete")]
        public bool StateIsSupportedForDelete { get; set; }
        [JsonProperty("InitialUserPrincipalName")]
        public string InitialUserPrincipalName { get; set; }
        [JsonProperty("AdminMode")]
        public bool AdminMode { get; set; }
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }
        [JsonProperty("BaseLanguage")]
        public int BaseLanguage { get; set; }
        [JsonProperty("InitialUserEmail")]
        public string InitialUserEmail { get; set; }
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId { get; set; }
        [JsonProperty("AdditionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; set; }
    }
}