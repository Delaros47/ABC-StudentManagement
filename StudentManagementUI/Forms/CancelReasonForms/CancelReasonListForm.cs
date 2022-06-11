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
    public partial class CancelReasonListForm : BaseListForm
    {
        private readonly ICancelReasonService _cancelReasonService;
        public CancelReasonListForm()
        {
            InitializeComponent();
            _cancelReasonService = InstanceFactory.GetInstance<ICancelReasonService>();
        }

        private void CancelReasonListForm_Load(object sender, EventArgs e)
        {
            GetAllCancelReasonActive();
        }

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Cancel Reason");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _cancelReasonService.Delete(new CancelReason
                {
                    Id = Convert.ToInt32(gridViewCancelReason.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllCancelReasonActive();
                }
            }
        }

        private void GetAllCancelReasonActive()
        {
            gridControlCancelReason.DataSource = _cancelReasonService.GetCancelReasonActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForms<CancelReasonEditForm>.ShowDialogEditForm();
            GetAllCancelReasonActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            CancelReasonEditForm.CancelReasonId = Convert.ToInt32(gridViewCancelReason.GetFocusedRowCellValue("Id").ToString());
            CreateForms<CancelReasonEditForm>.ShowDialogEditForm();
            GetAllCancelReasonActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllCancelReasonActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlCancelReason.DataSource = _cancelReasonService.GetCancelReasonActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlCancelReason.DataSource = _cancelReasonService.GetCancelReasonPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void gridViewCancelReason_DoubleClick(object sender, EventArgs e)
        {
            CancelReasonEditForm.CancelReasonId = Convert.ToInt32(gridViewCancelReason.GetFocusedRowCellValue("Id").ToString());
            CreateForms<CancelReasonEditForm>.ShowDialogEditForm();
            GetAllCancelReasonActive();
        }
    }
}