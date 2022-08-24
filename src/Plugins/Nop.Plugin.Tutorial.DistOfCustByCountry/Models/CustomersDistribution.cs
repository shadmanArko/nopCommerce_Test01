﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Models
{
    public record CustomersDistribution : BaseNopModel
    {
        public string Country { get; set; }
        public int NoOfCustomers { get; set; }
    }
}
