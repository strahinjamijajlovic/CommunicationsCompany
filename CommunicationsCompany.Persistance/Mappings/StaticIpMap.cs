using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class StaticIpMap : ClassMap<StaticIp>
    {
        public StaticIpMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.IpAddress).Not.Nullable().Length(20);

            Table("StaticIps");
        }
    }
}
