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
    public interface IClassDal:IEntityRepository<Class>
    {
        List<ClassDetailDto> GetClassDetailDto();
    }
}
