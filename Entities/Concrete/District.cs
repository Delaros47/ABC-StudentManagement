using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class District:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public bool State { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public string Description { get; set; }

    }
}
