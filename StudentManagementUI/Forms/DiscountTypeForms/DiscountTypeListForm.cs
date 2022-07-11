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

namespace StudentManagementUI.Forms.DiscountTypeForms
{
    public partial class DiscountTypeListForm : BaseListForm
    {
        private readonly IDiscountTypeService _discountTypeService;
        public DiscountTypeListForm()
        {
            InitializeComponent();
            _discountTypeService = InstanceFactory.GetInstance<IDiscountTypeService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlDiscountTypes;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Discount Type");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _discountTypeService.Delete(new DiscountType
                {
                    Id = Convert.ToInt32(gridViewDiscountTypes.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllDiscountTypeActive();
                }
            }
        }

        private void GetAllDiscountTypeActive()
        {
            gridControlDiscountTypes.DataSource = _discountTypeService.GetDiscountTypeActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiscountTypeEditForm.DiscountTypeId = -1;
            CreateForms<DiscountTypeEditForm>.ShowDialogEditForm();
            GetAllDiscountTypeActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiscountTypeEditForm.DiscountTypeId = Convert.ToInt32(gridViewDiscountTypes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<DiscountTypeEditForm>.ShowDialogEditForm();
            GetAllDiscountTypeActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllDiscountTypeActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlDiscountTypes.DataSource = _discountTypeService.GetDiscountTypeActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlDiscountTypes.DataSource = _discountTypeService.GetDiscountTypePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void DiscountTypeListForm_Load(object sender, EventArgs e)
        {
            GetAllDiscountTypeActive();
        }

        private void gridViewDiscountTypes_DoubleClick(object sender, EventArgs e)
        {
            DiscountTypeEditForm.DiscountTypeId = Convert.ToInt32(gridViewDiscountTypes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<DiscountTypeEditForm>.ShowDialogEditForm();
            GetAllDiscountTypeActive();
        }
    }
}