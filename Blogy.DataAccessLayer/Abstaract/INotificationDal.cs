﻿using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstaract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        List<Notification> GetLast3Notifications();
    }
}
