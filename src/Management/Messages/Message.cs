namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public abstract class Message
    {
        [JsonIgnore]
        internal abstract HttpMethod Method { get; }
        [JsonIgnore]
        internal abstract string RequestUri { get; }

        public virtual Validation Validation => new Validation();
    }
}