using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string BloodType { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentitySerialNumber { get; set; }
        public string NumberIndividual { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string SubDistrictVillage { get; set; }
        public string VolumeNumber { get; set; }
        public string FamilyOrder { get; set; }
        public string PlaceOfIssue { get; set; }
        public string IssuedFor { get; set; }
        public DateTime DateOfIssue { get; set; }
        public byte[] Image { get; set; }
        public int SpecialCode1 { get; set; }
        public int SpecialCode2 { get; set; }
        public int SpecialCode3 { get; set; }
        public int SpecialCode4 { get; set; }
        public int SpecialCode5 { get; set; }
        public bool State { get; set; }
        public string Description { get; set; }

    }
}
