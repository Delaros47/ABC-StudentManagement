using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<City> GetLastPrivateCode();
        IDataResult<List<City>> GetAllActive();
        IDataResult<List<City>> GetAllPassive();
        IDataResult<City> Get(int cityId);
        IResult Add(City city);
        IResult Update(City city);
        IResult Delete(City city);

    }
}
