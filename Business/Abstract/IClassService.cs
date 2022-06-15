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
    public interface IClassService
    {
        IDataResult<List<Class>> GetAll();
        IDataResult<Class> Get(int classId);
        IDataResult<List<Class>> GetClassActive();
        IDataResult<List<Class>> GetClassPassive();
        IDataResult<Class> GetLastClassPrivateCode();
        IDataResult<List<ClassDetailDto>> GetClassDetailDtoActive();
        IDataResult<List<ClassDetailDto>> GetClassDetailDtoPassive();
        IResult Add(Class classs);
        IResult Update(Class classs);
        IResult Delete(Class classs);
    }
}
