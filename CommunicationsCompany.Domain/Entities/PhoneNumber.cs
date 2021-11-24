using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class PhoneNumber
    {
        public virtual long Id { get; set; }
        public virtual string Number { get; set; }
        public virtual int MinutesCount { get; set; }
        public virtual long ServicesId { get; set; }
        public virtual Services Service { get; set; }
    }
}
