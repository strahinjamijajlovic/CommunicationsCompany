using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class ExtraProgramMap : ClassMap<ExtraProgram>
    {
        public ExtraProgramMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Not.Nullable().Length(50);

            References(x => x.Service, "ServiceId");

            Table("ExtraProgrammes");
        }
    }
}
