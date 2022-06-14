using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IDiscountTypeService
    {
        IDataResult<List<DiscountType>> GetAll();
        IDataResult<DiscountType> Get(int discountTypeId);
        IDataResult<List<DiscountType>> GetDiscountTypeActive();
        IDataResult<List<DiscountType>> GetDiscountTypePassive();
        IDataResult<DiscountType> GetLastDiscountTypePrivateCode();
        IResult Add(DiscountType discountType);
        IResult Update(DiscountType discountType);
        IResult Delete(DiscountType discountType);
    }
}
