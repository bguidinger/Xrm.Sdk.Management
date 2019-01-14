﻿namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Net.Http;

    public class GetInstances : Request
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/instances";
    }
}