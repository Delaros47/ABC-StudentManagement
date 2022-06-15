using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfServiceDal : EfEntityRepositoryBase<Service, StudentManagementContext>, IServiceDal
    {
        public List<ServiceDetailDto> GetServiceDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from s in context.Services
                             join st in context.ServiceTypes
                             on s.ServiceTypeId equals st.Id
                             select new ServiceDetailDto
                             {
                                 Id = s.Id,
                                 PrivateCode = s.PrivateCode,
                                 Price = s.Price,
                                 StartDate =s.StartDate,
                                 Description =s.Description,
                                 EndDate = s.EndDate,
                                 State = s.State,
                                 ServiceName = s.ServiceName,
                                 ServiceTypeName= st.ServiceTypeName
                                
                             };
                return result.ToList();
            }
        }
    }
}
