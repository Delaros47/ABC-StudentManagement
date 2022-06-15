using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfClassDal : EfEntityRepositoryBase<Class, StudentManagementContext>, IClassDal
    {
        public List<ClassDetailDto> GetClassDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from c in context.Classes
                             join cg in context.ClassGroups
                             on c.ClassGroupId equals cg.Id
                             select new ClassDetailDto
                             {
                                 Id = c.Id,
                                 ClassName = c.ClassName,
                                 AimRevenue = c.AimRevenue,
                                 AimStudentNumber = c.AimStudentNumber,
                                 Description =c.Description,
                                 PrivateCode=c.PrivateCode,
                                 State =c.State,
                                 ClassGroupName = cg.ClassGroupName
                             };
                return result.ToList();
            }
        }
    }
}
