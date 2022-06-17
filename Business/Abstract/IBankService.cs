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
    public interface IBankService
    {
        IDataResult<List<Bank>> GetAll();
        IDataResult<Bank> Get(int bankId);
        IDataResult<Bank> GetLastBankPrivateCode();
        IDataResult<List<BankDetailDto>> GetBankDetailActiveDto();
        IDataResult<List<BankDetailDto>> GetBankDetailPassiveDto();
        IResult Add(Bank bank);
        IResult Update(Bank bank);
        IResult Delete(Bank bank);
    }
}
