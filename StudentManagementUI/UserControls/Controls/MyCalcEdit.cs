using DevExpress.Utils;
using DevExpress.XtraEditors;
using StudentManagementUI.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit, IStatusBarShortcut
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //We don't want our Control to be null value either 0 or values not null
            Properties.AllowNullInput = DefaultBoolean.False;
            //N actually means Numeric after 3 digits puts a point make our number like that 835.486 and 2 makes our number like that 835.486,00         
            Properties.EditMask = "n2";
            //This is how our Numeric will look like after we are not focused on it
            Properties.DisplayFormat.FormatType = FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; } = "Calculator";
    }
}
