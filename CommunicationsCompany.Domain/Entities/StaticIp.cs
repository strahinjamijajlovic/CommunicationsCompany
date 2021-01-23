using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Domain.Entities
{
    public class StaticIp
    {
        public virtual long Id { get; set; }
        public virtual string IpAddress { get; set; }
        public virtual InternetService InternetService { get; set; }
    }
}
