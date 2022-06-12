using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IFamilyIntimacyService
    {
        IDataResult<List<FamilyIntimacy>> GetAll();
        IDataResult<FamilyIntimacy> Get(int familyIntimacyId);
        IDataResult<List<FamilyIntimacy>> GetFamilyIntimacyActive();
        IDataResult<List<FamilyIntimacy>> GetFamilyIntimacyPassive();
        IDataResult<FamilyIntimacy> GetLastFamilyIntimacyPrivateCode();
        IResult Add(FamilyIntimacy familyIntimacy);
        IResult Update(FamilyIntimacy familyIntimacy);
        IResult Delete(FamilyIntimacy familyIntimacy);
    }
}
