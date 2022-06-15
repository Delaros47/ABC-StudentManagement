using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IServiceService
    {
        IDataResult<List<Service>> GetAll();
        IDataResult<Service> Get(int serviceId);
        IDataResult<List<Service>> GetServiceActive();
        IDataResult<List<Service>> GetServicePassive();
        IDataResult<Service> GetLastServicePrivateCode();
        IDataResult<List<ServiceDetailDto>> GetActiveServiceDetailDto();
        IDataResult<List<ServiceDetailDto>> GetPassiveServiceDetailDto();
        IResult Add(Service service);
        IResult Update(Service service);
        IResult Delete(Service service);
    }
}
