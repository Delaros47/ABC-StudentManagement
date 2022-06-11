using Business.Abstract;
using Business.Contants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CancelReasonManager : ICancelReasonService
    {
        private readonly ICancelReasonDal _cancelReasonDal;
        public CancelReasonManager(ICancelReasonDal cancelReasonDal)
        {
            _cancelReasonDal = cancelReasonDal;
        }

        public IResult Add(CancelReason cancelReason)
        {
            _cancelReasonDal.Add(cancelReason);
            return new SuccessResult(Messages.GetMessage("Cancel Reason",Process.Add));
        }

        public IResult Delete(CancelReason cancelReason)
        {
            _cancelReasonDal.Delete(cancelReason);
            return new SuccessResult(Messages.GetMessage("Cancel Reason", Process.Delete));
        }

        public IDataResult<CancelReason> Get(int cancelReasonId)
        {
            return new SuccessDataResult<CancelReason>(_cancelReasonDal.Get(c=>c.Id==cancelReasonId));
        }

        public IDataResult<List<CancelReason>> GetAll()
        {
            return new SuccessDataResult<List<CancelReason>>(_cancelReasonDal.GetAll());
        }

        public IDataResult<List<CancelReason>> GetCancelReasonActive()
        {
            return new SuccessDataResult<List<CancelReason>>(_cancelReasonDal.GetAll(c=>c.State==true));
        }

        public IDataResult<List<CancelReason>> GetCancelReasonPassive()
        {
            return new SuccessDataResult<List<CancelReason>>(_cancelReasonDal.GetAll(c => c.State == false));
        }

        public IDataResult<CancelReason> GetLastCancelReasonPrivateCode()
        {
            return new SuccessDataResult<CancelReason>(_cancelReasonDal.GetAll().Last());
        }

        public IResult Update(CancelReason cancelReason)
        {
            _cancelReasonDal.Update(cancelReason);
            return new SuccessResult(Messages.GetMessage("Cancel Reason", Process.Update));
        }
    }
}
