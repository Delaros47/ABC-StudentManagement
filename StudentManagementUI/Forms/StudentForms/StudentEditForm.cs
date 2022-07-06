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
using StudentManagementUI.Forms.GeneralForms;
using StudentManagementUI.Forms.SpecialCodeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.StudentForms
{
    public partial class StudentEditForm : BaseEditForm
    {
        public static int StudentId = -1;
        public static int SpecialCode1 = -1;
        public static int SpecialCode2 = -1;
        public static int SpecialCode3 = -1;
        public static int SpecialCode4 = -1;
        public static int SpecialCode5 = -1;
        public static int CityId = -1;
        public static int DistrictId = -1;
        private readonly IStudentService _studentService;
        private readonly ISpecialCodeService _specialCodeService;
        private readonly ICityService _cityService;
        private readonly IDistrictService _districtService;
        public StudentEditForm()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
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
            string privateCode = _studentService.GetLastStudentPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {

            var result = _studentService.Add(new Student
            {
                PrivateCode = txtPrivateCode.Text,
                BloodType = cbxBloodType.SelectedItem.ToString(),
                DateOfBirth = Convert.ToDateTime(deDateOfBirth.Text),
                DateOfIssue = Convert.ToDateTime(deDateOfIssue.Text),
                FamilyOrder = txtFamilyOrder.Text,
                FatherName = txtFatherName.Text,
                Gender= cbxGender.SelectedItem.ToString(),
                IdentitySerialNumber = txtIdentitySerialNumber.Text,
                IssuedFor = txtIssuedFor.Text,
                MotherName = txtMotherName.Text,
                Name= txtName.Text,
                Surname = txtSurname.Text,
                NumberIndividual = txtNumberIndividual.Text,
                PersonNumber = txtPersonNumber.Text,
                Phone = txtPhoneNumber.Text,
                PlaceOfBirth = txtPlaceOfBirth.Text,
                PlaceOfIssue = txtPlaceOfIssue.Text,
                RegisterNumber = txtRegisterNumber.Text,
                SubDistrictVillage = txtSubDistrictVillage.Text,
                VolumeNumber = txtVolumeNumber.Text,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
                SpecialCode3 = MainForm.SpecialCode3,
                SpecialCode4 = MainForm.SpecialCode4,
                SpecialCode5 = MainForm.SpecialCode5,
                CityId = MainForm.CityId,
                DistrictId = MainForm.DistrictId,
                Image = File.ReadAllBytes(pictureEditPhoto.GetLoadedImageLocation()),
                IdentityNumber = txtIdentityNumber.Text,
                State = tglState.IsOn,
                
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var student = _studentService.Get(StudentId);
            byte[] image =null;
            string str = pictureEditPhoto.GetLoadedImageLocation();
            if (pictureEditPhoto.GetLoadedImageLocation()=="")
            {
                image = student.Data.Image;
                
            }
            else
            {
                image = File.ReadAllBytes(pictureEditPhoto.GetLoadedImageLocation());
            }
            var result = _studentService.Update(new Student
            {
                Id= StudentId,
                PrivateCode = txtPrivateCode.Text,
                BloodType = cbxBloodType.SelectedItem.ToString(),
                DateOfBirth = Convert.ToDateTime(deDateOfBirth.Text),
                DateOfIssue = Convert.ToDateTime(deDateOfIssue.Text),
                FamilyOrder = txtFamilyOrder.Text,
                FatherName = txtFatherName.Text,
                Gender = cbxGender.SelectedItem.ToString(),
                IdentitySerialNumber = txtIdentitySerialNumber.Text,
                IssuedFor = txtIssuedFor.Text,
                MotherName = txtMotherName.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                NumberIndividual = txtNumberIndividual.Text,
                PersonNumber = txtPersonNumber.Text,
                Phone = txtPhoneNumber.Text,
                PlaceOfBirth = txtPlaceOfBirth.Text,
                PlaceOfIssue = txtPlaceOfIssue.Text,
                RegisterNumber = txtRegisterNumber.Text,
                SubDistrictVillage = txtSubDistrictVillage.Text,
                VolumeNumber = txtVolumeNumber.Text,
                SpecialCode1 = SpecialCode1,
                SpecialCode2 = SpecialCode2,
                SpecialCode3 = SpecialCode3,
                SpecialCode4 = SpecialCode4,
                SpecialCode5 = SpecialCode5,
                CityId = CityId,
                DistrictId = DistrictId,
                IdentityNumber = txtIdentityNumber.Text,
                Image = image,
                State = tglState.IsOn,
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }



        private void btnSpecialCode1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode1 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode1.Text = _specialCodeService.Get(MainForm.SpecialCode1).Data.SpecialCodeName;
        }

        private void btnSpecialCode2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode2 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode2.Text = _specialCodeService.Get(MainForm.SpecialCode2).Data.SpecialCodeName;
        }

        private void btnSpecialCode3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode3 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode3.Text = _specialCodeService.Get(MainForm.SpecialCode3).Data.SpecialCodeName;
        }

        private void btnSpecialCode4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode4 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode4.Text = _specialCodeService.Get(MainForm.SpecialCode4).Data.SpecialCodeName;
        }

        private void btnSpecialCode5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SpecialCodeListForm.SpecialCode5 = true;
            CreateForms<SpecialCodeListForm>.ShowDialogListFormWithoutParent();
            btnSpecialCode5.Text = _specialCodeService.Get(MainForm.SpecialCode5).Data.SpecialCodeName;
        }

        private void btnCity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<CityListForm>.ShowDialogListFormWithoutParent();
            btnCity.Text = _cityService.Get(MainForm.CityId).Data.CityName;
            CityId = MainForm.CityId;
        }

        private void btnDistrict_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            DistrictListForm.CityId = CityId;
            CreateForms<DistrictListForm>.ShowDialogListFormWithoutParent();           
            btnDistrict.Text = _districtService.Get(MainForm.DistrictId).Data.DistrictName;
            CityId = MainForm.CityId;
        }

        private void StudentEditForm_Load(object sender, EventArgs e)
        {
            if (StudentId != -1)
            {
                var result = _studentService.Get(StudentId);
                var special1 = _specialCodeService.Get(result.Data.SpecialCode1);
                var special2 = _specialCodeService.Get(result.Data.SpecialCode2);
                var special3 = _specialCodeService.Get(result.Data.SpecialCode3);
                var special4 = _specialCodeService.Get(result.Data.SpecialCode4);
                var special5 = _specialCodeService.Get(result.Data.SpecialCode5);
                var city = _cityService.Get(result.Data.CityId);
                var district = _districtService.Get(result.Data.DistrictId);
                CityId = city.Data.Id;
                DistrictId = district.Data.Id;
                SpecialCode1 = special1.Data.Id;
                SpecialCode2 = special2.Data.Id;
                SpecialCode3 = special3.Data.Id;
                SpecialCode4 = special4.Data.Id;
                SpecialCode5 = special5.Data.Id;
                
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtName.Text = result.Data.Name;
                    txtSurname.Text = result.Data.Surname;
                    cbxGender.SelectedItem = result.Data.Gender;
                    txtPhoneNumber.Text = result.Data.Phone;
                    cbxBloodType.SelectedItem = result.Data.BloodType;
                    txtFatherName.Text = result.Data.FatherName;
                    txtMotherName.Text = result.Data.MotherName;
                    txtPlaceOfBirth.Text = result.Data.PlaceOfBirth;
                    deDateOfBirth.Text = result.Data.DateOfBirth.ToShortDateString();
                    txtIdentitySerialNumber.Text = result.Data.IdentitySerialNumber;
                    txtNumberIndividual.Text = result.Data.NumberIndividual;
                    btnCity.Text = city.Data.CityName;
                    btnDistrict.Text = district.Data.DistrictName;
                    txtSubDistrictVillage.Text = result.Data.SubDistrictVillage;
                    txtVolumeNumber.Text = result.Data.VolumeNumber;
                    txtFamilyOrder.Text = result.Data.FamilyOrder;
                    txtPlaceOfIssue.Text = result.Data.PlaceOfIssue;
                    txtIssuedFor.Text = result.Data.IssuedFor;
                    deDateOfIssue.Text = result.Data.DateOfIssue.ToShortDateString();
                    using (MemoryStream memoryStream = new MemoryStream((byte[])result.Data.Image))
                    {
                        pictureEditPhoto.Image = Image.FromStream(memoryStream);
                    }
                    btnSpecialCode1.Text = special1.Data.SpecialCodeName;
                    btnSpecialCode2.Text = special2.Data.SpecialCodeName;
                    btnSpecialCode3.Text = special3.Data.SpecialCodeName;
                    btnSpecialCode4.Text = special4.Data.SpecialCodeName;
                    btnSpecialCode5.Text = special5.Data.SpecialCodeName;
                    txtPersonNumber.Text = result.Data.PersonNumber;
                    txtRegisterNumber.Text = result.Data.RegisterNumber;
                    txtIdentityNumber.Text = result.Data.IdentityNumber;
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