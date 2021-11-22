using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class AddressViewModel
    {
        public  long Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public int ApartmentNumber { get; set; }
        public string City { get; set; } = string.Empty;
    }
}
