using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class RegionalHub
    {
        public virtual long Id { get; set; }
        public virtual string RegionName { get; set; }
        public virtual long MainHubId { get; set; }
        public virtual MainHub MainHub { get; set; }
    }
}
