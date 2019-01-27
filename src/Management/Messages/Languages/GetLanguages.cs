namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetLanguages : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/Languages?releaseId={VersionId}";

        [JsonIgnore]
        public string VersionId { get; set; }
    }
}