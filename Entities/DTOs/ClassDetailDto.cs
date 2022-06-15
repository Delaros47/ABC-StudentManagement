using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.DTOs
{
    public class ClassDetailDto:IDto
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string ClassName { get; set; }
        public string ClassGroupName { get; set; }
        public int AimStudentNumber { get; set; }
        public decimal AimRevenue { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
