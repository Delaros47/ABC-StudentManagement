using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IIncentiveService
    {
        IDataResult<List<Incentive>> GetAll();
        IDataResult<Incentive> Get(int incentiveId);
        IDataResult<List<Incentive>> GetIncentiveActive();
        IDataResult<List<Incentive>> GetIncentivePassive();
        IDataResult<Incentive> GetLastIncentivePrivateCode();
        IResult Add(Incentive incentive);
        IResult Update(Incentive incentive);
        IResult Delete(Incentive incentive);
    }
}
