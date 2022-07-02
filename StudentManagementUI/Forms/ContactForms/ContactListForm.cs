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

namespace StudentManagementUI.Forms.ContactForms
{
    public partial class ContactListForm : BaseListForm
    {
        private readonly IContactService _contactService;
        public ContactListForm()
        {
            InitializeComponent();
            _contactService = InstanceFactory.GetInstance<IContactService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Contacts");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _contactService.Delete(new Contact
                {
                    Id = Convert.ToInt32(bandedGridViewContacts.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllContactActiveDetailDto();
                }
            }
        }

        private void GetAllContactActiveDetailDto()
        {
            bandedGridControlContacts.DataSource = _contactService.GetContactDetailDtoActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContactEditForm.ContactId = -1;
            CreateForms<ContactEditForm>.ShowDialogEditForm();
            GetAllContactActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContactEditForm.ContactId = Convert.ToInt32(bandedGridViewContacts.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ContactEditForm>.ShowDialogEditForm();
            GetAllContactActiveDetailDto();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllContactActiveDetailDto();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlContacts.DataSource = _contactService.GetContactDetailDtoActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlContacts.DataSource = _contactService.GetContactDetailDtoPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void bandedGridViewCustomers_DoubleClick(object sender, EventArgs e)
        {
            ContactEditForm.ContactId = Convert.ToInt32(bandedGridViewContacts.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ContactEditForm>.ShowDialogEditForm();
            GetAllContactActiveDetailDto();
        }
    }
}