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

namespace StudentManagementUI.Forms.BankAccountForms
{
    public partial class BankAccountListForm : BaseListForm
    {
        private readonly IBankAccountService _bankAccountService;
        public BankAccountListForm()
        {
            InitializeComponent();
            _bankAccountService = InstanceFactory.GetInstance<IBankAccountService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Bank Account");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _bankAccountService.Delete(new BankAccount
                {
                    Id = Convert.ToInt32(bandedGridViewBankAccounts.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllBankAccountActiveDetailDto();
                }
            }
        }

        private void GetAllBankAccountActiveDetailDto()
        {
            bandedGridControlBankAccounts.DataSource = _bankAccountService.GetBankAccountDetailDtoActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            BankAccountEditForm.BankAccountId = -1;
            CreateForms<BankAccountEditForm>.ShowDialogEditForm();
            GetAllBankAccountActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            BankAccountEditForm.BankAccountId = Convert.ToInt32(bandedGridViewBankAccounts.GetFocusedRowCellValue("Id").ToString());
            CreateForms<BankAccountEditForm>.ShowDialogEditForm();
            GetAllBankAccountActiveDetailDto();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllBankAccountActiveDetailDto();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlBankAccounts.DataSource = _bankAccountService.GetBankAccountDetailDtoActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlBankAccounts.DataSource = _bankAccountService.GetBankAccountDetailDtoPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void BankAccountListForm_Load(object sender, EventArgs e)
        {
            GetAllBankAccountActiveDetailDto();
        }

        private void bandedGridViewBankAccounts_DoubleClick(object sender, EventArgs e)
        {
            BankAccountEditForm.BankAccountId = Convert.ToInt32(bandedGridViewBankAccounts.GetFocusedRowCellValue("Id").ToString());
            CreateForms<BankAccountEditForm>.ShowDialogEditForm();
            GetAllBankAccountActiveDetailDto();
        }
    }
}