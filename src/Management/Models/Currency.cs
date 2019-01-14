namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;

    public class Currency
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Symbol")]
        public string Symbol { get; set; }
        [JsonProperty("Precision")]
        public int Precision { get; set; }
    }
}