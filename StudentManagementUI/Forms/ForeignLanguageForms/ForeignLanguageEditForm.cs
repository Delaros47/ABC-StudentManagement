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

namespace StudentManagementUI.Forms.ForeignLanguageForms
{
    public partial class ForeignLanguageEditForm : BaseEditForm
    {
        public static int ForeignLanguageId = -1;
        private readonly IForeignLanguageService _foreignLanguageService;
        public ForeignLanguageEditForm()
        {
            InitializeComponent();
            _foreignLanguageService = InstanceFactory.GetInstance<IForeignLanguageService>();
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
            string privateCode = _foreignLanguageService.GetLastforeignLanguagePrivateCode().Data.PrivateCode;
            layoutControlItem1.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _foreignLanguageService.Add(new ForeignLanguage
            {
                PrivateCode = layoutControlItem1.Text,
                ForeignLanguageName = txtForeignLanguage.Text,
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
            var result = _foreignLanguageService.Update(new ForeignLanguage
            {
                Id = ForeignLanguageId,
                PrivateCode = layoutControlItem1.Text,
                ForeignLanguageName = txtForeignLanguage.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }


        private void ForeignLanguageEditForm_Load(object sender, EventArgs e)
        {
            if (ForeignLanguageId != -1)
            {
                var result = _foreignLanguageService.Get(ForeignLanguageId);
                if (result.Success)
                {
                    layoutControlItem1.Text = result.Data.PrivateCode;
                    txtForeignLanguage.Text = result.Data.ForeignLanguageName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }

        private void txtForeignLanguage_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtForeignLanguage.StatusBarDescription;
        }

        private void txtForeignLanguage_Leave(object sender, EventArgs e)
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

        private void txtPrivateCode_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtPrivateCode.StatusBarDescription;
        }

        private void txtPrivateCode_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }
    }
}