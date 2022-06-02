using DevExpress.Utils;
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
    public class MyCreditCardEdit : MyTextEdit
    {
        public MyCreditCardEdit()
        {
            //It puts our Credit Card number center of TextBox
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //Here we choose our Mask for Credit Card but we use Regular one
            Properties.Mask.MaskType = MaskType.Regular;
            //Here d is any Numeric value 0-9 and ? means can also be null or empty too
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            //We don't want whenever we don't fill all credit card number and we dont want it fills with 0 digits
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarDescription = "Enter Credit Card number";
        }
    }
}
