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
    public class PaymentTypeManager : IPaymentTypeService
    {
        private readonly IPaymentTypeDal _paymentTypeDal;
        public PaymentTypeManager(IPaymentTypeDal paymentTypeDal)
        {
            _paymentTypeDal = paymentTypeDal;
        }

        public IResult Add(PaymentType paymentType)
        {
            _paymentTypeDal.Add(paymentType);
            return new SuccessResult(Messages.GetMessage("Payment Type",Process.Add));
        }

        public IResult Delete(PaymentType paymentType)
        {
            _paymentTypeDal.Delete(paymentType);
            return new SuccessResult(Messages.GetMessage("Payment Type", Process.Delete));
        }

        public IDataResult<PaymentType> Get(int paymentTypeId)
        {
            return new SuccessDataResult<PaymentType>(_paymentTypeDal.Get(p=>p.Id==paymentTypeId));
        }

        public IDataResult<List<PaymentType>> GetAll()
        {
            return new SuccessDataResult<List<PaymentType>>(_paymentTypeDal.GetAll());
        }

        public IDataResult<PaymentType> GetLastPaymentTypePrivateCode()
        {
            return new SuccessDataResult<PaymentType>(_paymentTypeDal.GetAll().Last());
        }

        public IDataResult<List<PaymentType>> GetPaymentTypeActive()
        {
            return new SuccessDataResult<List<PaymentType>>(_paymentTypeDal.GetAll(p=>p.State==true));
        }

        public IDataResult<List<PaymentType>> GetPaymentTypePassive()
        {
            return new SuccessDataResult<List<PaymentType>>(_paymentTypeDal.GetAll(p => p.State == false));
        }

        public IResult Update(PaymentType paymentType)
        {
            _paymentTypeDal.Update(paymentType);
            return new SuccessResult(Messages.GetMessage("Payment Type", Process.Update));
        }
    }
}
