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

namespace StudentManagementUI.Forms.BankForms
{
    public partial class BankListForm : BaseListForm
    {
        private readonly IBankService _bankService;
        public BankListForm()
        {
            InitializeComponent();
            _bankService = InstanceFactory.GetInstance<IBankService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Bank");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _bankService.Delete(new Bank
                {
                    Id = Convert.ToInt32(bandedGridViewBanks.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllBankActiveDetailDto();
                }
            }
        }

        private void GetAllBankActiveDetailDto()
        {
            bandedGridControlBanks.DataSource = _bankService.GetBankDetailActiveDto().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            BankEditForm.BankId = -1;
            CreateForms<BankEditForm>.ShowDialogEditForm();
            GetAllBankActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            BankEditForm.BankId = Convert.ToInt32(bandedGridViewBanks.GetFocusedRowCellValue("Id").ToString());
            CreateForms<BankEditForm>.ShowDialogEditForm();
            GetAllBankActiveDetailDto();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllBankActiveDetailDto();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlBanks.DataSource = _bankService.GetBankDetailActiveDto().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlBanks.DataSource = _bankService.GetBankDetailPassiveDto().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void BankListForm_Load(object sender, EventArgs e)
        {
            GetAllBankActiveDetailDto();
        }

        private void bandedGridViewBanks_DoubleClick(object sender, EventArgs e)
        {
            BankEditForm.BankId = Convert.ToInt32(bandedGridViewBanks.GetFocusedRowCellValue("Id").ToString());
            CreateForms<BankEditForm>.ShowDialogEditForm();
            GetAllBankActiveDetailDto();
        }
    }
}