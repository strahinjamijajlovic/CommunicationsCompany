using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class NaturalPerson 
    {
        public virtual long Id { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string ContactNumber { get; set; } = string.Empty;
        public virtual User User { get; set; }
        public virtual Address Address { get; set; }
        public virtual Services Services { get; set; }
    }
}
