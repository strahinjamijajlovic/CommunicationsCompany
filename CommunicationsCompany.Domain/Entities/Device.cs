using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class Device
    {
        public virtual long Id { get; set; }
        public virtual string SerialNumber { get; set; } = string.Empty;
        public virtual string ManufacturerName { get; set; } = string.Empty;
        public virtual DateTime InstallationDate { get; set; }
        public virtual DateTime? LastServiceDate { get; set; }
        public virtual string LastServiceReason { get; set; } = string.Empty;
    }
}
