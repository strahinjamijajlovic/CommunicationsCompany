using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class ServicesMap : ClassMap<Services>
    {
        public ServicesMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();

            References(x => x.InternetService, "InternetServiceId");

            HasMany(x => x.PhoneNumbers).KeyColumn("ServiceId").Inverse().Cascade.SaveUpdate();
            HasMany(x => x.ExtraTvPrograms).KeyColumn("ServiceId").Inverse().Cascade.SaveUpdate();

            Table("Services");
        }
    }
}
