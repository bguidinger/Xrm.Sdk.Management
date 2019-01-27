namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Collections.Generic;
    using System.Linq;

    public class Validation
    {
        public ICollection<string> Messages = new List<string>();

        public bool IsValid => Messages == null || Messages.Count() == 0;
    }
}