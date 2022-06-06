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
    public class SchoolManager : ISchoolService
    {

        private readonly ISchoolDal _schoolDal;
        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }

        public IResult Add(School school)
        {
            _schoolDal.Add(school);
            return new SuccessResult(Messages.GetMessage("School",Process.Add));
        }

        public IResult Delete(School school)
        {
            _schoolDal.Delete(school);
            return new SuccessResult(Messages.GetMessage("School", Process.Delete));
        }

        public IDataResult<School> Get(int schoolId)
        {
            return new SuccessDataResult<School>(_schoolDal.Get(s=>s.Id==schoolId));
        }

        public IDataResult<List<School>> GetAll()
        {
            return new SuccessDataResult<List<School>>(_schoolDal.GetAll());
        }

        public IDataResult<List<SchoolDetailDto>> GetSchoolDetailDto()
        {
            return new SuccessDataResult<List<SchoolDetailDto>>(_schoolDal.GetSchoolDetailDto().ToList());
        }

        public IDataResult<List<SchoolDetailDto>> GetSchoolDetailDtoActive()
        {
            return new SuccessDataResult<List<SchoolDetailDto>>(_schoolDal.GetSchoolDetailDto().Where(s => s.State == true).ToList());
        }

        public IDataResult<List<SchoolDetailDto>> GetSchoolDetailDtoPassive()
        {
            return new SuccessDataResult<List<SchoolDetailDto>>(_schoolDal.GetSchoolDetailDto().Where(s=>s.State==false).ToList());
        }

        public IResult Update(School school)
        {
            _schoolDal.Update(school);
            return new SuccessResult(Messages.GetMessage("School", Process.Update));
        }
    }
}
