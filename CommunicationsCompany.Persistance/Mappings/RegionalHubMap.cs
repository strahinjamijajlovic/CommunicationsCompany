using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class RegionalHubMap : ClassMap<RegionalHub>
    {
        public RegionalHubMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.RegionName).Not.Nullable().Length(50);

            References(x => x.Device, "DeviceId");

            HasMany(x => x.MainHubs).KeyColumn("RegionalHubId").Inverse().Cascade.SaveUpdate();

            Table("RegionalHubs");
        }
    }
}
