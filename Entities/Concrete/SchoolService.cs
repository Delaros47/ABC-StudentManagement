using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class SchoolService:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string SchoolServiceName { get; set; }
        public decimal Price { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
