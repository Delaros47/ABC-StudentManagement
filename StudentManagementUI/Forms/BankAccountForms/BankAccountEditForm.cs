using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BankForms;
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

namespace StudentManagementUI.Forms.BankAccountForms
{
    public partial class BankAccountEditForm : BaseEditForm
    {
        public static int BankAccountId = -1;
        public static int BankId = -1;
        public static int SpecialCode1 = -1;
        public static int SpecialCode2 = -1;
        public static bool FormControl = false;
        private readonly IBankAccountService _bankAccountService;
        private readonly ISpecialCodeService _specialCodeService;
        private readonly IBankService _bankService;
        public BankAccountEditForm()
        {
            InitializeComponent();
            _bankAccountService = InstanceFactory.GetInstance<IBankAccountService>();
            _bankService = InstanceFactory.GetInstance<IBankService>();
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
            //GeneratePrivateCode();
        }

        private void GeneratePrivateCode()
        {
            CleanAllComponants();
            string privateCode = _bankAccountService.GetLastBankAccountPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);



        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _bankAccountService.Add(new BankAccount
            {
                PrivateCode = txtPrivateCode.Text,
                AccountName = txtAccountName.Text,
                AccountNumber = txtAccountNumber.Text,
                AccountOpeningDate = Convert.ToDateTime(txtAccountOpeningDate.Text),
                AccountType = cbxAccountType.SelectedItem.ToString(),
                WorkPlaceNumber = txtWorkPlaceNumber.Text,
                BlockedDayNumber = Convert.ToInt32(txtBlockedDayNumber.Text),
                BankId = BankId,
                BankBranch = txtBankBranch.Text,
                IbanNumber = txtIBANNumber.Text,
                TerminalNumber = txtTerminalNumber.Text,
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
            var result = _bankAccountService.Update(new BankAccount
            {
                Id = BankAccountId,
                PrivateCode = txtPrivateCode.Text,
                AccountName = txtAccountName.Text,
                AccountNumber = txtAccountNumber.Text,
                AccountOpeningDate = Convert.ToDateTime(txtAccountOpeningDate.Text),
                AccountType = cbxAccountType.SelectedItem.ToString(),
                WorkPlaceNumber = txtWorkPlaceNumber.Text,
                BlockedDayNumber = Convert.ToInt32(txtBlockedDayNumber.Text),
                BankId = BankId,
                BankBranch = txtBankBranch.Text,
                IbanNumber = txtIBANNumber.Text,
                TerminalNumber = txtTerminalNumber.Text,
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

        private void BankAccountEditForm_Load(object sender, EventArgs e)
        {
            if (BankAccountId != -1)
            {
                var result = _bankAccountService.Get(BankAccountId);
                var special1 = _specialCodeService.Get(result.Data.SpecialCode1);
                var special2 = _specialCodeService.Get(result.Data.SpecialCode2);
                var bankName = _bankService.Get(result.Data.BankId);
                SpecialCode1 = special1.Data.Id;
                SpecialCode2 = special2.Data.Id;
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtAccountName.Text = result.Data.AccountName;
                    txtAccountNumber.Text = result.Data.AccountNumber;
                    txtAccountOpeningDate.Text = result.Data.AccountOpeningDate.ToShortDateString();
                    txtBankBranch.Text = result.Data.BankBranch;
                    txtBlockedDayNumber.Text = result.Data.BlockedDayNumber.ToString();
                    txtIBANNumber.Text = result.Data.IbanNumber;
                    cbxAccountType.SelectedItem = result.Data.AccountType;
                    txtTerminalNumber.Text = result.Data.TerminalNumber;
                    txtWorkPlaceNumber.Text = result.Data.WorkPlaceNumber;
                    btnBank.Text = bankName.Data.BankName;
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

        private void btnBank_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<BankListForm>.ShowDialogListFormWithoutParent();
            btnBank.Text = _bankService.Get(BankId).Data.BankName;
        }
    }
}