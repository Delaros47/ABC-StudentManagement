using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class School:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public bool State { get; set; }
        public string SchoolName { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Description { get; set; }


    }
}
