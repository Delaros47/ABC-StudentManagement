using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ISchoolService
    {
        IDataResult<List<School>> GetAll();
        IDataResult<School> Get(int schoolId);
        IDataResult<List<SchoolDetailDto>> GetSchoolDetailDto();
        IDataResult<List<SchoolDetailDto>> GetSchoolDetailDtoActive();
        IDataResult<List<SchoolDetailDto>> GetSchoolDetailDtoPassive();
        IResult Add(School school);
        IResult Update(School school);
        IResult Delete(School school);
    }
}
