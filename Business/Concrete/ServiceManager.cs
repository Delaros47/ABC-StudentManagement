using Business.Abstract;
using Business.Contants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public IResult Add(Service service)
        {
            _serviceDal.Add(service);
            return new SuccessResult(Messages.GetMessage("Service",Process.Add));
        }

        public IResult Delete(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult(Messages.GetMessage("Service", Process.Delete));
        }

        public IDataResult<Service> Get(int serviceId)
        {
            return new SuccessDataResult<Service>(_serviceDal.Get(s=>s.Id==serviceId));
        }

        public IDataResult<List<ServiceDetailDto>> GetActiveServiceDetailDto()
        {
            return new SuccessDataResult<List<ServiceDetailDto>>(_serviceDal.GetServiceDetailDto().Where(s=>s.State==true).ToList());
        }

        public IDataResult<List<Service>> GetAll()
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetAll());
        }

        public IDataResult<Service> GetLastServicePrivateCode()
        {
            return new SuccessDataResult<Service>(_serviceDal.GetAll().Last());
        }

        public IDataResult<List<ServiceDetailDto>> GetPassiveServiceDetailDto()
        {
            return new SuccessDataResult<List<ServiceDetailDto>>(_serviceDal.GetServiceDetailDto().Where(s => s.State == false).ToList());
        }

        public IDataResult<List<Service>> GetServiceActive()
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetAll(s=>s.State==true));
        }

        public IDataResult<List<ServiceDetailDto>> GetServiceDetailDto()
        {
            return new SuccessDataResult<List<ServiceDetailDto>>(_serviceDal.GetServiceDetailDto());
        }

        public IDataResult<List<Service>> GetServicePassive()
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetAll(s => s.State == false));
        }

        public IResult Update(Service service)
        {
            _serviceDal.Update(service);
            return new SuccessResult(Messages.GetMessage("Service", Process.Update));
        }
    }
}
