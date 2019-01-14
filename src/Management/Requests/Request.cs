namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public abstract class Request
    {
        [JsonIgnore]
        internal abstract HttpMethod Method { get; }
        [JsonIgnore]
        internal abstract string RequestUri { get; }
    }
}