using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.ServiceTypeForms;
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
    public partial class ServiceEditForm : BaseEditForm
    {
        public static int ServiceId = -1;
        public static int ServiceTypeId = -1;
        public static bool FormControl = false;
        private readonly IServiceService _serviceService;
        private readonly IServiceTypeService _serviceTypeService;
        public ServiceEditForm()
        {
            InitializeComponent();
            _serviceService = InstanceFactory.GetInstance<IServiceService>();
            _serviceTypeService = InstanceFactory.GetInstance<IServiceTypeService>();
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
            string privateCode = _serviceService.GetLastServicePrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _serviceService.Add(new Service
            {
                PrivateCode = txtPrivateCode.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                ServiceName = txtServiceName.Text,
                StartDate = Convert.ToDateTime(txtStartDate.Text),
                EndDate = Convert.ToDateTime(txtEndDate.Text),
                State = tglState.IsOn,
                Description = txtDescription.Text,
                ServiceTypeId = ServiceTypeId
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _serviceService.Update(new Service
            {
                Id = ServiceId,
                PrivateCode = txtPrivateCode.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                State = tglState.IsOn,
                Description = txtDescription.Text,
                ServiceName = txtServiceName.Text,
                StartDate = Convert.ToDateTime(txtStartDate.Text),
                EndDate = Convert.ToDateTime(txtEndDate.Text),
                ServiceTypeId = ServiceTypeId
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void ServiceEditForm_Load(object sender, EventArgs e)
        {
            if (ServiceId != -1)
            {
                var result = _serviceService.Get(ServiceId);
                var serviceType = _serviceTypeService.Get(result.Data.ServiceTypeId);
                ServiceTypeId = serviceType.Data.Id;
                if (result.Success && serviceType.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtEndDate.Text = result.Data.EndDate.ToShortDateString();
                    txtStartDate.Text = result.Data.StartDate.ToShortDateString();
                    txtPrice.Text = result.Data.Price.ToString();
                    txtServiceName.Text = result.Data.ServiceName;
                    btnServiceType.Text = serviceType.Data.ServiceTypeName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }

        private void btnServiceType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormControl = true;
            CreateForms<ServiceTypeListForm>.ShowDialogListFormWithoutParent();
            btnServiceType.Text = _serviceTypeService.Get(ServiceTypeId).Data.ServiceTypeName;
        }

        private void txtServiceName_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtServiceName.StatusBarDescription;
        }

        private void txtServiceName_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void btnServiceType_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = btnServiceType.StatusBarDescription;
            statusBarShortcut.Caption = btnServiceType.StatusBarShortcut;
            statusBarShortcutDescription.Caption = btnServiceType.StatusBarShortcutDescription;
        }

        private void btnServiceType_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
            statusBarShortcut.Caption = "";
            statusBarShortcutDescription.Caption = "";
        }
    }
}