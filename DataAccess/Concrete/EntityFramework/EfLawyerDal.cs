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
    public class EfLawyerDal : EfEntityRepositoryBase<Lawyer, StudentManagementContext>, ILawyerDal
    {
        public List<LawyerDetailDto> GetLawyerDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from l in context.Lawyers
                             join s in context.SpecialCodes
                             on l.SpecialCode1 equals s.Id
                             join sk in context.SpecialCodes
                             on l.SpecialCode2 equals sk.Id

                             select new LawyerDetailDto
                             {
                                 Id = l.Id,
                                 NameSurname = l.NameSurname,
                                 ContractNumber = l.ContractNumber,
                                 ContractStartDate = l.ContractStartDate,
                                 ContractEndDate = l.ContractEndDate,
                                 PrivateCode = l.PrivateCode,
                                 Description = l.Description,
                                 State = l.State,
                                 SpecialCode1 = s.SpecialCodeName,
                                 SpecialCode2 = sk.SpecialCodeName
                             };
                return result.ToList();
            }
        }
    }
}
