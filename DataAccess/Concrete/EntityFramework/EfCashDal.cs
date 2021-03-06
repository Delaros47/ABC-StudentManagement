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
    public class EfCashDal : EfEntityRepositoryBase<Cash, StudentManagementContext>, ICashDal
    {
        public List<CashDetailDto> GetCashDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from c in context.Cashes
                             join s in context.SpecialCodes
                             on c.SpecialCode1 equals  s.Id
                             join sk in context.SpecialCodes
                             on c.SpecialCode2 equals sk.Id
                             
                             select new CashDetailDto
                             {
                                 Id = c.Id,
                                 CashName = c.CashName,
                                 PrivateCode = c.PrivateCode,
                                 Description = c.Description,
                                 State = c.State,
                                 SpecialCode1 = s.SpecialCodeName,
                                 SpecialCode2 =sk.SpecialCodeName
                             };
                return result.ToList();
            }
        }
    }
}
