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

namespace StudentManagementUI.Forms.CashForms
{
    public partial class CashEditForm : BaseEditForm
    {
        public static int CashId = -1;
        public static int SpecialCode1 = -1;
        public static int SpecialCode2 = -1;
        private readonly ICashService _cashService;
        private readonly ISpecialCodeService _specialCodeService;
        public CashEditForm()
        {
            InitializeComponent();
            _cashService = InstanceFactory.GetInstance<ICashService>();
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
            string privateCode = _cashService.GetLastCashPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _cashService.Add(new Cash
            {
                PrivateCode = txtPrivateCode.Text,
                CashName = txtCashName.Text,
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
            var result = _cashService.Update(new Cash
            {
                Id = CashId,
                PrivateCode = txtPrivateCode.Text,
                CashName = txtCashName.Text,
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



        private void txtPrivateCode_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtPrivateCode.StatusBarDescription;
        }

        private void txtPrivateCode_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtCashName_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtCashName_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtCashName.StatusBarDescription;
        }

        private void btnSpecialCode1_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = btnSpecialCode1.StatusBarDescription;
            statusBarShortcut.Caption = btnSpecialCode1.StatusBarShortcut;
            statusBarShortcutDescription.Caption = btnSpecialCode1.StatusBarShortcutDescription;
        }

        private void btnSpecialCode1_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
            statusBarShortcut.Caption = "";
            statusBarShortcutDescription.Caption = "";
        }

        private void btnSpecialCode2_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
            statusBarShortcut.Caption = "";
            statusBarShortcutDescription.Caption = "";
        }

        private void btnSpecialCode2_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = btnSpecialCode2.StatusBarDescription;
            statusBarShortcut.Caption = btnSpecialCode2.StatusBarShortcut;
            statusBarShortcutDescription.Caption = btnSpecialCode2.StatusBarShortcutDescription;
        }

        private void txtDesciption_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtDesciption_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtDescription.StatusBarDescription;
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

        private void CashEditForm_Load(object sender, EventArgs e)
        {
            if (CashId != -1)
            {
                var result = _cashService.Get(CashId);
                var special1 = _specialCodeService.Get(result.Data.SpecialCode1);
                var special2 = _specialCodeService.Get(result.Data.SpecialCode2);
                SpecialCode1 = special1.Data.Id;
                SpecialCode2 = special2.Data.Id;
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtCashName.Text = result.Data.CashName;
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
    }
}