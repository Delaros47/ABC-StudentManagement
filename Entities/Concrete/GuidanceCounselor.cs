using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class GuidanceCounselor:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string NameSurname { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
