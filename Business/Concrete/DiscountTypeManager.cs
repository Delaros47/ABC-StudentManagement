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
    public class DiscountTypeManager : IDiscountTypeService
    {

        private readonly IDiscountTypeDal _discountTypeDal;
        public DiscountTypeManager(IDiscountTypeDal discountTypeDal)
        {
            _discountTypeDal = discountTypeDal;
        }

        public IResult Add(DiscountType discountType)
        {
            _discountTypeDal.Add(discountType);
            return new SuccessResult(Messages.GetMessage("Discount Type",Process.Add));
        }

        public IResult Delete(DiscountType discountType)
        {
            _discountTypeDal.Delete(discountType);
            return new SuccessResult(Messages.GetMessage("Discount Type", Process.Delete));
        }

        public IDataResult<DiscountType> Get(int discountTypeId)
        {
            return new SuccessDataResult<DiscountType>(_discountTypeDal.Get(d=>d.Id==discountTypeId));
        }

        public IDataResult<List<DiscountType>> GetAll()
        {
            return new SuccessDataResult<List<DiscountType>>(_discountTypeDal.GetAll());
        }

        public IDataResult<List<DiscountType>> GetDiscountTypeActive()
        {
            return new SuccessDataResult<List<DiscountType>>(_discountTypeDal.GetAll(d=>d.State==true));
        }

        public IDataResult<List<DiscountType>> GetDiscountTypePassive()
        {
            return new SuccessDataResult<List<DiscountType>>(_discountTypeDal.GetAll(d => d.State == false));
        }

        public IDataResult<DiscountType> GetLastDiscountTypePrivateCode()
        {
            return new SuccessDataResult<DiscountType>(_discountTypeDal.GetAll().Last());
        }

        public IResult Update(DiscountType discountType)
        {
            _discountTypeDal.Update(discountType);
            return new SuccessResult(Messages.GetMessage("Discount Type", Process.Update));
        }
    }
}
