﻿using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.DataAccess;

namespace DataAccess.Abstract
{
    public interface IContactParentDal:IEntityRepository<ContactParent>
    {
        List<ContactParentDetailDto> GetContactDetailDto();

    }
}
