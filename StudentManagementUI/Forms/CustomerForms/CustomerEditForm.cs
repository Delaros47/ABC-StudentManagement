using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.GeneralForms;
using StudentManagementUI.Forms.SpecialCodeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.CustomerForms
{
    public partial class CustomerEditForm : BaseEditForm
    {
        public static int CustomerId = -1;
        public static int SpecialCode1 = -1;
        public static int SpecialCode2 = -1;
        private readonly ICustomerService _customerService;
        private readonly ISpecialCodeService _specialCodeService;
        public CustomerEditForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
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
            string privateCode = _customerService.GetLastBankPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _customerService.Add(new Customer
            {
                PrivateCode = txtPrivateCode.Text,
                CustomerName = txtCustomerNameSurname.Text,
                Address = txtAddress.Text,
                Email = txtEmailAddress.Text,
                Fax = txtFaxNumber.Text,
                IdentityNumber = txtIdentityNumber.Text,
                Phone1 = txtPhone1.Text,
                Phone2 = txtPhone2.Text,
                Phone3 = txtPhone3.Text,
                Phone4 = txtPhone4.Text,
                Web = txtWebAddress.Text,
                TaxNumber = txtTaxNumber.Text,
                TaxOffice = txtTaxOffice.Text,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
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
            var result = _customerService.Update(new Customer
            {
                Id = CustomerId,
                PrivateCode = txtPrivateCode.Text,
                CustomerName = txtCustomerNameSurname.Text,
                Address = txtAddress.Text,
                Email = txtEmailAddress.Text,
                Fax = txtFaxNumber.Text,
                IdentityNumber = txtIdentityNumber.Text,
                Phone1 = txtPhone1.Text,
                Phone2 = txtPhone2.Text,
                Phone3 = txtPhone3.Text,
                Phone4 = txtPhone4.Text,
                Web = txtWebAddress.Text,
                TaxNumber = txtTaxNumber.Text,
                TaxOffice = txtTaxOffice.Text,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            if (CustomerId != -1)
            {
                var result = _customerService.Get(CustomerId);
                var special1 = _specialCodeService.Get(result.Data.SpecialCode1);
                var special2 = _specialCodeService.Get(result.Data.SpecialCode2);
                SpecialCode1 = special1.Data.Id;
                SpecialCode2 = special2.Data.Id;
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtAddress.Text = result.Data.Address;
                    txtCustomerNameSurname.Text = result.Data.CustomerName;
                    txtEmailAddress.Text = result.Data.Email;
                    txtFaxNumber.Text = result.Data.Fax;
                    txtIdentityNumber.Text = result.Data.IdentityNumber;
                    txtPhone1.Text = result.Data.Phone1;
                    txtPhone2.Text = result.Data.Phone2;
                    txtPhone3.Text = result.Data.Phone3;
                    txtPhone4.Text = result.Data.Phone4;
                    txtTaxNumber.Text = result.Data.TaxNumber;
                    txtTaxOffice.Text = result.Data.TaxOffice;
                    txtWebAddress.Text = result.Data.Web;
                    btnSpecialCode1.Text = special1.Data.SpecialCodeName;
                    btnSpecialCode2.Text = special2.Data.SpecialCodeName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }

        private void btnSpecialCode1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode1 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode1.Text = _specialCodeService.Get(MainForm.SpecialCode1).Data.SpecialCodeName;
        }

        private void btnSpecialCode2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode2 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode2.Text = _specialCodeService.Get(MainForm.SpecialCode2).Data.SpecialCodeName;
        }
    }
}