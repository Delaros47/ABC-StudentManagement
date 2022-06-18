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

namespace StudentManagementUI.Forms.PaymentTypeForms
{
    public partial class PaymentTypeListForm : BaseListForm
    {
        private readonly IPaymentTypeService _paymentTypeService;
        public PaymentTypeListForm()
        {
            InitializeComponent();
            _paymentTypeService = InstanceFactory.GetInstance<IPaymentTypeService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Payment Type");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _paymentTypeService.Delete(new PaymentType
                {
                    Id = Convert.ToInt32(gridViewPaymentTypes.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllPaymentTypeActive();
                }
            }
        }

        private void GetAllPaymentTypeActive()
        {
            gridControlPayments.DataSource = _paymentTypeService.GetPaymentTypeActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            PaymentTypeEditForm.PaymentTypeId = -1;
            CreateForms<PaymentTypeEditForm>.ShowDialogEditForm();
            GetAllPaymentTypeActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            PaymentTypeEditForm.PaymentTypeId = Convert.ToInt32(gridViewPaymentTypes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<PaymentTypeEditForm>.ShowDialogEditForm();
            GetAllPaymentTypeActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllPaymentTypeActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlPayments.DataSource = _paymentTypeService.GetPaymentTypeActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlPayments.DataSource = _paymentTypeService.GetPaymentTypePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void gridViewPaymentTypes_DoubleClick(object sender, EventArgs e)
        {
            PaymentTypeEditForm.PaymentTypeId = Convert.ToInt32(gridViewPaymentTypes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<PaymentTypeEditForm>.ShowDialogEditForm();
            GetAllPaymentTypeActive();
        }

        private void PaymentTypeListForm_Load(object sender, EventArgs e)
        {
            GetAllPaymentTypeActive();
        }
    }
}