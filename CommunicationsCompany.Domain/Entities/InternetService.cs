using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class InternetService
    {
        public virtual long Id { get; set; }
        public virtual bool Prepaid { get; set; }
        public virtual DateTime? LastPaymentDate { get; set; }
        public virtual float? AccountBalance { get; set; }
        public virtual bool FlatRate { get; set; }
        public virtual ISet<StaticIp> StaticIPs { get; set; } = new HashSet<StaticIp>();
    }
}
