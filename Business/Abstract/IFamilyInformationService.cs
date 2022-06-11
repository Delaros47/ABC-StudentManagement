using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IFamilyInformationService
    {
        IDataResult<List<FamilyInformation>> GetAll();
        IDataResult<FamilyInformation> Get(int familyInformationId);
        IDataResult<List<FamilyInformation>> GetFamilyInformationActive();
        IDataResult<List<FamilyInformation>> GetFamilyInformationPassive();
        IDataResult<FamilyInformation> GetLastFamilyInformationPrivateCode();
        IResult Add(FamilyInformation familyInformation);
        IResult Update(FamilyInformation familyInformation);
        IResult Delete(FamilyInformation familyInformation);

    }
}
