using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.CashForms;
using StudentManagementUI.Forms.GeneralForms;
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
        public static bool SpecialCode1 = false;
        public static bool SpecialCode2 = false;
        public static bool SpecialCode3 = false;
        public static bool SpecialCode4 = false;
        public static bool SpecialCode5 = false;
        private readonly ISpecialCodeService _specialCodeService;
        public SpecialCodeListForm()
        {
            InitializeComponent();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
            btnActivePassiveList.Visibility = BarItemVisibility.Never;
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



        private void SpecialCodeListForm_Load(object sender, EventArgs e)
        {
            GetAllSpecialCode();
        }

        private void gridViewSpecialCodes_DoubleClick(object sender, EventArgs e)
        {
            if (SpecialCode1)
            {
                MainForm.SpecialCode1 = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
                SpecialCodeListForm.SpecialCode1 = false;
                this.Close();
            }
            else if (SpecialCode2)
            {
                MainForm.SpecialCode2 = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
                SpecialCodeListForm.SpecialCode2 = false;
                this.Close();
            }
            else if (SpecialCode3)
            {
                MainForm.SpecialCode3 = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
                SpecialCodeListForm.SpecialCode3 = false;
                this.Close();
            }
            else if (SpecialCode4)
            {
                MainForm.SpecialCode4 = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
                SpecialCodeListForm.SpecialCode4 = false;
                this.Close();
            }
            else if (SpecialCode5)
            {
                MainForm.SpecialCode5 = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
                SpecialCodeListForm.SpecialCode5 = false;
                this.Close();
            }
            else
            {
                SpecialCodeEditForm.SpecialCodeId = Convert.ToInt32(gridViewSpecialCodes.GetFocusedRowCellValue("Id").ToString());
                CreateForms<SpecialCodeEditForm>.ShowDialogEditForm();
                GetAllSpecialCode();
            }

        }
    }
}