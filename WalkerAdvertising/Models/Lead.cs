using System;
using System.ComponentModel.DataAnnotations;

namespace WalkerAdvertising.Models
{
    public class Lead
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string ProviderId { get; set; }

        public bool AllowCommunicateEmail { get; set; }

        public bool AllowCommunicateText { get; set; }

    }
}
