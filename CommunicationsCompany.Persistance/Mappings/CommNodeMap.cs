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
            HasOne(x => x.Device).ForeignKey("DeviceId").Cascade.All();
            HasOne(x => x.Address).ForeignKey("AddressId").Cascade.All();

            HasMany(x => x.Users).KeyColumn("CommNodeId").Cascade.SaveUpdate();


            Table("CommNodes");
        }
    }
}
