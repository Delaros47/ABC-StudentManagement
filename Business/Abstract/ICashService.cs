using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICashService
    {
        IDataResult<List<Cash>> GetAll();
        IDataResult<Cash> Get(int cashId);
        IDataResult<List<Cash>> GetCashActive();
        IDataResult<List<Cash>> GetCashPassive();
        IDataResult<Cash> GetLastCashPrivateCode();
        IResult Add(Cash cash);
        IResult Update(Cash cash);
        IResult Delete(Cash cash);
    }
}
