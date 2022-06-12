using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IQuotaService
    {
        IDataResult<List<Quota>> GetAll();
        IDataResult<Quota> Get(int quotaId);
        IDataResult<List<Quota>> GetQuotaActive();
        IDataResult<List<Quota>> GetQuotaPassive();
        IDataResult<Quota> GetLastQuotaPrivateCode();
        IResult Add(Quota quota);
        IResult Update(Quota quota);
        IResult Delete(Quota quota);
    }
}
