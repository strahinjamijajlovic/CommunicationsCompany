using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class DeviceViewModel
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public string ManufacturerName { get; set; } = string.Empty;
        public DateTime InstallationDate { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public string LastServiceReason { get; set; } = string.Empty;
    }
}
