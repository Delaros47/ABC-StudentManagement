using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICancelReasonService
    {
        IDataResult<List<CancelReason>> GetAll();
        IDataResult<CancelReason> Get(int cancelReasonId);
        IDataResult<List<CancelReason>> GetCancelReasonActive();
        IDataResult<List<CancelReason>> GetCancelReasonPassive();
        IDataResult<CancelReason> GetLastCancelReasonPrivateCode();
        IResult Add(CancelReason cancelReason);
        IResult Update(CancelReason cancelReason);
        IResult Delete(CancelReason cancelReason);
    }
}
