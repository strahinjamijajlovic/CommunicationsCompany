using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual Address Address { get; set; }
        public virtual string TelephoneNumber { get; set; } = string.Empty;
        public virtual InternetService InternetService { get; set; }
        public virtual IList<PhoneNumber> PhoneNumbers { get; set; }
        public virtual IList<ExtraProgram> ExtraPrograms { get; set; }
    }
}
