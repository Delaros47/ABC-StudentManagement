using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IPromotionService
    {
        IDataResult<List<Promotion>> GetAll();
        IDataResult<Promotion> Get(int promotionId);
        IDataResult<List<Promotion>> GetPromotionActive();
        IDataResult<List<Promotion>> GetPromotionPassive();
        IDataResult<Promotion> GetLastPromotionPrivateCode();
        IResult Add(Promotion promotion);
        IResult Update(Promotion promotion);
        IResult Delete(Promotion promotion);
    }
}
