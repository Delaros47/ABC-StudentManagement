using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Commons.Functions
{
    public class GeneratePrivateCodes
    {
        public static string GeneratePrivate(string privateCode)
        {
            var result = privateCode.Split('-');
            var entity = "";
            var number = "";
            var final = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (i==0)
                {
                    entity = result[i];
                }
                else
                {
                    number = result[i];
                }
            }
            int increse = Convert.ToInt32(number);
            increse += 1;
            if (increse<9)
            {
                final = entity + "-000" + increse;
            }
            else if (increse<99)
            {
                final = entity + "-00" + increse;
            }
            else if (increse<999)
            {
                final = entity + "-0" + increse;
            }
            else if (increse<9999)
            {
                final = entity + "-" + increse;
            }
            
            return final;
        }
    }
}
