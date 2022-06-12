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
    public class WorkplaceManager : IWorkplaceService
    {
        private readonly IWorkplaceDal _workplaceDal;
        public WorkplaceManager(IWorkplaceDal workplaceDal)
        {
            _workplaceDal = workplaceDal;
        }

        public IResult Add(Workplace workplace)
        {
            _workplaceDal.Add(workplace);
            return new SuccessResult(Messages.GetMessage("Workplace",Process.Add));
        }

        public IResult Delete(Workplace workplace)
        {
            _workplaceDal.Delete(workplace);
            return new SuccessResult(Messages.GetMessage("Workplace", Process.Delete));
        }

        public IDataResult<Workplace> Get(int workplaceId)
        {
            return new SuccessDataResult<Workplace>(_workplaceDal.Get(w=>w.Id==workplaceId));
        }

        public IDataResult<List<Workplace>> GetAll()
        {
            return new SuccessDataResult<List<Workplace>>(_workplaceDal.GetAll());
        }

        public IDataResult<Workplace> GetLastWorkplacePrivateCode()
        {
            return new SuccessDataResult<Workplace>(_workplaceDal.GetAll().Last());
        }

        public IDataResult<List<Workplace>> GetWorkplaceActive()
        {
            return new SuccessDataResult<List<Workplace>>(_workplaceDal.GetAll(w=>w.State==true));
        }

        public IDataResult<List<Workplace>> GetWorkplacePassive()
        {
            return new SuccessDataResult<List<Workplace>>(_workplaceDal.GetAll(w => w.State == false));
        }

        public IResult Update(Workplace workplace)
        {
            _workplaceDal.Update(workplace);
            return new SuccessResult(Messages.GetMessage("Workplace", Process.Update));
        }
    }
}
