namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;

    public class ConfigureInstance : Request
    {
        internal override HttpMethod Method => HttpMethod.Post;
        internal override string RequestUri => $"/Instances/{InstanceId}/ConfigureInstance?validate={Validate}";

        [JsonIgnore]
        public string InstanceId { get; set; }
        [JsonIgnore]
        public bool Validate { get; set; } = false;

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }
        [JsonProperty("AdditionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; set; }
    }
}