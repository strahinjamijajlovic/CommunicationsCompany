using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class MainHub
    {
        public virtual long Id { get; set; }
        public virtual Device Device { get; set; }
        public virtual RegionalHub RegionalHub { get; set; }
        public virtual ICollection<CommNode> CommNodes { get; set; }
    }
}
