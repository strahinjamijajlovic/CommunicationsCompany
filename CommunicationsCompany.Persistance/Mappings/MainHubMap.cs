using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class MainHubMap : ClassMap<MainHub>
    {
        public MainHubMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();

            References(x => x.Device, "DeviceId");
            References(x => x.RegionalHub, "RegionalHubId");

            HasMany(x => x.CommNodes).KeyColumn("MainHubId").Inverse().Cascade.SaveUpdate();

            Table("MainHubs");
        }
    }
}
