using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class MainHub
    {
        public virtual long Id { get; set; }
        public virtual IList<CommNode> CommNodes { get; set; }
    }
}
