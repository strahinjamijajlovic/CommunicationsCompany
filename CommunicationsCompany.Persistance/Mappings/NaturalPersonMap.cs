using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class NaturalPersonMap : ClassMap<NaturalPerson>
    {
        public NaturalPersonMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.JMBG).Not.Nullable().Length(13);
            Map(x => x.ContactNumber).Not.Nullable().Length(20);

            References(x => x.User, "UserId").Cascade.All();
            References(x => x.Address, "AddressId").Cascade.All();
            References(x => x.Services, "ServicesId").Cascade.All();

            Table("NaturalPersons");
        }
    }
}
