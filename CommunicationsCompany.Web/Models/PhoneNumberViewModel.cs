using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class PhoneNumberViewModel
    {
        public virtual long Id { get; set; }
        public virtual string Number { get; set; }
        public virtual int MinutesCount { get; set; }
    }
}
