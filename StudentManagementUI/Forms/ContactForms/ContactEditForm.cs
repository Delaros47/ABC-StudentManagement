using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.GeneralForms;
using StudentManagementUI.Forms.SpecialCodeForms;
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
    public partial class ContactEditForm : BaseEditForm
    {
        public static int ContactId = -1;
        public static int SpecialCode1 = -1;
        public static int SpecialCode2 = -1;
        private readonly IContactService _contactService;
        private readonly ISpecialCodeService _specialCodeService;
        public ContactEditForm()
        {
            InitializeComponent();
            _contactService = InstanceFactory.GetInstance<IContactService>();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
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
            string privateCode = _contactService.GetLastContactPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _contactService.Add(new Contact
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
                CityId = MainForm.CityId,
                DistrictId = MainForm.DistrictId,
                FatherName = txtFatherName.Text,
                IBanNumber = txtIBANNo.Text,
                FamilySequenceNumber = txtFamilySequenceNumber.Text,
                HomeAddressCityId = MainForm.CityId,
                HomeAddressDistrictId = MainForm.DistrictId,
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
                WorkAddressCityId = MainForm.CityId,
                WorkAddressDistrictId = MainForm.DistrictId,
                PlaceIssued = txtIssuedPlace.Text,
                DutyId = MainForm.DutyId,
                OccupationId = MainForm.OccupationId,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
                State = tglState.IsOn,
                Description = txtDescription.Text,
                Web = txtWeb.Text,
                
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _contactService.Update(new Contact
            {
                Id = ContactId,
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
                CityId = MainForm.CityId,
                DistrictId = MainForm.DistrictId,
                FatherName = txtFatherName.Text,
                IBanNumber = txtIBANNo.Text,
                FamilySequenceNumber = txtFamilySequenceNumber.Text,
                HomeAddressCityId = MainForm.CityId,
                HomeAddressDistrictId = MainForm.DistrictId,
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
                WorkAddressCityId = MainForm.CityId,
                WorkAddressDistrictId = MainForm.DistrictId,
                PlaceIssued = txtIssuedPlace.Text,
                DutyId = MainForm.DutyId,
                OccupationId = MainForm.OccupationId,
                SpecialCode1 = MainForm.SpecialCode1,
                SpecialCode2 = MainForm.SpecialCode2,
                State = tglState.IsOn,
                Description = txtDescription.Text,
                Web = txtWeb.Text,
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void ContactEditForm_Load(object sender, EventArgs e)
        {
            if (ContactId != -1)
            {
                var result = _contactService.Get(ContactId);
                var special1 = _specialCodeService.Get(result.Data.SpecialCode1);
                var special2 = _specialCodeService.Get(result.Data.SpecialCode2);
                SpecialCode1 = special1.Data.Id;
                SpecialCode2 = special2.Data.Id;
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;

                    btnSpecialCode1.Text = special1.Data.SpecialCodeName;
                    btnSpecialCode2.Text = special2.Data.SpecialCodeName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
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
    }
}