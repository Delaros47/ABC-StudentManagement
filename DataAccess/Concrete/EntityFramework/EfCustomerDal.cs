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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, StudentManagementContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from c in context.Customers
                             join s in context.SpecialCodes
                             on c.SpecialCode1 equals s.Id
                             join sk in context.SpecialCodes
                             on c.SpecialCode2 equals sk.Id

                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 CustomerName = c.CustomerName,
                                 Address = c.Address,
                                 Email = c.Email,
                                 IdentityNumber = c.IdentityNumber,
                                 Fax = c.Fax,
                                 Phone1 = c.Phone1,
                                 Phone2 = c.Phone2,
                                 Phone3 = c.Phone3,
                                 Phone4 = c.Phone4,
                                 TaxNumber = c.TaxNumber,
                                 TaxOffice = c.TaxOffice,
                                 Web = c.Web,
                                 PrivateCode = c.PrivateCode,
                                 Description = c.Description,
                                 State = c.State,
                                 SpecialCode1 = s.SpecialCodeName,
                                 SpecialCode2 = sk.SpecialCodeName
                             };
                return result.ToList();
            }
        }
    }
}
