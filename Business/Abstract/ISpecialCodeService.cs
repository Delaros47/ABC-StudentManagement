using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ISpecialCodeService
    {
        IDataResult<List<SpecialCode>> GetAll();
        IDataResult<SpecialCode> Get(int specialCodeId);
        IDataResult<SpecialCode> GetLastSpecialCodePrivateCode();
        IResult Add(SpecialCode specialCode);
        IResult Update(SpecialCode specialCode);
        IResult Delete(SpecialCode specialCode);
    }
}
