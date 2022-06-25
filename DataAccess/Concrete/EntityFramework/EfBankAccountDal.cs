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
    public class EfBankAccountDal : EfEntityRepositoryBase<BankAccount, StudentManagementContext>, IBankAccountDal
    {
        public List<BankAccountDetailDto> GetBankAccountDetailDto()
        {
            using (var context = new StudentManagementContext())
            {

                var result = from b in context.BankAccounts
                             join b1 in context.Banks
                             on b.BankId equals b1.Id
                             join s in context.SpecialCodes
                             on b.SpecialCode1 equals s.Id
                             join sk in context.SpecialCodes
                             on b.SpecialCode2 equals sk.Id

                             select new BankAccountDetailDto
                             {
                                 Id = b.Id,
                                 AccountName = b.AccountName,
                                 AccountNumber = b.AccountNumber,
                                 AccountOpeningDate = b.AccountOpeningDate,
                                 AccountType = b.AccountType,
                                 BankBranch = b.BankBranch,
                                 BankName = b1.BankName,
                                 BlockedDayNumber = b.BlockedDayNumber,
                                 IbanNumber = b.IbanNumber,
                                 TerminalNumber = b.TerminalNumber,
                                 WorkPlaceNumber = b.WorkPlaceNumber,
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
