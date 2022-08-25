using System;

namespace WalkerAdvertising.Models
{
    public class Lead
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string ZipCode { get; set; }

        public string ProviderId { get; set; }

        public bool AllowCommunicateEmail { get; set; }

        public bool AllowCommunicateText { get; set; }

    }
}
