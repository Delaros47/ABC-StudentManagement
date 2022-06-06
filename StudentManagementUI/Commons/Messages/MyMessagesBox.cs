using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Commons.Messages
{
    public class MyMessagesBox
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

        public static void AddedMessage(string message)
        {
            XtraMessageBox.Show(message,"Adding a new",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public static void UpdatedMessage(string message)
        {
            XtraMessageBox.Show(message, "Updating a new", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public static void GridRowWrongSelectedMessage()
        {
            XtraMessageBox.Show("Please click on the proper Rows", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
