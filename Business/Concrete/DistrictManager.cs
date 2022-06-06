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
    public class DistrictManager : IDistrictService
    {

        private readonly IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IResult Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult(Messages.GetMessage("District",Process.Add));
        }

        public IResult Delete(District district)
        {
            _districtDal.Delete(district);
            return new SuccessResult(Messages.GetMessage("District", Process.Delete));
        }

        public IDataResult<District> Get(int districtId)
        {
            return new SuccessDataResult<District>(_districtDal.Get(d=>d.Id==districtId));
        }

        public IDataResult<List<District>> GetAll()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(d=>d.State==true));
        }

        public IDataResult<List<District>> GetAllActive()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(d=>d.State==true));
        }

        public IDataResult<List<District>> GetAllPassive()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(d=>d.State==false));
        }

        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult(Messages.GetMessage("District", Process.Update));
        }
    }
}
