using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Commons.Messages
{
    public class Messages
    {
        public static void ErrorMessage(string errorMessage)
        {
            XtraMessageBox.Show(errorMessage,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static DialogResult YesSelectedYesNo(string message,string title)
        {
           return  XtraMessageBox.Show(message,title,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult NoSelectedYesNo(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult DeleteMessage(string formType)
        {
            return NoSelectedYesNo($"Selected {formType} will be deleted. Are you sure?","Deleting confirmation");
        }
    }
}
