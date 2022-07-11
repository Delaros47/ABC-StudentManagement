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

namespace StudentManagementUI.Forms.QuotaForms
{
    public partial class QuotaListForm : BaseListForm
    {
        private readonly IQuotaService _quotaService;
        public QuotaListForm()
        {
            InitializeComponent();
            _quotaService = InstanceFactory.GetInstance<IQuotaService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlQuotas;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Quota");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _quotaService.Delete(new Quota
                {
                    Id = Convert.ToInt32(gridViewQuotas.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllQuotaActive();
                }
            }
        }

        private void GetAllQuotaActive()
        {
            gridControlQuotas.DataSource = _quotaService.GetQuotaActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuotaEditForm.QuotaId = -1;
            CreateForms<QuotaEditForm>.ShowDialogEditForm();
            GetAllQuotaActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuotaEditForm.QuotaId = Convert.ToInt32(gridViewQuotas.GetFocusedRowCellValue("Id").ToString());
            CreateForms<QuotaEditForm>.ShowDialogEditForm();
            GetAllQuotaActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllQuotaActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlQuotas.DataSource = _quotaService.GetQuotaActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlQuotas.DataSource = _quotaService.GetQuotaPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void QuotaListForm_Load(object sender, EventArgs e)
        {
            GetAllQuotaActive();
        }

        private void gridViewQuotas_DoubleClick(object sender, EventArgs e)
        {
            QuotaEditForm.QuotaId = Convert.ToInt32(gridViewQuotas.GetFocusedRowCellValue("Id").ToString());
            CreateForms<QuotaEditForm>.ShowDialogEditForm();
            GetAllQuotaActive();
        }
    }
}