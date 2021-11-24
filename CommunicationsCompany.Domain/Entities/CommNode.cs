using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class CommNode
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual long DeviceId { get; set; }
        public virtual Device Device { get; set; }
        public virtual long AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ISet<User> Users { get; set; } = new HashSet<User>();
        public virtual long MainHubId { get; set; }
        public virtual MainHub MainHub { get; set; }
    }
}
