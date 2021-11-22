using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class LegalEntityViewModel
    {
        public long Id { get; set; }
        public string FaxNumber { get; set; } = string.Empty;
        public string PIB { get; set; } = string.Empty;
        public UserViewModel ContactPerson { get; set; }
        public ServicesViewModel Services { get; set; }
    }
}
