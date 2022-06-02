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
    public class MyToggleSwitch : ToggleSwitch, IStatusBarDescription
    {
        public MyToggleSwitch()
        {
            //Since ToggleSwitch only will be used to check the state so we don't need to name every time so we just named here
            Name = "tglState";
            //Whenever we off our ToggleSwitch that text will be written Passive
            Properties.OffText = "Passive";
            //Whenever we on our ToggleSwitch that text will be written Active
            Properties.OnText = "Active";
            Properties.AutoHeight = false;
            //Here we will be using DataLayoutControl whenever we put our ToggleSwitch on it that it will get Width of DataLayoutControl
            Properties.AutoWidth = true;
            //Whenever we on or off our ToggleSwitch that text will be left side of our ToggleSwitch
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;

        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; } = "Choose the state of the form.";
    }
}
