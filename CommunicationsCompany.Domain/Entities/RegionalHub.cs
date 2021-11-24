using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class RegionalHub
    {
        public virtual long Id { get; set; }
        public virtual string RegionName { get; set; }
        public virtual long DeviceId { get; set; }
        public virtual Device Device { get; set; }
        public virtual ISet<MainHub> MainHubs { get; set; } = new HashSet<MainHub>();
    }
}
