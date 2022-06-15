using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IServiceTypeService
    {
        IDataResult<List<ServiceType>> GetAll();
        IDataResult<ServiceType> Get(int serviceTypeId);
        IDataResult<List<ServiceType>> GetServiceTypeActive();
        IDataResult<List<ServiceType>> GetServiceTypePassive();
        IDataResult<ServiceType> GetLastServiceTypePrivateCode();
        IResult Add(ServiceType serviceType);
        IResult Update(ServiceType serviceType);
        IResult Delete(ServiceType serviceType);
    }
}
