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
    public class OccupationManager : IOccupationService
    {
        private readonly IOccupationDal _occupationDal;
        public OccupationManager(IOccupationDal occupationDal)
        {
            _occupationDal = occupationDal;
        }

        public IResult Add(Occupation occupation)
        {
            _occupationDal.Add(occupation);
            return new SuccessResult(Messages.GetMessage("Occupation", Process.Add));
        }

        public IResult Delete(Occupation occupation)
        {
            _occupationDal.Delete(occupation);
            return new SuccessResult(Messages.GetMessage("Occupation", Process.Delete));
        }

        public IDataResult<Occupation> Get(int occupationId)
        {
            return new SuccessDataResult<Occupation>(_occupationDal.Get(o => o.Id == occupationId));
        }

        public IDataResult<List<Occupation>> GetAll()
        {
            return new SuccessDataResult<List<Occupation>>(_occupationDal.GetAll());
        }

        public IDataResult<Occupation> GetLastOccupationPrivateCode()
        {
            return new SuccessDataResult<Occupation>(_occupationDal.GetAll().Last());
        }

        public IDataResult<List<Occupation>> GetOccupationActive()
        {
            return new SuccessDataResult<List<Occupation>>(_occupationDal.GetAll(o => o.State == true));
        }

        public IDataResult<List<Occupation>> GetOccupationPassive()
        {
            return new SuccessDataResult<List<Occupation>>(_occupationDal.GetAll(o => o.State == false));
        }

        public IResult Update(Occupation occupation)
        {
            _occupationDal.Update(occupation);
            return new SuccessResult(Messages.GetMessage("Occupation", Process.Update));
        }
    }
}
