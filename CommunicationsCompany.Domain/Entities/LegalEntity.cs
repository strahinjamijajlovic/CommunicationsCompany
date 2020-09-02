using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class LegalEntity : User
    {
        public virtual long Id { get; set; }
        public virtual string ContactPersonFirstName { get; set; }
        public virtual string ContactPersonLastName { get; set; }
        public virtual string FaxNumber { get; set; }
        public virtual string PIB { get; set; }
    }
}
