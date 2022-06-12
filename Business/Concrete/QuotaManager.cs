using Business.Abstract;
using Business.Contants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class QuotaManager : IQuotaService
    {

        private readonly IQuotaDal _quotaDal;
        public QuotaManager(IQuotaDal quotaDal)
        {
            _quotaDal = quotaDal;
        }

        public IResult Add(Quota quota)
        {
            _quotaDal.Add(quota);
            return new SuccessResult(Messages.GetMessage("Quota",Process.Add));
        }

        public IResult Delete(Quota quota)
        {
            _quotaDal.Delete(quota);
            return new SuccessResult(Messages.GetMessage("Quota", Process.Delete));
        }

        public IDataResult<Quota> Get(int quotaId)
        {
            return new SuccessDataResult<Quota>(_quotaDal.Get(q=>q.Id==quotaId));
        }

        public IDataResult<List<Quota>> GetAll()
        {
            return new SuccessDataResult<List<Quota>>(_quotaDal.GetAll());
        }

        public IDataResult<Quota> GetLastQuotaPrivateCode()
        {
            return new SuccessDataResult<Quota>(_quotaDal.GetAll().Last());
        }

        public IDataResult<List<Quota>> GetQuotaActive()
        {
            return new SuccessDataResult<List<Quota>>(_quotaDal.GetAll(q=>q.State==true));
        }

        public IDataResult<List<Quota>> GetQuotaPassive()
        {
            return new SuccessDataResult<List<Quota>>(_quotaDal.GetAll(q => q.State == false));
        }

        public IResult Update(Quota quota)
        {
            _quotaDal.Update(quota);
            return new SuccessResult(Messages.GetMessage("Quota", Process.Update));
        }
    }
}
