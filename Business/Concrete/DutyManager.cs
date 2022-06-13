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
    public class DutyManager : IDutyService
    {
        private readonly IDutyDal _dutyDal;
        public DutyManager(IDutyDal dutyDal)
        {
            _dutyDal = dutyDal;
        }

        public IResult Add(Duty duty)
        {
            _dutyDal.Add(duty);
            return new SuccessResult(Messages.GetMessage("Duty",Process.Add));
        }

        public IResult Delete(Duty duty)
        {
            _dutyDal.Delete(duty);
            return new SuccessResult(Messages.GetMessage("Duty", Process.Delete));
        }

        public IDataResult<Duty> Get(int dutyId)
        {
            return new SuccessDataResult<Duty>(_dutyDal.Get(d=>d.Id==dutyId));
        }

        public IDataResult<List<Duty>> GetAll()
        {
            return new SuccessDataResult<List<Duty>>(_dutyDal.GetAll());
        }

        public IDataResult<List<Duty>> GetDutyActive()
        {
            return new SuccessDataResult<List<Duty>>(_dutyDal.GetAll(d=>d.State==true));
        }

        public IDataResult<List<Duty>> GetDutyPassive()
        {
            return new SuccessDataResult<List<Duty>>(_dutyDal.GetAll(d => d.State == false));
        }

        public IDataResult<Duty> GetLastDutyPrivateCode()
        {
            return new SuccessDataResult<Duty>(_dutyDal.GetAll().Last());
        }

        public IResult Update(Duty duty)
        {
            _dutyDal.Update(duty);
            return new SuccessResult(Messages.GetMessage("Duty", Process.Update));
        }
    }
}
