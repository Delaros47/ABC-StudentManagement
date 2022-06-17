using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.DTOs
{
    public class BankDetailDto:IDto
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string BankName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
