using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class Services
    {
        public virtual long Id { get; set; }
        public virtual InternetService InternetService { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<ExtraProgram> ExtraTvPrograms { get; set; }
    }
}
