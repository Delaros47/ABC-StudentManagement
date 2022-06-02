using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyEmailTextEdit : MyTextEdit
    {

        public MyEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            //The reason why we made AutoComplete is strong that if we make none that it will put a space between @ and first text on email
            //It is better and more suitable for us to use Strong
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            StatusBarDescription = "Enter the Email Address.";

        }

    }
}
