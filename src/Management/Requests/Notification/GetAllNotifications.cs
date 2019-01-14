namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System.Net.Http;

    public class GetAllNotifications : Request
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/Notifications/{TenantId}/{AdminId}?environments={string.Join(",", Environments)}";

        [JsonIgnore]
        public string TenantId { get; set; }
        [JsonIgnore]
        public string AdminId { get; set; }
        [JsonIgnore]
        public string[] Environments { get; set; }
    }
}