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

namespace StudentManagementUI.Forms.ServiceForms
{
    public partial class ServiceListForm : BaseListForm
    {
        private readonly IServiceService _serviceService;
        public ServiceListForm()
        {
            InitializeComponent();
            _serviceService = InstanceFactory.GetInstance<IServiceService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Service");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _serviceService.Delete(new Service
                {
                    Id = Convert.ToInt32(gridViewServices.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllServiceActive();
                }
            }
        }

        private void GetAllServiceActive()
        {
            gridControlServices.DataSource = _serviceService.GetActiveServiceDetailDto().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ServiceEditForm.ServiceId = -1;
            CreateForms<ServiceEditForm>.ShowDialogEditForm();
            GetAllServiceActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ServiceEditForm.ServiceId = Convert.ToInt32(gridViewServices.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ServiceEditForm>.ShowDialogEditForm();
            GetAllServiceActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllServiceActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlServices.DataSource = _serviceService.GetActiveServiceDetailDto().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlServices.DataSource = _serviceService.GetPassiveServiceDetailDto().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void ServiceListForm_Load(object sender, EventArgs e)
        {
            GetAllServiceActive();
        }

        private void gridViewServices_DoubleClick(object sender, EventArgs e)
        {
            ServiceEditForm.ServiceId = Convert.ToInt32(gridViewServices.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ServiceEditForm>.ShowDialogEditForm();
            GetAllServiceActive();
        }
    }
}