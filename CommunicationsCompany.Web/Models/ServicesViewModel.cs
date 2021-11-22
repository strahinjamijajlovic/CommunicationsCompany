using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class ServicesViewModel
    {
        public long Id {get; set; }
        public virtual InternetServiceViewModel InternetService { get; set; }
        public virtual ICollection<PhoneNumberViewModel> PhoneNumbers { get; set; } = Array.Empty<PhoneNumberViewModel>();
        public virtual ICollection<ExtraProgramViewModel> ExtraTvPrograms { get; set; } = Array.Empty<ExtraProgramViewModel>();
    }
}
