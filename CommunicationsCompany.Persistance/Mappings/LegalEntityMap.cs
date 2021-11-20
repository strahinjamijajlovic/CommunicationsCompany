using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class LegalEntityMap : ClassMap<LegalEntity>
    {
        public LegalEntityMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.FaxNumber).Not.Nullable().Length(20);
            Map(x => x.PIB).Not.Nullable().Length(20);

            References(x => x.ContactPerson, "ContactPersonId").Cascade.All();
            References(x => x.Services, "ServicesId").Cascade.All();

            Table("LegalEntities");
        }
    }
}
