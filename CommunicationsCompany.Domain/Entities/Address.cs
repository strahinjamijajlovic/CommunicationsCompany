using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class Address
    {
        public virtual long Id { get; set; }
        public virtual string Street { get; set; } = string.Empty;
        public virtual int ApartmentNumber { get; set; }
        public virtual string  City { get; set; }
    }
}
