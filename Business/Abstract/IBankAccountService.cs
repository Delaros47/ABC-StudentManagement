using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IBankAccountService
    {
        IDataResult<List<BankAccount>> GetAll();
        IDataResult<BankAccount> Get(int bankAccountId);
        IDataResult<List<BankAccountDetailDto>> GetBankAccountDetailDtoActive();
        IDataResult<List<BankAccountDetailDto>> GetBankAccountDetailDtoPassive();
        IDataResult<BankAccount> GetLastBankAccountPrivateCode();
        IResult Add(BankAccount bankAccount);
        IResult Update(BankAccount bankAccount);
        IResult Delete(BankAccount bankAccount);
    }
}
