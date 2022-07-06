using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public class MyPictureEdit : PictureEdit, IStatusBarShortcut
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "No Picture";
            Properties.SizeMode = PictureSizeMode.Stretch;
            //We dont want default menu to be shown we will later create own Menu
            Properties.ShowMenu = true;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; }
    }
}
