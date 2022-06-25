using Business.Abstract;
using Business.Contants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class BankAccountManager : IBankAccountService
    {
        private readonly IBankAccountDal _bankAccountDal;
        public BankAccountManager(IBankAccountDal bankAccountDal)
        {
            _bankAccountDal = bankAccountDal;
        }

        public IResult Add(BankAccount bankAccount)
        {
            _bankAccountDal.Add(bankAccount);
            return new SuccessResult(Messages.GetMessage("Bank Account",Process.Add));
        }

        public IResult Delete(BankAccount bankAccount)
        {
            _bankAccountDal.Delete(bankAccount);
            return new SuccessResult(Messages.GetMessage("Bank Account", Process.Delete));
        }

        public IDataResult<BankAccount> Get(int bankAccountId)
        {
            return new SuccessDataResult<BankAccount>(_bankAccountDal.Get(b=>b.Id==bankAccountId));
        }

        public IDataResult<List<BankAccount>> GetAll()
        {
            return new SuccessDataResult<List<BankAccount>>(_bankAccountDal.GetAll());
        }

        public IDataResult<List<BankAccountDetailDto>> GetBankAccountDetailDtoActive()
        {
            return new SuccessDataResult<List<BankAccountDetailDto>>(_bankAccountDal.GetBankAccountDetailDto().Where(b=>b.State==true).ToList());
        }

        public IDataResult<List<BankAccountDetailDto>> GetBankAccountDetailDtoPassive()
        {
            return new SuccessDataResult<List<BankAccountDetailDto>>(_bankAccountDal.GetBankAccountDetailDto().Where(b => b.State == false).ToList());
        }

        public IDataResult<BankAccount> GetLastBankAccountPrivateCode()
        {
            return new SuccessDataResult<BankAccount>(_bankAccountDal.GetAll().Last());
        }

        public IResult Update(BankAccount bankAccount)
        {
            _bankAccountDal.Update(bankAccount);
            return new SuccessResult(Messages.GetMessage("Bank Account", Process.Update));
        }
    }
}
