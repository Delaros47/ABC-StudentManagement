using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IOccupationService
    {
        IDataResult<List<Occupation>> GetAll();
        IDataResult<Occupation> Get(int occupationId);
        IDataResult<List<Occupation>> GetOccupationActive();
        IDataResult<List<Occupation>> GetOccupationPassive();
        IDataResult<Occupation> GetLastOccupationPrivateCode();
        IResult Add(Occupation occupation);
        IResult Update(Occupation occupation);
        IResult Delete(Occupation occupation);
    }
}
