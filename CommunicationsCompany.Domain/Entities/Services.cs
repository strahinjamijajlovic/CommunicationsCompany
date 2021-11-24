using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class Services
    {
        public virtual long Id { get; set; }
        public virtual long ServicesId { get; set; }
        public virtual InternetService InternetService { get; set; }
        public virtual ISet<PhoneNumber> PhoneNumbers { get; set; } = new HashSet<PhoneNumber>();
        public virtual ISet<ExtraProgram> ExtraTvPrograms { get; set; } = new HashSet<ExtraProgram>();
    }
}
