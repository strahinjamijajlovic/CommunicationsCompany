using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual CommNode CommNode { get; set; }
    }
}
