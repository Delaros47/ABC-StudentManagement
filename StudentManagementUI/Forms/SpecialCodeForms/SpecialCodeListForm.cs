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

namespace StudentManagementUI.Forms.SpecialCodeForms
{
    public partial class SpecialCodeListForm : BaseListForm
    {
        private readonly ISpecialCodeService _specialCodeService;
        public SpecialCodeListForm()
        {
            InitializeComponent();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Special Code");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _specialCodeService.Delete(new SpecialCode
                {
                    Id = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllSpecialCode();
                }
            }
        }

        private void GetAllSpecialCode()
        {
            gridControlSpecialCodes.DataSource = _specialCodeService.GetAll().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SpecialCodeEditForm.SpecialCodeId = -1;
            CreateForms<SpecialCodeEditForm>.ShowDialogEditForm();
            GetAllSpecialCode();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SpecialCodeEditForm.SpecialCodeId = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<SpecialCodeEditForm>.ShowDialogEditForm();
            GetAllSpecialCode();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllSpecialCode();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlSpecialCodes.DataSource = _specialCodeService.GetAll().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlSpecialCodes.DataSource = _specialCodeService.GetAll().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void SpecialCodeListForm_Load(object sender, EventArgs e)
        {
            GetAllSpecialCode();
        }

        private void gridViewSpecialCodes_DoubleClick(object sender, EventArgs e)
        {
            SpecialCodeEditForm.SpecialCodeId = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<SpecialCodeEditForm>.ShowDialogEditForm();
            GetAllSpecialCode();
        }
    }
}