using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ISchoolServiceService
    {
        IDataResult<List<SchoolService>> GetAll();
        IDataResult<SchoolService> Get(int schoolServiceId);
        IDataResult<List<SchoolService>> GetSchoolServiceActive();
        IDataResult<List<SchoolService>> GetSchoolServicePassive();
        IDataResult<SchoolService> GetLastSchoolServicePrivateCode();
        IResult Add(SchoolService schoolService);
        IResult Update(SchoolService schoolService);
        IResult Delete(SchoolService schoolService);
    }
}
