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

namespace StudentManagementUI.Forms.CancelReasonForms
{
    public partial class CancelReasonEditForm : BaseEditForm
    {
        public static int CancelReasonId = -1;
        private readonly ICancelReasonService _cancelReasonService;
        public CancelReasonEditForm()
        {
            InitializeComponent();
            _cancelReasonService = InstanceFactory.GetInstance<ICancelReasonService> ();
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
            string privateCode = _cancelReasonService.GetLastCancelReasonPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _cancelReasonService.Add(new CancelReason
            {
                PrivateCode = txtPrivateCode.Text,
                CancelReasonName = txtCancelReasonName.Text,
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
            var result = _cancelReasonService.Update(new CancelReason
            {
                Id = CancelReasonId,
                PrivateCode = txtPrivateCode.Text,
                CancelReasonName = txtCancelReasonName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void CancelReasonEditForm_Load(object sender, EventArgs e)
        {
            if (CancelReasonId != -1)
            {
                var result = _cancelReasonService.Get(CancelReasonId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtCancelReasonName.Text = result.Data.CancelReasonName;
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