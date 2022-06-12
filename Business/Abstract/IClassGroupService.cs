using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IClassGroupService
    {
        IDataResult<List<ClassGroup>> GetAll();
        IDataResult<ClassGroup> Get(int classGroupId);
        IDataResult<List<ClassGroup>> GetClassGroupActive();
        IDataResult<List<ClassGroup>> GetClassGroupPassive();
        IDataResult<ClassGroup> GetLastClassGroupPrivateCode();
        IResult Add(ClassGroup classGroup);
        IResult Update(ClassGroup classGroup);
        IResult Delete(ClassGroup classGroup);
    }
}
