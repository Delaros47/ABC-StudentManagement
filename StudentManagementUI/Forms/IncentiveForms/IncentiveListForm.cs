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

namespace StudentManagementUI.Forms.IncentiveForms
{
    public partial class IncentiveListForm : BaseListForm
    {
        private readonly IIncentiveService _incentiveService;
        public IncentiveListForm()
        {
            InitializeComponent();
            _incentiveService = InstanceFactory.GetInstance<IIncentiveService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlIncentiveList;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Incentive");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _incentiveService.Delete(new Incentive
                {
                    Id = Convert.ToInt32(gridViewIncentiveList.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllIncentiveActive();
                }
            }
        }

        private void GetAllIncentiveActive()
        {
            gridControlIncentiveList.DataSource = _incentiveService.GetIncentiveActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            IncentiveEditForm.IncentiveId = -1;
            CreateForms<IncentiveEditForm>.ShowDialogEditForm();
            GetAllIncentiveActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            IncentiveEditForm.IncentiveId = Convert.ToInt32(gridViewIncentiveList.GetFocusedRowCellValue("Id").ToString());
            CreateForms<IncentiveEditForm>.ShowDialogEditForm();
            GetAllIncentiveActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllIncentiveActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlIncentiveList.DataSource = _incentiveService.GetIncentiveActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlIncentiveList.DataSource = _incentiveService.GetIncentivePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void IncentiveListForm_Load(object sender, EventArgs e)
        {
            GetAllIncentiveActive();
        }

        private void gridViewIncentiveList_DoubleClick(object sender, EventArgs e)
        {
            IncentiveEditForm.IncentiveId = Convert.ToInt32(gridViewIncentiveList.GetFocusedRowCellValue("Id").ToString());
            CreateForms<IncentiveEditForm>.ShowDialogEditForm();
            GetAllIncentiveActive();
        }
    }
}