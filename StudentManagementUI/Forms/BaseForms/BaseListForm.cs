using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}