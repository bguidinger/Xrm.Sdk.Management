namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetInstanceTypeInfo : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/InstanceTypeInfo/{Type}";

        [JsonIgnore]
        public InstanceType Type { get; set; }
    }
}