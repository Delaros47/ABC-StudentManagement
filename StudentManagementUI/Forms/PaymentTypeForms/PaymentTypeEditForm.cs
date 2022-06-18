using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entities.Enums;
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
    public partial class PaymentTypeEditForm : BaseEditForm
    {
        public static int PaymentTypeId = -1;
        private readonly IPaymentTypeService _paymentTypeService;
        public PaymentTypeEditForm()
        {
            InitializeComponent();
            _paymentTypeService = InstanceFactory.GetInstance<IPaymentTypeService>();
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            CleanAllComponants();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            GeneratePrivateCode();
        }

        private void GeneratePrivateCode()
        {
            CleanAllComponants();
            string privateCode = _paymentTypeService.GetLastPaymentTypePrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _paymentTypeService.Add(new PaymentType
            {
                PrivateCode = txtPrivateCode.Text,
                PaymentTypeName = txtPaymentTypeName.Text,
                PaymentTypee = cbxPaymentType.SelectedItem.ToString(),
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _paymentTypeService.Update(new PaymentType
            {
                Id = PaymentTypeId,
                PrivateCode = txtPrivateCode.Text,
                PaymentTypeName = txtPaymentTypeName.Text,
                PaymentTypee = cbxPaymentType.SelectedItem.ToString(),
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void PaymentTypeEditForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(PaymentTypeEnum)))
            {
                cbxPaymentType.Properties.Items.Add(item);
            }
            
            if (PaymentTypeId != -1)
            {
                var result = _paymentTypeService.Get(PaymentTypeId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtPaymentTypeName.Text = result.Data.PaymentTypeName;
                    cbxPaymentType.SelectedItem = result.Data.PaymentTypee;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }
    }
}