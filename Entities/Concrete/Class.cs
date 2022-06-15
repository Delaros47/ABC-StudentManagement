using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class Class:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string ClassName { get; set; }
        public int ClassGroupId { get; set; }
        public int AimStudentNumber { get; set; }
        public decimal AimRevenue { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
