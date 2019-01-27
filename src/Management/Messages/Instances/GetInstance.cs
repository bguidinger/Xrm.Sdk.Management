namespace BGuidinger.Xrm.Sdk.Management
{
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;

    public class GetInstance : Message
    {
        internal override HttpMethod Method => HttpMethod.Get;
        internal override string RequestUri => $"/Instances/{Id}";

        [JsonIgnore]
        public string Id { get; set; }

        public override Validation Validation
        {
            get
            {
                var validation = base.Validation;

                if (Id == Guid.Empty.ToString("D"))
                {
                    validation.Messages.Add("Id cannot be an empty GUID.");
                }

                return validation;
            }
            
        }
    }
}