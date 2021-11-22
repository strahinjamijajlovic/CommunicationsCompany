using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class CommNodeViewModel
    {
        public long Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DeviceViewModel Device { get; set; }
        public AddressViewModel Address { get; set; }
        public long MainHubId { get; set; }
    }
}
