using DevExpress.XtraBars.Ribbon;
using StudentManagementUI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Commons.Functions
{
    public static class CreateForms<TForm> where TForm : RibbonForm
    {
        public static void ShowDialogEditForm()
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.ShowDialog();

        }

        public static void ShowDialogListForm()
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.Show();

        }

        public static void ShowDialogListFormWithoutParent()
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.ShowDialog();
        }
    }
}
