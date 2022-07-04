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
using StudentManagementUI.Forms.DutyForms;
using StudentManagementUI.Forms.GeneralForms;
using StudentManagementUI.Forms.OccupationForms;
using StudentManagementUI.Forms.SpecialCodeForms;
using StudentManagementUI.Forms.WorkplaceForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.ContactForms
{
    public partial class ContactParentEditForm : BaseEditForm
    {
        public static int ContactParentId = -1;
        public static int SpecialCode1 = -1;
        public static int SpecialCode2 = -1;
        public static int HomeAddressCityId = -1;
        public static int HomeAddressDistrictId = -1;
        public static int WorkAddressCityId = -1;
        public static int WorkAddressDistrictId = -1;
        public static int CityId = -1;
        public static int DistrictId = -1;
        public static int WorkPlaceId = -1;
        public static int DutyId = -1;
        public static int OccupationId = -1;

        private readonly IContactParentService _contactParentService;
        private readonly ISpecialCodeService _specialCodeService;
        private readonly ICityService _cityService;
        private readonly IDistrictService _districtService;
        private readonly IWorkplaceService _workplaceService;
        private readonly IDutyService _dutyService;
        private readonly IOccupationService _occupationService;
        public ContactParentEditForm()
        {
            InitializeComponent();
            _contactParentService = InstanceFactory.GetInstance<IContactParentService>();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
            _workplaceService = InstanceFactory.GetInstance<IWorkplaceService>();
            _dutyService = InstanceFactory.GetInstance<IDutyService>();
            _occupationService = InstanceFactory.GetInstance<IOccupationService>();
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
            string privateCode = _contactParentService.GetLastContactParentPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _contactParentService.Add(new ContactParent
            {
                PrivateCode = txtPrivateCode.Text,
                Address = txtHomeAddress.Text,
                BirthPlace = txtBirthPlace.Text,
                BloodType = cbxBloodType.SelectedItem.ToString(),
                CardNumber = txtCreditCardNumber.Text,
                CellPhone1 = txtCellPhone1.Text,
                CellPhone2 = txtCellPhone2.Text,
                InternalPhone1 = txtWorkPhone1Internal.Text,
                InternalPhone2 = txtWorkPhone2Internal.Text,
                WorkAddress = txtWorkAddress.Text,
                Email = txtEmail.Text,
                HomePhone = txtHomePhone.Text,
                DateOfBirth = Convert.ToDateTime(deBirthDate.Text),
                CityId = CityId,
                DistrictId = DistrictId,
                FatherName = txtFatherName.Text,
                IBanNumber = txtIBANNo.Text,
                FamilySequenceNumber = txtFamilySequenceNumber.Text,
                HomeAddressCityId = HomeAddressCityId,
                HomeAddressDistrictId = HomeAddressDistrictId,
                IdentityIssuedDate = Convert.ToDateTime(deIssuedDate.Text),
                MotherName = txtMotherName.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                IdentityNumber = txtIdentityNumber.Text,
                WorkplacePhone1 = txtWorkPhone1.Text,
                WorkplacePhone2 = txtWorkPhone2.Text,
                Neighbourhood = txtNeighbourhood.Text,
                SerialNumber = txtSerialNumber.Text,
                SequenceNumber = txtSequenceNumber.Text,
                PersonSequenceNumber = txtPersonSequenceNumber.Text,
                VolumeNumber = txtVolumeNumber.Text,
                IdentityIssuedReason = txtIssuedReason.Text,
                IdentityRegisterNumber = txtIdentityRegisterNumber.Text,
                WorkAddressCityId = WorkAddressCityId,
                WorkAddressDistrictId = WorkAddressDistrictId,
                PlaceIssued = txtIssuedPlace.Text,
                DutyId = MainForm.DutyId,
                OccupationId = MainForm.OccupationId,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
                State = tglState.IsOn,
                Description = txtDescription.Text,
                Web = txtWeb.Text,
                WorkplaceId = WorkPlaceId

            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _contactParentService.Update(new ContactParent
            {
                ContactParentId = ContactParentId,
                PrivateCode = txtPrivateCode.Text,
                Address = txtHomeAddress.Text,
                BirthPlace = txtBirthPlace.Text,
                BloodType = cbxBloodType.SelectedItem.ToString(),
                CardNumber = txtCreditCardNumber.Text,
                CellPhone1 = txtCellPhone1.Text,
                CellPhone2 = txtCellPhone2.Text,
                InternalPhone1 = txtWorkPhone1Internal.Text,
                InternalPhone2 = txtWorkPhone2Internal.Text,
                WorkAddress = txtWorkAddress.Text,
                Email = txtEmail.Text,
                HomePhone = txtHomePhone.Text,
                DateOfBirth = Convert.ToDateTime(deBirthDate.Text),
                CityId = CityId,
                DistrictId = DistrictId,
                FatherName = txtFatherName.Text,
                IBanNumber = txtIBANNo.Text,
                FamilySequenceNumber = txtFamilySequenceNumber.Text,
                HomeAddressCityId = HomeAddressCityId,
                HomeAddressDistrictId = HomeAddressDistrictId,
                IdentityIssuedDate = Convert.ToDateTime(deIssuedDate.Text),
                MotherName = txtMotherName.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                IdentityNumber = txtIdentityNumber.Text,
                WorkplacePhone1 = txtWorkPhone1.Text,
                WorkplacePhone2 = txtWorkPhone2.Text,
                Neighbourhood = txtNeighbourhood.Text,
                SerialNumber = txtSerialNumber.Text,
                SequenceNumber = txtSequenceNumber.Text,
                PersonSequenceNumber = txtPersonSequenceNumber.Text,
                VolumeNumber = txtVolumeNumber.Text,
                IdentityIssuedReason = txtIssuedReason.Text,
                IdentityRegisterNumber = txtIdentityRegisterNumber.Text,
                WorkAddressCityId = WorkAddressCityId,
                WorkAddressDistrictId = WorkAddressDistrictId,
                PlaceIssued = txtIssuedPlace.Text,
                DutyId = DutyId,
                OccupationId = OccupationId,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
                State = tglState.IsOn,
                Description = txtDescription.Text,
                Web = txtWeb.Text,
                WorkplaceId = WorkPlaceId
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void ContactEditForm_Load(object sender, EventArgs e)
        {

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

        private void btnHomeAddressCity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<CityListForm>.ShowDialogListFormWithoutParent();
            HomeAddressCityId = MainForm.CityId;
            btnHomeAddressCity.Text = _cityService.Get(HomeAddressCityId).Data.CityName;
        }

        private void btnHomeAddressDistrict_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            DistrictListForm.CityId = HomeAddressCityId;
            CreateForms<DistrictListForm>.ShowDialogListFormWithoutParent();
            HomeAddressDistrictId = MainForm.DistrictId;
            btnHomeAddressDistrict.Text = _districtService.Get(HomeAddressDistrictId).Data.DistrictName;
        }

        private void btnWorkAddressCity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<CityListForm>.ShowDialogListFormWithoutParent();
            WorkAddressCityId = MainForm.CityId;
            btnWorkAddressCity.Text = _cityService.Get(WorkAddressCityId).Data.CityName;
        }

        private void btnWorkAddressDistrict_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            DistrictListForm.CityId = WorkAddressCityId;
            CreateForms<DistrictListForm>.ShowDialogListFormWithoutParent();
            WorkAddressDistrictId = MainForm.DistrictId;
            btnWorkAddressDistrict.Text = _districtService.Get(WorkAddressDistrictId).Data.DistrictName;
        }

        private void btnCity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<CityListForm>.ShowDialogListFormWithoutParent();
            CityId = MainForm.CityId;
            btnCity.Text = _cityService.Get(CityId).Data.CityName;
        }

        private void btnDistrict_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            DistrictListForm.CityId = CityId;
            CreateForms<DistrictListForm>.ShowDialogListFormWithoutParent();
            DistrictId = MainForm.DistrictId;
            btnDistrict.Text = _districtService.Get(DistrictId).Data.DistrictName;
        }

        private void btnWorkPlace_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<WorkplaceListForm>.ShowDialogListFormWithoutParent();
            WorkPlaceId = MainForm.WorkPlaceId;
            btnWorkPlace.Text = _workplaceService.Get(WorkPlaceId).Data.WorkplaceName;

        }

        private void btnDuty_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<DutyListForm>.ShowDialogListFormWithoutParent();
            DutyId = MainForm.DutyId;
            btnDuty.Text = _dutyService.Get(DutyId).Data.DutyName;
        }

        private void btnOccupation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MainForm.FormConrol = true;
            CreateForms<OccupationListForm>.ShowDialogListFormWithoutParent();
            OccupationId = MainForm.OccupationId;
            btnOccupation.Text = _occupationService.Get(OccupationId).Data.OccupationName;
        }

        private void ContactParentEditForm_Load(object sender, EventArgs e)
        {
            if (ContactParentId != -1)
            {
                var result = _contactParentService.GetById(ContactParentId);
                var city = _cityService.Get(result.Data.CityId);
                var district = _districtService.Get(result.Data.DistrictId);
                var homecity = _cityService.Get(result.Data.HomeAddressCityId);
                var homedistrict = _districtService.Get(result.Data.HomeAddressDistrictId);
                var workcity = _cityService.Get(result.Data.WorkAddressCityId);
                var workdistrict = _districtService.Get(result.Data.WorkAddressDistrictId);
                var occupation = _occupationService.Get(result.Data.OccupationId);
                var duty = _dutyService.Get(result.Data.DutyId);
                var workplace = _workplaceService.Get(result.Data.WorkplaceId);
                var special1 = _specialCodeService.Get(result.Data.SpecialCode1);
                var special2 = _specialCodeService.Get(result.Data.SpecialCode2);
                SpecialCode1 = special1.Data.Id;
                SpecialCode2 = special2.Data.Id;
                OccupationId = result.Data.OccupationId;
                WorkPlaceId = result.Data.WorkplaceId;
                DutyId = result.Data.DutyId;
                HomeAddressCityId = result.Data.HomeAddressCityId;
                HomeAddressDistrictId =result.Data.HomeAddressDistrictId;
                WorkAddressCityId = result.Data.WorkAddressCityId;
                WorkAddressDistrictId = result.Data.WorkAddressDistrictId;
                CityId = result.Data.CityId;
                DistrictId = result.Data.DistrictId;
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    btnSpecialCode1.Text = special1.Data.SpecialCodeName;
                    btnSpecialCode2.Text = special2.Data.SpecialCodeName;
                    txtIdentityNumber.Text = result.Data.IdentityNumber;
                    txtName.Text = result.Data.Name;
                    txtSurname.Text = result.Data.Surname;
                    txtFatherName.Text = result.Data.FatherName;
                    txtMotherName.Text = result.Data.MotherName;
                    deBirthDate.Text = result.Data.DateOfBirth.ToShortDateString();
                    cbxBloodType.SelectedItem = result.Data.BloodType;
                    txtSerialNumber.Text = result.Data.SerialNumber;
                    txtSequenceNumber.Text = result.Data.SequenceNumber;
                    txtNeighbourhood.Text = result.Data.Neighbourhood;
                    btnCity.Text = city.Data.CityName;
                    btnDistrict.Text = district.Data.DistrictName;
                    txtVolumeNumber.Text = result.Data.VolumeNumber;
                    txtFamilySequenceNumber.Text = result.Data.FamilySequenceNumber;
                    txtPersonSequenceNumber.Text = result.Data.PersonSequenceNumber;
                    txtIssuedPlace.Text = result.Data.PlaceIssued;
                    txtIssuedReason.Text = result.Data.IdentityIssuedReason;
                    txtIdentityRegisterNumber.Text = result.Data.IdentityRegisterNumber;
                    deIssuedDate.Text = result.Data.IdentityIssuedDate.ToShortDateString();
                    txtHomePhone.Text = result.Data.HomePhone;
                    txtWorkPhone1.Text = result.Data.WorkplacePhone1;
                    txtWorkPhone2.Text = result.Data.WorkplacePhone2;
                    txtWorkPhone1Internal.Text = result.Data.InternalPhone1;
                    txtWorkPhone2Internal.Text = result.Data.InternalPhone2;
                    txtCellPhone1.Text = result.Data.CellPhone1;
                    txtCellPhone2.Text = result.Data.CellPhone2;
                    txtWeb.Text = result.Data.Web;
                    txtEmail.Text = result.Data.Email;
                    txtHomeAddress.Text = result.Data.Address;
                    btnHomeAddressCity.Text = homecity.Data.CityName;
                    btnHomeAddressDistrict.Text = homedistrict.Data.DistrictName;
                    txtWorkAddress.Text = result.Data.WorkAddress;
                    btnWorkAddressCity.Text = workcity.Data.CityName;
                    btnWorkAddressDistrict.Text = workdistrict.Data.DistrictName;
                    btnOccupation.Text = occupation.Data.OccupationName;
                    btnDuty.Text = duty.Data.DutyName;
                    btnWorkPlace.Text = workplace.Data.WorkplaceName;
                    txtIBANNo.Text = result.Data.IBanNumber;
                    txtCreditCardNumber.Text = result.Data.CardNumber;
                    txtBirthPlace.Text = result.Data.BirthPlace;
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