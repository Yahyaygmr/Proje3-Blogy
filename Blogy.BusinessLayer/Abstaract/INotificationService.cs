﻿using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Abstaract
{
    public interface INotificationService : IGenericService<Notification>
    {
        List<Notification> TGetLast3Notifications();
    }
}
