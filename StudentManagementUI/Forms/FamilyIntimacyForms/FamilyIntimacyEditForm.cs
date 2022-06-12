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

namespace StudentManagementUI.Forms.FamilyIntimacyForms
{
    public partial class FamilyIntimacyEditForm : BaseEditForm
    {
        public static int FamilyIntimacyId = -1;
        private readonly IFamilyIntimacyService _familyIntimacyService;
        public FamilyIntimacyEditForm()
        {
            InitializeComponent();
            _familyIntimacyService = InstanceFactory.GetInstance<IFamilyIntimacyService>();
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
            string privateCode = _familyIntimacyService.GetLastFamilyIntimacyPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _familyIntimacyService.Add(new FamilyIntimacy
            {
                PrivateCode = txtPrivateCode.Text,
                FamilyIntimacyName = txtFamilyIntimacy.Text, 
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
            var result = _familyIntimacyService.Update(new FamilyIntimacy
            {
                Id = FamilyIntimacyId,
                PrivateCode = txtPrivateCode.Text,
                FamilyIntimacyName = txtFamilyIntimacy.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void FamilyIntimacyEditForm_Load(object sender, EventArgs e)
        {
            if (FamilyIntimacyId != -1)
            {
                var result = _familyIntimacyService.Get(FamilyIntimacyId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtFamilyIntimacy.Text = result.Data.FamilyIntimacyName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
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

        private void txtFamilyIntimacy_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtFamilyIntimacy_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtFamilyIntimacy.StatusBarDescription;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtDescription.StatusBarDescription;
        }
    }
}