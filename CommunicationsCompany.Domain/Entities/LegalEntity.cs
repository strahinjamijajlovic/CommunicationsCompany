using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class LegalEntity
    {
        public virtual long Id { get; set; }
        public virtual string FaxNumber { get; set; }
        public virtual string PIB { get; set; }
        public virtual long ContactPersonId { get; set; }
        public virtual User ContactPerson { get; set; }
        public virtual long ServicesId { get; set; }
        public virtual Services Services { get; set; }
    }
}
