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
    public class EfContactParentDal : EfEntityRepositoryBase<ContactParent, StudentManagementContext>, IContactParentDal
    {
        public List<ContactParentDetailDto> GetContactDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from c in context.ContactParents
                             join ct in context.Cities
                             on c.CityId equals ct.Id
                             join d in context.Districts
                             on c.DistrictId equals d.Id
                             join hc in context.Cities
                             on c.HomeAddressCityId equals hc.Id
                             join hd in context.Districts
                             on c.HomeAddressDistrictId equals hd.Id
                             join wc in context.Cities
                             on c.WorkAddressCityId equals wc.Id
                             join wd in context.Districts
                             on c.WorkAddressDistrictId equals wd.Id
                             join o in context.Occupations
                             on c.OccupationId equals o.Id
                             join du in context.Duties
                             on c.DutyId equals du.Id
                             join wp in context.Workplaces
                             on c.WorkplaceId equals wp.Id
                             join s in context.SpecialCodes
                             on c.SpecialCode1 equals s.Id
                             join sk in context.SpecialCodes
                             on c.SpecialCode2 equals sk.Id

                             select new ContactParentDetailDto
                             {
                                 ContactParentId = c.ContactParentId,
                                 Address = c.Address,
                                 BirthPlace = c.BirthPlace,
                                 BloodType = c.BloodType,
                                 CardNumber = c.CardNumber,
                                 Web = c.Web,
                                 City = ct.CityName,
                                 District = d.DistrictName,
                                 HomePhone = c.HomePhone,
                                 CellPhone1 = c.CellPhone1,
                                 CellPhone2 = c.CellPhone2,
                                 DateOfBirth = c.DateOfBirth,
                                 PrivateCode = c.PrivateCode,
                                 Description = c.Description,
                                 State =c.State,
                                 SpecialCode1 = s.SpecialCodeName,
                                 SpecialCode2 = sk.SpecialCodeName,
                                 Email = c.Email,
                                 FamilySequenceNumber = c.FamilySequenceNumber,
                                 FatherName = c.FatherName,
                                 InternalPhone1 = c.InternalPhone1,
                                 InternalPhone2 = c.InternalPhone2,
                                 WorkAddress = c.WorkAddress,
                                 WorkplacePhone1 = c.WorkplacePhone1,
                                 WorkplacePhone2 = c.WorkplacePhone2,
                                 IBanNumber = c.IBanNumber,
                                 IdentityIssuedDate= c.IdentityIssuedDate,
                                 Name = c.Name,
                                 Surname = c.Surname,
                                 IdentityIssuedReason = c.IdentityIssuedReason,
                                 MotherName = c.MotherName,
                                 PersonSequenceNumber = c.PersonSequenceNumber,
                                 IdentityNumber = c.IdentityNumber,
                                 SequenceNumber = c.SequenceNumber,
                                 VolumeNumber = c.VolumeNumber,
                                 IdentityRegisterNumber = c.IdentityRegisterNumber,
                                 SerialNumber = c.SerialNumber,
                                 PlaceIssued = c.PlaceIssued,
                                 Neighbourhood = c.Neighbourhood,
                                 Duty = du.DutyName,
                                 Occupation = o.OccupationName,
                                 HomeAddressCity = hc.CityName,
                                 HomeAddressDistrict = hd.DistrictName,
                                 WorkAddressCity= wc.CityName,
                                 WorkAddressDistrict = wd.DistrictName,
                                 WorkplaceName = wp.WorkplaceName,
                             };
                return result.ToList();
            }
        }
    }
}
