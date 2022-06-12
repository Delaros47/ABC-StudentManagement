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

namespace StudentManagementUI.Forms.FamilyIntimacyForms
{
    public partial class FamilyIntimacyListForm : BaseListForm
    {
        private readonly IFamilyIntimacyService _familyIntimacyService;
        public FamilyIntimacyListForm()
        {
            InitializeComponent();
            _familyIntimacyService = InstanceFactory.GetInstance<IFamilyIntimacyService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Family Intimacy");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _familyIntimacyService.Delete(new FamilyIntimacy
                {
                    Id = Convert.ToInt32(gridViewFamilyIntimacies.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllFamilyIntimacyActive();
                }
            }
        }

        private void GetAllFamilyIntimacyActive()
        {
            gridControlFamilyIntimacies.DataSource = _familyIntimacyService.GetFamilyIntimacyActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FamilyIntimacyEditForm.FamilyIntimacyId = -1;
            CreateForms<FamilyIntimacyEditForm>.ShowDialogEditForm();
            GetAllFamilyIntimacyActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FamilyIntimacyEditForm.FamilyIntimacyId = Convert.ToInt32(gridViewFamilyIntimacies.GetFocusedRowCellValue("Id").ToString());
            CreateForms<FamilyIntimacyEditForm>.ShowDialogEditForm();
            GetAllFamilyIntimacyActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllFamilyIntimacyActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlFamilyIntimacies.DataSource = _familyIntimacyService.GetFamilyIntimacyPassive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlFamilyIntimacies.DataSource = _familyIntimacyService.GetFamilyIntimacyActive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void FamilyIntimacyListForm_Load(object sender, EventArgs e)
        {
            GetAllFamilyIntimacyActive();
        }

        private void gridViewFamilyIntimacies_DoubleClick(object sender, EventArgs e)
        {
            FamilyIntimacyEditForm.FamilyIntimacyId = Convert.ToInt32(gridViewFamilyIntimacies.GetFocusedRowCellValue("Id").ToString());
            CreateForms<FamilyIntimacyEditForm>.ShowDialogEditForm();
            GetAllFamilyIntimacyActive();
        }
    }
}