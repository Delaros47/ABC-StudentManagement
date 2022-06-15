using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.ServiceForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.ServiceTypeForms
{
    public partial class ServiceTypeListForm : BaseListForm
    {
        private readonly IServiceTypeService _serviceTypeService;
        public ServiceTypeListForm()
        {
            InitializeComponent();
            _serviceTypeService = InstanceFactory.GetInstance<IServiceTypeService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Service Type");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _serviceTypeService.Delete(new ServiceType
                {
                    Id = Convert.ToInt32(gridViewServiceTypes.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllServiceTypeActive();
                }
            }
        }

        private void GetAllServiceTypeActive()
        {
            gridControlServiceTypes.DataSource = _serviceTypeService.GetServiceTypeActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ServiceTypeEditForm.ServiceTypeId = -1;
            CreateForms<ServiceTypeEditForm>.ShowDialogEditForm();
            GetAllServiceTypeActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ServiceTypeEditForm.ServiceTypeId = Convert.ToInt32(gridViewServiceTypes.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ServiceTypeEditForm>.ShowDialogEditForm();
            GetAllServiceTypeActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllServiceTypeActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlServiceTypes.DataSource = _serviceTypeService.GetServiceTypeActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlServiceTypes.DataSource = _serviceTypeService.GetServiceTypePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void ServiceTypeListForm_Load(object sender, EventArgs e)
        {
            GetAllServiceTypeActive();
        }

        private void gridViewServiceTypes_DoubleClick(object sender, EventArgs e)
        {
            if (ServiceEditForm.FormControl)
            {
                ServiceEditForm.FormControl = false;
                ServiceEditForm.ServiceTypeId = Convert.ToInt32(gridViewServiceTypes.GetFocusedRowCellValue("Id").ToString());
                this.Close();
            }
            else
            {
                ServiceTypeEditForm.ServiceTypeId = Convert.ToInt32(gridViewServiceTypes.GetFocusedRowCellValue("Id").ToString());
                CreateForms<ServiceTypeEditForm>.ShowDialogEditForm();
                GetAllServiceTypeActive();
            }
            
        }
    }
}