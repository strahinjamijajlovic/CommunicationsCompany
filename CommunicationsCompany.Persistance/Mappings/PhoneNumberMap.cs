using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class PhoneNumberMap : ClassMap<PhoneNumber>
    {
        public PhoneNumberMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Number).Not.Nullable().Length(20);
            Map(x => x.MinutesCount).Not.Nullable();

            References(x => x.Service, "ServiceId").Cascade.SaveUpdate();

            Table("PhoneNumbers");
        }
    }
}
