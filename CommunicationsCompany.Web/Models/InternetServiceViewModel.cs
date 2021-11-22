using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class InternetServiceViewModel
    {
        public long Id { get; set; }
        public bool Prepaid { get; set; } = false;
        public DateTime? LastPaymentDate { get; set; } = null!;
        public float? AccountBalance { get; set; } = null!;
        public bool FlatRate { get; set; } = false;
        public ICollection<StaticIpViewModel> StaticIPs { get; set; } = Array.Empty<StaticIpViewModel>();
    }
}
