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

namespace StudentManagementUI.Forms.GuidanceCounselorForms
{
    public partial class GuidanceCounselorEditForm : BaseEditForm
    {
        public static int GuidanceCounselorId = -1;
        private readonly IGuidanceCounselorService _guidanceCounselorService;
        public GuidanceCounselorEditForm()
        {
            InitializeComponent();
            _guidanceCounselorService = InstanceFactory.GetInstance<IGuidanceCounselorService>();
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
            string privateCode = _guidanceCounselorService.GetLastGuidanceCounselorPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _guidanceCounselorService.Add(new GuidanceCounselor
            {
                PrivateCode = txtPrivateCode.Text,
                NameSurname = txtNameSurname.Text,
                Phone1 = txtPhone1.Text,
                Phone2 = txtPhone2.Text,
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
            var result = _guidanceCounselorService.Update(new GuidanceCounselor
            {
                Id = GuidanceCounselorId,
                PrivateCode = txtPrivateCode.Text,
                NameSurname = txtNameSurname.Text,
                Phone1 = txtPhone1.Text,
                Phone2 = txtPhone2.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void GuidanceCounselorEditForm_Load(object sender, EventArgs e)
        {
            if (GuidanceCounselorId != -1)
            {
                var result = _guidanceCounselorService.Get(GuidanceCounselorId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtNameSurname.Text = result.Data.NameSurname;
                    txtPhone1.Text = result.Data.Phone1;
                    txtPhone2.Text = result.Data.Phone2;
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

        private void txtNameSurname_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtNameSurname.StatusBarDescription;
        }

        private void txtNameSurname_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtPhone1_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtPhone1.StatusBarDescription;
        }

        private void txtPhone1_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtPhone2_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtPhone2.StatusBarDescription;
        }

        private void txtPhone2_Leave(object sender, EventArgs e)
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
    }
}