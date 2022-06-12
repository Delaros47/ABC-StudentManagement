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
    public class IncentiveManager : IIncentiveService
    {
        private readonly IIncentiveDal _incentiveDal;
        public IncentiveManager(IIncentiveDal incentiveDal)
        {
            _incentiveDal = incentiveDal;
        }

        public IResult Add(Incentive incentive)
        {
            _incentiveDal.Add(incentive);
            return new SuccessResult(Messages.GetMessage("Incentive",Process.Add));
        }

        public IResult Delete(Incentive incentive)
        {
            _incentiveDal.Delete(incentive);
            return new SuccessResult(Messages.GetMessage("Incentive", Process.Delete));
        }

        public IDataResult<Incentive> Get(int incentiveId)
        {
            return new SuccessDataResult<Incentive>(_incentiveDal.Get(i=>i.Id==incentiveId));
        }

        public IDataResult<List<Incentive>> GetAll()
        {
            return new SuccessDataResult<List<Incentive>>(_incentiveDal.GetAll()); 
        }

        public IDataResult<List<Incentive>> GetIncentiveActive()
        {
            return new SuccessDataResult<List<Incentive>>(_incentiveDal.GetAll(i=>i.State==true));
        }

        public IDataResult<List<Incentive>> GetIncentivePassive()
        {
            return new SuccessDataResult<List<Incentive>>(_incentiveDal.GetAll(i => i.State == false));
        }

        public IDataResult<Incentive> GetLastIncentivePrivateCode()
        {
            return new SuccessDataResult<Incentive>(_incentiveDal.GetAll().Last());
        }

        public IResult Update(Incentive incentive)
        {
            _incentiveDal.Update(incentive);
            return new SuccessResult(Messages.GetMessage("Incentive", Process.Update));
        }
    }
}
