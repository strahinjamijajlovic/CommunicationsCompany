using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class ExtraProgram
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual long ServiceId { get; set; }
        public virtual Services Service { get; set; }
    }
}
