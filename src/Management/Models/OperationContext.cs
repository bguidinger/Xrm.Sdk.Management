namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class OperationContext
    {
        [JsonProperty("Items")]
        public Dictionary<string, string> Items { get; set; }
    }
}