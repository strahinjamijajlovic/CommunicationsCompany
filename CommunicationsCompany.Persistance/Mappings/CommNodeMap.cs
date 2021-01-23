using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class CommNodeMap : ClassMap<CommNode>
    {
        public CommNodeMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Description).Length(200);
            References(x => x.Device, "DeviceId");
            References(x => x.Address, "AddressId");
            References(x => x.MainHub, "MainHubId");

            HasMany(x => x.Users).KeyColumn("CommNodeId").Inverse().Cascade.SaveUpdate();


            Table("CommNodes");
        }
    }
}
