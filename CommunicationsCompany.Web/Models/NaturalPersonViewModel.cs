using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class NaturalPersonViewModel
    {
        public long Id { get; set; }
        public virtual string JMBG { get; set; } = string.Empty;
        public virtual string ContactNumber { get; set; } = string.Empty;
        public virtual UserViewModel User { get; set; }
        public virtual AddressViewModel Address { get; set; }
        public virtual ServicesViewModel Services { get; set; }
    }
}
