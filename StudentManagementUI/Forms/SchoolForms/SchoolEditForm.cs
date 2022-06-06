using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.CityForms;
using StudentManagementUI.Forms.DistrictForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.SchoolForms
{
    public partial class SchoolEditForm : BaseEditForm
    {
        public static int CityId = -1;
        public static int DistrictId = -1;
        public static int SchoolId = -1;
        public static bool ControlForm = false;
        private readonly ISchoolService _schoolService;
        private readonly ICityService _cityService;
        private readonly IDistrictService _districtService;
        public SchoolEditForm()
        {
            InitializeComponent();
            _schoolService = InstanceFactory.GetInstance<ISchoolService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
        }

        private void btnCity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ControlForm = true;
            CreateForms<CityListForm>.ShowDialogListFormWithoutParent();
            if (CityId!=-1)
            {
                var result = _cityService.Get(CityId);
                if (result.Success)
                {
                    btnCity.Text = result.Data.CityName;
                }
            }
        }

        private void btnDistrict_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ControlForm = true;
            CreateForms<DistrictListForm>.ShowDialogListFormWithoutParent();
            if (DistrictId!=-1)
            {
                var result = _districtService.Get(DistrictId);
                if (result.Success)
                {
                    btnDistrict.Text = result.Data.DistrictName;
                }
            }
            
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _schoolService.Add(new School
            {
                PrivateCode = txtPrivateCode.Text,
                SchoolName = txtSchoolName.Text,
                Description = txtDescription.Text,
                State = tglState.IsOn,
                CityId = CityId,
                DistrictId = DistrictId
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _schoolService.Update(new School
            {
                Id= SchoolId,
                PrivateCode = txtPrivateCode.Text,
                SchoolName = txtSchoolName.Text,
                Description = txtDescription.Text,
                State = tglState.IsOn,
                CityId = CityId,
                DistrictId = DistrictId
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
            GeneratePrivateCodes.GeneratePrivate(null);
        }

        protected override void btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            CleanAllComponants();
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl);
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}