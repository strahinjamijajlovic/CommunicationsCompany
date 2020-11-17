using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class DeviceMap : ClassMap<Device>
    {
        public DeviceMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.SerialNumber).Not.Nullable().Length(50);
            Map(x => x.ManufacturerName).Not.Nullable().Length(100);
            Map(x => x.InstallationDate).Not.Nullable();
            Map(x => x.LastServiceDate).Nullable();
            Map(x => x.LastServiceReason).Nullable().Length(500);

            Table("Devices");
        }
    }
}
