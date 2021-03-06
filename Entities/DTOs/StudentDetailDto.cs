using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.DTOs
{
    public class StudentDetailDto:IDto
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
        public string IdentityNumber { get; set; }
        public string NumberIndividual { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string PersonNumber { get; set; }
        public string SubDistrictVillage { get; set; }
        public string VolumeNumber { get; set; }
        public string FamilyOrder { get; set; }
        public string RegisterNumber { get; set; }
        public string PlaceOfIssue { get; set; }
        public string IssuedFor { get; set; }
        public DateTime DateOfIssue { get; set; }
        public byte[] Image { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string SpecialCode5 { get; set; }
        public bool State { get; set; }
    }
}
