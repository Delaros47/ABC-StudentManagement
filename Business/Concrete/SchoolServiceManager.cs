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
    public class SchoolServiceManager : ISchoolServiceService
    {

        private readonly ISchoolServiceDal _schoolServiceDal;
        public SchoolServiceManager(ISchoolServiceDal schoolServiceDal)
        {
            _schoolServiceDal = schoolServiceDal;
        }

        public IResult Add(SchoolService schoolService)
        {
            _schoolServiceDal.Add(schoolService);
            return new SuccessResult(Messages.GetMessage("School Service",Process.Add));
        }

        public IResult Delete(SchoolService schoolService)
        {
            _schoolServiceDal.Delete(schoolService);
            return new SuccessResult(Messages.GetMessage("School Service", Process.Delete));
        }

        public IDataResult<SchoolService> Get(int schoolServiceId)
        {
            return new SuccessDataResult<SchoolService>(_schoolServiceDal.Get(s=>s.Id==schoolServiceId));
        }

        public IDataResult<List<SchoolService>> GetAll()
        {
            return new SuccessDataResult<List<SchoolService>>(_schoolServiceDal.GetAll());
        }

        public IDataResult<SchoolService> GetLastSchoolServicePrivateCode()
        {
            return new SuccessDataResult<SchoolService>(_schoolServiceDal.GetAll().Last());
        }

        public IDataResult<List<SchoolService>> GetSchoolServiceActive()
        {
            return new SuccessDataResult<List<SchoolService>>(_schoolServiceDal.GetAll(s => s.State == true));
        }

        public IDataResult<List<SchoolService>> GetSchoolServicePassive()
        {
            return new SuccessDataResult<List<SchoolService>>(_schoolServiceDal.GetAll(s=>s.State==false));
        }

        public IResult Update(SchoolService schoolService)
        {
            _schoolServiceDal.Update(schoolService);
            return new SuccessResult(Messages.GetMessage("School Service", Process.Update));
        }
    }
}
