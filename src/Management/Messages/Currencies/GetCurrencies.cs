﻿namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Net.Http;

    public class GetCurrencies : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/Currencies";
    }
}