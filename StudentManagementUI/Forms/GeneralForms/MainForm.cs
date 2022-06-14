using DevExpress.XtraBars;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Forms.CancelReasonForms;
using StudentManagementUI.Forms.CityForms;
using StudentManagementUI.Forms.ClassGroupForms;
using StudentManagementUI.Forms.DiscountTypeForms;
using StudentManagementUI.Forms.DocumentForms;
using StudentManagementUI.Forms.DutyForms;
using StudentManagementUI.Forms.FamilyInformationForms;
using StudentManagementUI.Forms.FamilyIntimacyForms;
using StudentManagementUI.Forms.ForeignLanguageForms;
using StudentManagementUI.Forms.GuidanceCounselorForms;
using StudentManagementUI.Forms.IncentiveForms;
using StudentManagementUI.Forms.OccupationForms;
using StudentManagementUI.Forms.QuotaForms;
using StudentManagementUI.Forms.SchoolForms;
using StudentManagementUI.Forms.WorkplaceForms;
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
            else if (e.Item==btnFamilyInformations)
            {
                CreateForms<FamilyInformationListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnCancelReasons)
            {
                CreateForms<CancelReasonListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnForeignLanguages)
            {
                CreateForms<ForeignLanguageListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnIncentives)
            {
                CreateForms<IncentiveListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnQuotas)
            {
                CreateForms<QuotaListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnGuidanceCounselors)
            {
                CreateForms<GuidanceCounselorListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnClassGroups)
            {
                CreateForms<ClassGroupListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnOccupations)
            {
                CreateForms<OccupationListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnFamilyIntimacies)
            {
                CreateForms<FamilyIntimacyListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnWorkplace)
            {
                CreateForms<WorkplaceListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnDuties)
            {
                CreateForms<DutyListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnDiscountType)
            {
                CreateForms<DiscountTypeListForm>.ShowDialogListForm();
            }
            else if (e.Item==btnDocuments)
            {
                CreateForms<DocumentListForm>.ShowDialogListForm();
            }
        }
    }
}