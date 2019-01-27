namespace BGuidinger.Xrm.Sdk.Management
{
    using System;

    public class ValidationException : Exception
    {
        public Validation Validation { get; }

        public ValidationException(Validation validation) : base("The message is not valid.")
        {
            Validation = validation;
        }
    }
}