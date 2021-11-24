﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class NaturalPerson 
    {
        public virtual long Id { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string ContactNumber { get; set; } = string.Empty;
        public virtual long UserId { get; set; }
        public virtual User User { get; set; }
        public virtual long AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual long ServicesId { get; set; }
        public virtual Services Services { get; set; }
    }
}
