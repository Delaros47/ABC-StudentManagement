using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public enum Process
    {
        Add,
        Update,
        Delete
    }
    public class Messages
    {

        public static string GetMessage(string formName, Process process)
        {
            string result = string.Empty;
            switch (process)
            {
                case Process.Add:
                    result = $"A new {formName} has successfully added.";
                    break;
                case Process.Update:
                    result = $"The current {formName} has successfully updated.";
                    break;
                case Process.Delete:
                    result = $"The current {formName} has successfully deleted.";
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
