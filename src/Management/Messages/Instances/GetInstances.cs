namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Net.Http;

    public class GetInstances : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/instances";
    }
}