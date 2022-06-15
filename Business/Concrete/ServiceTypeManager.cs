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
    public class ServiceTypeManager : IServiceTypeService
    {
        private readonly IServiceTypeDal _serviceTypeDal;
        public ServiceTypeManager(IServiceTypeDal serviceTypeDal)
        {
            _serviceTypeDal = serviceTypeDal;
        }

        public IResult Add(ServiceType serviceType)
        {
            _serviceTypeDal.Add(serviceType);
            return new SuccessResult(Messages.GetMessage("Service Type",Process.Add));
        }

        public IResult Delete(ServiceType serviceType)
        {
            _serviceTypeDal.Delete(serviceType);
            return new SuccessResult(Messages.GetMessage("Service Type", Process.Delete));
        }

        public IDataResult<ServiceType> Get(int serviceTypeId)
        {
            return new SuccessDataResult<ServiceType>(_serviceTypeDal.Get(s=>s.Id==serviceTypeId));
        }

        public IDataResult<List<ServiceType>> GetAll()
        {
            return new SuccessDataResult<List<ServiceType>>(_serviceTypeDal.GetAll());
        }

        public IDataResult<ServiceType> GetLastServiceTypePrivateCode()
        {
            return new SuccessDataResult<ServiceType>(_serviceTypeDal.GetAll().Last());
        }

        public IDataResult<List<ServiceType>> GetServiceTypeActive()
        {
            return new SuccessDataResult<List<ServiceType>>(_serviceTypeDal.GetAll(s=>s.State==true));
        }

        public IDataResult<List<ServiceType>> GetServiceTypePassive()
        {
            return new SuccessDataResult<List<ServiceType>>(_serviceTypeDal.GetAll(s => s.State == false));
        }

        public IResult Update(ServiceType serviceType)
        {
            _serviceTypeDal.Update(serviceType);
            return new SuccessResult(Messages.GetMessage("Service Type", Process.Update));
        }
    }
}
