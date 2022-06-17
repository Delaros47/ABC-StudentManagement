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
    public class EfBankDal : EfEntityRepositoryBase<Bank, StudentManagementContext>, IBankDal
    {
        public List<BankDetailDto> GetBankDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from b in context.Banks
                             join s in context.SpecialCodes
                             on b.SpecialCode1 equals s.Id
                             join sk in context.SpecialCodes
                             on b.SpecialCode2 equals sk.Id

                             select new BankDetailDto
                             {
                                 Id = b.Id,
                                 BankName = b.BankName,
                                 PrivateCode = b.PrivateCode,
                                 Description = b.Description,
                                 State = b.State,
                                 SpecialCode1 = s.SpecialCodeName,
                                 SpecialCode2 = sk.SpecialCodeName
                             };
                return result.ToList();
            }
        }
    }
}
