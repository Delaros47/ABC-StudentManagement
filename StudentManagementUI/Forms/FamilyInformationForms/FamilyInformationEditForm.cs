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

namespace StudentManagementUI.Forms.FamilyInformationForms
{
    public partial class FamilyInformationEditForm : BaseEditForm
    {
        public static int FamilyInformationId = -1;
        private readonly IFamilyInformationService _familyInformationService;
        public FamilyInformationEditForm()
        {
            InitializeComponent();
            _familyInformationService = InstanceFactory.GetInstance<IFamilyInformationService>();
        }

        private void FamilyInformationEditForm_Load(object sender, EventArgs e)
        {
            if (FamilyInformationId != -1)
            {
                var result = _familyInformationService.Get(FamilyInformationId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtInformationName.Text = result.Data.InformationName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
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
            string privateCode = _familyInformationService.GetLastFamilyInformationPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _familyInformationService.Add(new FamilyInformation
            {
                PrivateCode = txtPrivateCode.Text,
                InformationName = txtInformationName.Text,
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
            var result = _familyInformationService.Update(new FamilyInformation
            {
                Id = FamilyInformationId,
                PrivateCode = txtPrivateCode.Text,
                InformationName = txtInformationName.Text,
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

        private void txtInformationName_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtInformationName.StatusBarDescription;
        }

        private void txtInformationName_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtDescription.StatusBarDescription;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void tglState_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void tglState_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = tglState.StatusBarDescription;
        }
    }
}