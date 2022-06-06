using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetAll();
        IDataResult<List<District>> GetAllActive();
        IDataResult<List<District>> GetAllPassive();
        IDataResult<District> Get(int districtId);
        IResult Add(District district);
        IResult Update(District district);
        IResult Delete(District district);
    }
}
