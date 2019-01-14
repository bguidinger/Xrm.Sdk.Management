namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Net.Http;

    public class GetTemplates : Request
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/Templates";
    }
}