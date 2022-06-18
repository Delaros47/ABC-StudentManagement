using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IPaymentTypeService
    {
        IDataResult<List<PaymentType>> GetAll();
        IDataResult<PaymentType> Get(int paymentTypeId);
        IDataResult<List<PaymentType>> GetPaymentTypeActive();
        IDataResult<List<PaymentType>> GetPaymentTypePassive();
        IDataResult<PaymentType> GetLastPaymentTypePrivateCode();
        IResult Add(PaymentType paymentType);
        IResult Update(PaymentType paymentType);
        IResult Delete(PaymentType paymentType);
    }
}
