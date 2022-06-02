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
    public class MyButtonEdit : ButtonEdit, IStatusBarShortcut
    {

        public MyButtonEdit()
        {
            //Disable text edit in our ButtonEdit we cannot write anything in ButtonEdit
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;


        }

        //If we want anything to change in our properties that we have to override it and whenever we 
        //press enter button that it will move automatically to next control
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutDescription { get; set; }
        public string StatusBarDescription { get; set; }


        //We declared Id property that it will hold old and new value whenever we choose a city that it will get current and previous Id number
        //That's why we created even called IdChanged whenever our Id changed that it will invoke our codes and hold old and new and we used [Browsable(false)] cause when we put our ButtonEdit on Form from Property will be not visible

        private int? _id;
        [Browsable(false)]
        public int? Id
        {
            get { return _id; }
            set
            {
                var oldValue = _id;
                var newValue = value;
                if (newValue == oldValue)
                {
                    return;
                }
                _id = value;
                if (IdChanged!=null)
                IdChanged(this,new IdChangedEventArgs(oldValue, newValue));
            }
        }



        public event EventHandler<IdChangedEventArgs> IdChanged;


    }

    //We have created IdChangedEventArgs class in order to hold new and old value in our ButtonEdit
    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(int? oldValue, int? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public int? OldValue { get; }
        public int? NewValue { get; }


    }
}
