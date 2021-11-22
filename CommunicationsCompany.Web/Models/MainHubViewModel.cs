using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class MainHubViewModel
    {
        public long Id { get; set; }
        public DeviceViewModel Device { get; set; }
        public long RegionalHub { get; set; }
    }
}
