using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win.Wizard;
using DevExpress.XtraGrid.Views.Grid;
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

namespace StudentManagementUI.Forms.ForeignLanguageForms
{
    public partial class ForeignLanguageListForm : BaseListForm
    {

        private readonly IForeignLanguageService _foreignLanguageService;
        public ForeignLanguageListForm()
        {
            InitializeComponent();
            _foreignLanguageService = InstanceFactory.GetInstance<IForeignLanguageService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlForeignLanguage;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Foreign Language");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _foreignLanguageService.Delete(new ForeignLanguage
                {
                    Id = Convert.ToInt32(gridViewForeignLanguage.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllForeignLanguageServiceActive();
                }
            }
        }

        private void GetAllForeignLanguageServiceActive()
        {
            gridControlForeignLanguage.DataSource = _foreignLanguageService.GetForeignLanguageActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ForeignLanguageEditForm.ForeignLanguageId = -1;
            CreateForms<ForeignLanguageEditForm>.ShowDialogEditForm();
            GetAllForeignLanguageServiceActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ForeignLanguageEditForm.ForeignLanguageId = Convert.ToInt32(gridViewForeignLanguage.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ForeignLanguageEditForm>.ShowDialogEditForm();
            GetAllForeignLanguageServiceActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllForeignLanguageServiceActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlForeignLanguage.DataSource = _foreignLanguageService.GetForeignLanguageActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlForeignLanguage.DataSource = _foreignLanguageService.GetForeignLanguagePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void ForeignLanguageListForm_Load(object sender, EventArgs e)
        {
            GetAllForeignLanguageServiceActive();
        }

        private void gridViewForeignLanguage_DoubleClick(object sender, EventArgs e)
        {
            ForeignLanguageEditForm.ForeignLanguageId = Convert.ToInt32(gridViewForeignLanguage.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ForeignLanguageEditForm>.ShowDialogEditForm();
            GetAllForeignLanguageServiceActive();
        }
    }
}