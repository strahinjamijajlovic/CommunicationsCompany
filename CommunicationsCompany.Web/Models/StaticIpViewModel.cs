using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class StaticIpViewModel
    {
        public long Id { get; set; }
        public string IpAddress { get; set; } = string.Empty;
    }
}
