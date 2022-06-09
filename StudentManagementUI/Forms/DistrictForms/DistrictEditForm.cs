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

namespace StudentManagementUI.Forms.DistrictForms
{
    public partial class DistrictEditForm : BaseEditForm
    {
        public static int CityId = -1;
        public static int DistrictId = -1;
        private readonly IDistrictService _districtService;
        public DistrictEditForm()
        {
            InitializeComponent();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
           
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _districtService.Add(new District
            {
                PrivateCode = txtPrivateCode.Text,
                DistrictName = txtDistrictName.Text,
                Description = txtDescription.Text,
                State = tglState.IsOn,
                CityId = CityId
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _districtService.Update(new District
            {
                Id= DistrictId,
                PrivateCode = txtPrivateCode.Text,
                DistrictName = txtDistrictName.Text,
                Description = txtDescription.Text,
                State = tglState.IsOn,
                CityId = CityId
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }
        
        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CleanAllComponants();
            GetPrivateCode();
        }

        private void GetPrivateCode()
        {
            string privateCode = _districtService.GetLastDistrictPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        protected override void btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            CleanAllComponants();
            
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
            GetPrivateCode();
        }

        private void DistrictEditForm_Load(object sender, EventArgs e)
        {
            if (DistrictId!=-1)
            {
                var result = _districtService.Get(DistrictId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtDistrictName.Text = result.Data.DistrictName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GetPrivateCode();
            }
        }

        private void txtPrivateCode_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtPrivateCode.StatusBarDescription;
        }

        private void txtPrivateCode_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtDistrictName_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtDistrictName.StatusBarDescription;
        }

        private void txtDistrictName_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            statusBarDescription.Caption = txtDescription.StatusBarDescription;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            statusBarDescription.Caption = "";
        }

        private void DistrictEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DistrictListForm districtListForm = new DistrictListForm();
            districtListForm.Refresh();
        }
    }
}