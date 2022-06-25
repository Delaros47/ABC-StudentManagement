using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class BankAccount:IEntity
    {
        public int Id { get; set; }
        public string PrivateCode { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public int BankId { get; set; }
        public string BankBranch { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public string AccountNumber { get; set; }
        public string IbanNumber { get; set; }
        public int BlockedDayNumber { get; set; }
        public string WorkPlaceNumber { get; set; }
        public string TerminalNumber { get; set; }
        public int SpecialCode1 { get; set; }
        public int SpecialCode2 { get; set; }
        public bool State { get; set; }
        public string? Description { get; set; }
    }
}
