namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Region
    {
        [JsonProperty("RegionCode")]
        public string RegionCode { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Currencies")]
        public IEnumerable<Currency> Currencies { get; set; }
    }
}