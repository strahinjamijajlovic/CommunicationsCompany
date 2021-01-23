using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class CommNode
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual Device Device { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual MainHub MainHub { get; set; }
    }
}
