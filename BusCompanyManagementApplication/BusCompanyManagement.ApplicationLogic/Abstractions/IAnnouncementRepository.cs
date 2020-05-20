﻿using BusCompanyManagement.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusCompanyManagement.ApplicationLogic.Abstractions
{
    public interface IAnnouncementRepository : IRepository<Announcement>
    {
        Announcement GetAnnouncementById(Guid Id);

       
    }
}
