using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IWorkplaceService
    {
        IDataResult<List<Workplace>> GetAll();
        IDataResult<Workplace> Get(int workplaceId);
        IDataResult<List<Workplace>> GetWorkplaceActive();
        IDataResult<List<Workplace>> GetWorkplacePassive();
        IDataResult<Workplace> GetLastWorkplacePrivateCode();
        IResult Add(Workplace workplace);
        IResult Update(Workplace workplace);
        IResult Delete(Workplace workplace);
    }
}
