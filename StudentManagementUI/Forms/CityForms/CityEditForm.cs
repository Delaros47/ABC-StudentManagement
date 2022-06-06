using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DataAccess.Abstract;
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

namespace StudentManagementUI.Forms.CityForms
{
    public partial class CityEditForm : BaseEditForm
    {
        public static int Id = -1;
        private readonly ICityService _cityService;
        public CityEditForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();
        }

        private void CityEditForm_Load(object sender, EventArgs e)
        {
            GetTheCity();
            txtDescription.Focus();
        }
        private void GetTheCity()
        {
            if (Id != -1)
            {
                var result = _cityService.Get(Id);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtCityName.Text = result.Data.CityName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            if (Id == -1)
            {
                GetPrivateCode();
            }

        }
        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetPrivateCode();
        }

        private void GetPrivateCode()
        {
            string privateCode = _cityService.GetLastPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
            txtCityName.Focus();
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _cityService.Add(new City
            {
                PrivateCode = txtPrivateCode.Text,
                CityName = txtCityName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text,
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                ClearAllControls();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _cityService.Update(new City
            {
                Id = Id,
                PrivateCode = txtPrivateCode.Text,
                CityName = txtCityName.Text,
                Description = txtDescription.Text,
                State = tglState.IsOn
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                ClearAllControls();
            }
        }

        protected override void btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearAllControls();
        }

        private void ClearAllControls()
        {
            ClearAll.Clean(myDataLayoutControl1);
            GetPrivateCode();
        }
    }
}