﻿using BusCompanyManagement.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusCompanyManagementApplication.Models.Buses
{
    public class BusViewModel
    {
        public IEnumerable<Bus> Buses { get; set; }
    }
}
