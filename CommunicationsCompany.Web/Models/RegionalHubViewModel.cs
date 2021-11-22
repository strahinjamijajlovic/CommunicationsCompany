﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Models
{
    public class RegionalHubViewModel
    {
        public long Id { get; set; }
        public string RegionName { get; set; } = string.Empty;
        public DeviceViewModel Device { get; set; }
    }
}
