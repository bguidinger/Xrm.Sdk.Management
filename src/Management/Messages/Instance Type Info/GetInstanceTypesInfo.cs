﻿namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Net.Http;

    public class GetInstanceTypesInfo : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/InstanceTypeInfo";
    }
}