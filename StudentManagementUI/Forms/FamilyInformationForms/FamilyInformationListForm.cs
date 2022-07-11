using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.FamilyInformationForms
{
    public partial class FamilyInformationListForm : BaseListForm
    {
        private readonly IFamilyInformationService _familyInformationService;
        public FamilyInformationListForm()
        {
            InitializeComponent();
            _familyInformationService = InstanceFactory.GetInstance<IFamilyInformationService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlFamilyInformation;
        }

        private void FamilyInformationListForm_Load(object sender, EventArgs e)
        {
            GetAllFamilyInformationActive();
        }

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Family Information");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _familyInformationService.Delete(new FamilyInformation
                {
                    Id = Convert.ToInt32(gridViewFamilyInformation.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllFamilyInformationActive();
                }
            }
        }

        private void GetAllFamilyInformationActive()
        {
            gridControlFamilyInformation.DataSource = _familyInformationService.GetFamilyInformationActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForms<FamilyInformationEditForm>.ShowDialogEditForm();
            GetAllFamilyInformationActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FamilyInformationEditForm.FamilyInformationId = Convert.ToInt32(gridViewFamilyInformation.GetFocusedRowCellValue("Id").ToString());
            CreateForms<FamilyInformationEditForm>.ShowDialogEditForm();
            GetAllFamilyInformationActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllFamilyInformationActive();
        }

        private void gridViewFamilyInformation_DoubleClick(object sender, EventArgs e)
        {
            FamilyInformationEditForm.FamilyInformationId = Convert.ToInt32(gridViewFamilyInformation.GetFocusedRowCellValue("Id").ToString());
            CreateForms<FamilyInformationEditForm>.ShowDialogEditForm();
            GetAllFamilyInformationActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlFamilyInformation.DataSource = _familyInformationService.GetFamilyInformationActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlFamilyInformation.DataSource = _familyInformationService.GetFamilyInformationPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }
    }
}