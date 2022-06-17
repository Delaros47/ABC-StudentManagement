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
    public class BankManager : IBankService
    {
        private readonly IBankDal _bankDal;
        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        public IResult Add(Bank bank)
        {
            _bankDal.Add(bank);
            return new SuccessResult(Messages.GetMessage("Bank", Process.Add));
        }

        public IResult Delete(Bank bank)
        {
            _bankDal.Delete(bank);
            return new SuccessResult(Messages.GetMessage("Bank", Process.Delete));
        }

        public IDataResult<Bank> Get(int bankId)
        {
            return new SuccessDataResult<Bank>(_bankDal.Get(b => b.Id == bankId));
        }

        public IDataResult<List<Bank>> GetAll()
        {
            return new SuccessDataResult<List<Bank>>(_bankDal.GetAll());
        }

        public IDataResult<List<BankDetailDto>> GetBankDetailActiveDto()
        {
            return new SuccessDataResult<List<BankDetailDto>>(_bankDal.GetBankDetailDto().Where(b => b.State == true).ToList());
        }

        public IDataResult<List<BankDetailDto>> GetBankDetailPassiveDto()
        {
            return new SuccessDataResult<List<BankDetailDto>>(_bankDal.GetBankDetailDto().Where(b => b.State == false).ToList());
        }

        public IDataResult<Bank> GetLastBankPrivateCode()
        {
            return new SuccessDataResult<Bank>(_bankDal.GetAll().Last());
        }

        public IResult Update(Bank bank)
        {
            _bankDal.Update(bank);
            return new SuccessResult(Messages.GetMessage("Bank", Process.Update)); ;
        }
    }
}
