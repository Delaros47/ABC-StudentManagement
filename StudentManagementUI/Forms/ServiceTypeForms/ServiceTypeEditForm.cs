using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entities.Enums;
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

namespace StudentManagementUI.Forms.ServiceTypeForms
{
    public partial class ServiceTypeEditForm : BaseEditForm
    {
        public static int ServiceTypeId = -1;
        private readonly IServiceTypeService _serviceTypeService;
        public ServiceTypeEditForm()
        {
            InitializeComponent();
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
            string privateCode = _serviceTypeService.GetLastServiceTypePrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _serviceTypeService.Add(new ServiceType
            {
                PrivateCode = txtPrivateCode.Text,
                ServiceTypee = cbxServiceType.SelectedItem.ToString(),
                ServiceTypeName = txtServiceTypeName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            }) ;
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _serviceTypeService.Update(new ServiceType
            {
                Id = ServiceTypeId,
                PrivateCode = txtPrivateCode.Text,
                ServiceTypee = cbxServiceType.SelectedItem.ToString(),
                ServiceTypeName = txtServiceTypeName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            }) ;
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void ServiceTypeEditForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(ServiceTypeEnum)))
            {
                cbxServiceType.Properties.Items.Add(item);
            }
            if (ServiceTypeId != -1)
            {
                var result = _serviceTypeService.Get(ServiceTypeId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtServiceTypeName.Text = result.Data.ServiceTypeName;
                    cbxServiceType.SelectedItem = result.Data.ServiceTypee;
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