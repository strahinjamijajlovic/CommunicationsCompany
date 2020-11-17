﻿using CommunicationsCompany.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationsCompany.Persistance.Mappings
{
    public class InternetServiceMap : ClassMap<ExtraProgram>
    {
        public InternetServiceMap()
        {

            Table("InternetServices");
        }
    }
}
