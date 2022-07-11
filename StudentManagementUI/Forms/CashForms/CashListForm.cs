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

namespace StudentManagementUI.Forms.CashForms
{
    public partial class CashListForm : BaseListForm
    {
        private readonly ICashService _cashService;
        public CashListForm()
        {
            InitializeComponent();
            _cashService = InstanceFactory.GetInstance<ICashService>();
            longNavigator.controlNavigator.NavigatableControl = bandedGridControlCashes;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Cash");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _cashService.Delete(new Cash
                {
                    Id = Convert.ToInt32(bandedGridViewlCashes.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllCashActive();
                }
            }
        }

        private void GetAllCashActive()
        {
            bandedGridControlCashes.DataSource = _cashService.GetCashDetailDto().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CashEditForm.CashId = -1;
            CreateForms<CashEditForm>.ShowDialogEditForm();
            GetAllCashActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            CashEditForm.CashId = Convert.ToInt32(bandedGridViewlCashes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<CashEditForm>.ShowDialogEditForm();
            GetAllCashActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllCashActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlCashes.DataSource = _cashService.GetCashDetailDto().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlCashes.DataSource = _cashService.GetCashDetailDto().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void bandedGridViewlCashes_DoubleClick(object sender, EventArgs e)
        {
            CashEditForm.CashId = Convert.ToInt32(bandedGridViewlCashes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<CashEditForm>.ShowDialogEditForm();
            GetAllCashActive();
        }

        private void CashListForm_Load(object sender, EventArgs e)
        {
           
            GetAllCashActive();
        }
    }
}