using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.DTOs
{
    public class ServiceDetailDto:IDto
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
