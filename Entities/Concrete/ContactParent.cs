using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class ContactParent : IEntity
    {
        public int ContactParentId { get; set; }
        public string PrivateCode { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodType { get; set; }
        public string SerialNumber { get; set; }
        public string SequenceNumber { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Neighbourhood { get; set; }
        public string VolumeNumber { get; set; }
        public string FamilySequenceNumber { get; set; }
        public string PersonSequenceNumber { get; set; }
        public string PlaceIssued { get; set; }
        public string IdentityIssuedReason { get; set; }
        public string IdentityRegisterNumber { get; set; }
        public DateTime IdentityIssuedDate { get; set; }
        public string HomePhone { get; set; }
        public string WorkplacePhone1 { get; set; }
        public string WorkplacePhone2 { get; set; }
        public string InternalPhone1 { get; set; }
        public string InternalPhone2 { get; set; }
        public string CellPhone1 { get; set; }
        public string CellPhone2 { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int HomeAddressCityId { get; set; }
        public int HomeAddressDistrictId { get; set; }
        public string WorkAddress { get; set; }
        public int WorkAddressCityId { get; set; }
        public int WorkAddressDistrictId { get; set; }
        public int OccupationId { get; set; }
        public int WorkplaceId { get; set; }
        public int DutyId { get; set; }
        public string IBanNumber { get; set; }
        public string CardNumber { get; set; }
        public int SpecialCode1 { get; set; }
        public int SpecialCode2 { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }

    }
}
