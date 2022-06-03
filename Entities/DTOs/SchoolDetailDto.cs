using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.DTOs
{
    public class SchoolDetailDto:IDto
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public bool State { get; set; }
        public string SchoolName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string Description { get; set; }
    }
}
