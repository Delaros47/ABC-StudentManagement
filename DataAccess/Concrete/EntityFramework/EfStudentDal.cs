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
    public class EfStudentDal : EfEntityRepositoryBase<Student, StudentManagementContext>, IStudentDal
    {
        public List<StudentDetailDto> GetStudentDetailDto()
        {
            using (var context = new StudentManagementContext())
            {
                var result = from s in context.Students
                             join c in context.Cities
                             on s.CityId equals c.Id
                             join d in context.Districts
                             on s.DistrictId equals d.Id
                             join s1 in context.SpecialCodes
                             on s.SpecialCode1 equals s1.Id
                             join s2 in context.SpecialCodes
                             on s.SpecialCode1 equals s2.Id
                             join s3 in context.SpecialCodes
                             on s.SpecialCode1 equals s3.Id
                             join s4 in context.SpecialCodes
                             on s.SpecialCode1 equals s4.Id
                             join s5 in context.SpecialCodes
                             on s.SpecialCode1 equals s5.Id
                             select new StudentDetailDto
                             {
                                 Id = s.Id,
                                 BloodType = s.BloodType,
                                 DateOfBirth= s.DateOfBirth,
                                 DateOfIssue = s.DateOfIssue,
                                 FamilyOrder = s.FamilyOrder,
                                 CityName = c.CityName,
                                 Description = s.Description,
                                 Name = s.Name,
                                 Surname = s.Surname,
                                 FatherName = s.FatherName,
                                 MotherName = s.MotherName,
                                 DistrictName = d.DistrictName,
                                 Gender = s.Gender,
                                 Phone = s.Phone,
                                 IdentitySerialNumber = s.IdentitySerialNumber,
                                 NumberIndividual = s.NumberIndividual,
                                 SubDistrictVillage = s.SubDistrictVillage,
                                 VolumeNumber = s.VolumeNumber,
                                 PlaceOfBirth = s.PlaceOfBirth,
                                 IssuedFor = s.IssuedFor,
                                 State = s.State,
                                 PlaceOfIssue = s.PlaceOfIssue,
                                 SpecialCode1 = s1.SpecialCodeName,
                                 SpecialCode2 = s2.SpecialCodeName,
                                 SpecialCode3 = s3.SpecialCodeName,
                                 SpecialCode4 = s4.SpecialCodeName,
                                 SpecialCode5 = s5.SpecialCodeName,
                                 PrivateCode =s.PrivateCode

                             };
                return result.ToList();

            }
        }
    }
}
