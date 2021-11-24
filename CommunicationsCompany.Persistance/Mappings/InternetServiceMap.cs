using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class InternetServiceMap : ClassMap<InternetService>
    {
        public InternetServiceMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Prepaid).Not.Nullable();
            Map(x => x.LastPaymentDate).Nullable();
            Map(x => x.AccountBalance).Nullable();
            Map(x => x.FlatRate).Not.Nullable();

            HasMany(x => x.StaticIPs).KeyColumn("InternetServiceId").Cascade.AllDeleteOrphan();

            Table("InternetServices");
        }
    }
}
