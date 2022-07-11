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

namespace StudentManagementUI.Forms.CustomerForms
{
    public partial class CustomerListForm : BaseListForm
    {
        private readonly ICustomerService _customerService;
        public CustomerListForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            longNavigator.controlNavigator.NavigatableControl = bandedGridControlCustomers;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Customer");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _customerService.Delete(new Customer
                {
                    Id = Convert.ToInt32(bandedGridViewCustomers.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllCustomerActiveDetailDto();
                }
            }
        }

        private void GetAllCustomerActiveDetailDto()
        {
            bandedGridControlCustomers.DataSource = _customerService.GetCustomerDetailActiveDto().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerEditForm.CustomerId = -1;
            CreateForms<CustomerEditForm>.ShowDialogEditForm();
            GetAllCustomerActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerEditForm.CustomerId = Convert.ToInt32(bandedGridViewCustomers.GetFocusedRowCellValue("Id").ToString());
            CreateForms<CustomerEditForm>.ShowDialogEditForm();
            GetAllCustomerActiveDetailDto();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllCustomerActiveDetailDto();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlCustomers.DataSource = _customerService.GetCustomerDetailActiveDto().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlCustomers.DataSource = _customerService.GetCustomerDetailPassiveDto().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            GetAllCustomerActiveDetailDto();
        }

        private void bandedGridViewCustomers_DoubleClick(object sender, EventArgs e)
        {
            CustomerEditForm.CustomerId = Convert.ToInt32(bandedGridViewCustomers.GetFocusedRowCellValue("Id").ToString());
            CreateForms<CustomerEditForm>.ShowDialogEditForm();
            GetAllCustomerActiveDetailDto();
        }
    }
}