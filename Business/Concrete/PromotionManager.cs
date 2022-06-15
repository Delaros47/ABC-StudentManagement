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
    public class PromotionManager : IPromotionService
    {

        private readonly IPromotionDal _promotionDal;
        public PromotionManager(IPromotionDal promotionDal)
        {
            _promotionDal = promotionDal;
        }

        public IResult Add(Promotion promotion)
        {
            _promotionDal.Add(promotion);
            return new SuccessResult(Messages.GetMessage("Promotion",Process.Add));
        }

        public IResult Delete(Promotion promotion)
        {
            _promotionDal.Delete(promotion);
            return new SuccessResult(Messages.GetMessage("Promotion", Process.Delete));
        }

        public IDataResult<Promotion> Get(int promotionId)
        {
            return new SuccessDataResult<Promotion>(_promotionDal.Get(p=>p.Id==promotionId));
        }

        public IDataResult<List<Promotion>> GetAll()
        {
            return new SuccessDataResult<List<Promotion>>(_promotionDal.GetAll());
        }

        public IDataResult<Promotion> GetLastPromotionPrivateCode()
        {
            return new SuccessDataResult<Promotion>(_promotionDal.GetAll().Last());
        }

        public IDataResult<List<Promotion>> GetPromotionActive()
        {
            return new SuccessDataResult<List<Promotion>>(_promotionDal.GetAll(p=>p.State==true));
        }

        public IDataResult<List<Promotion>> GetPromotionPassive()
        {
            return new SuccessDataResult<List<Promotion>>(_promotionDal.GetAll(p => p.State == false));
        }

        public IResult Update(Promotion promotion)
        {
            _promotionDal.Update(promotion);
            return new SuccessResult(Messages.GetMessage("Promotion", Process.Update));
        }
    }
}
