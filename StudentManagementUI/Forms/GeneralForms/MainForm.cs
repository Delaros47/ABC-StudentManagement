using DevExpress.XtraBars;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Forms.CancelReasonForms;
using StudentManagementUI.Forms.CityForms;
using StudentManagementUI.Forms.FamilyInformationForms;
using StudentManagementUI.Forms.ForeignLanguageForms;
using StudentManagementUI.Forms.SchoolForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.GeneralForms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            EvenLoads();
        }

        private void EvenLoads()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Buttons_ItemClick;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (e.Item==btnSchools)
            {             
                CreateForms<SchoolListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnCities)
            {
                CreateForms<CityListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnFamilyInformation)
            {
                CreateForms<FamilyInformationListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnCancelReason)
            {
                CreateForms<CancelReasonListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnForeignLanguages)
            {
                CreateForms<ForeignLanguageListForm>.ShowDialogListForm();
            }
        }
    }
}