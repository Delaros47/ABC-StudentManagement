using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Commons.Functions
{
    public class ClearAll
    {
        public static void Clean(Control dataLayoutControl)
        {
            foreach (Control ctrl in dataLayoutControl.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
        }
    }
}
