﻿using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstaract
{
    public interface IWriterMessageDal : IGenericDal<WriterMessage>
    {
        List<WriterMessage> GetWriterMessagesByUser(AppUser user);
        WriterMessage GetWriterMessagesByIdWithUser(int id);
    }
}
