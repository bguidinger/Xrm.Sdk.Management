namespace BGuidinger.Xrm.Sdk.Management
{
    using System;

    public class OperationException : Exception
    {
        public OperationStatus Status { get; }

        public OperationException(OperationStatus status)
        {
            Status = status;
        }
    }
}