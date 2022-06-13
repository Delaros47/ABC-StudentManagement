using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IDutyService
    {
        IDataResult<List<Duty>> GetAll();
        IDataResult<Duty> Get(int dutyId);
        IDataResult<List<Duty>> GetDutyActive();
        IDataResult<List<Duty>> GetDutyPassive();
        IDataResult<Duty> GetLastDutyPrivateCode();
        IResult Add(Duty duty);
        IResult Update(Duty duty);
        IResult Delete(Duty duty);
    }
}
