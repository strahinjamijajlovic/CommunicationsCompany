using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.FirstName).Length(50);
            Map(x => x.LastName).Length(50);
            References(x => x.CommNode, "CommNodeId").Cascade.All();

            Table("Users");
        }
    }
}
