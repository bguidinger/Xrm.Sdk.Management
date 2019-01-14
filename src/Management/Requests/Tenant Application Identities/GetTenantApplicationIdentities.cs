namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Net.Http;

    public class GetTenantApplicationIdentities : Request
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/TenantApplicationIdentities";
    }
}