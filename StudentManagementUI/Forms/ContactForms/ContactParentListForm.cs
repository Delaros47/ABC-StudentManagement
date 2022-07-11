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
    public partial class ContactParentListForm : BaseListForm
    {
        private readonly IContactParentService _contactParentService;
        public ContactParentListForm()
        {
            InitializeComponent();
            _contactParentService = InstanceFactory.GetInstance<IContactParentService>();
            longNavigator.controlNavigator.NavigatableControl = bandedGridControlContacts;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Contacts");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _contactParentService.Delete(new ContactParent
                {
                    ContactParentId = Convert.ToInt32(bandedGridViewContacts.GetFocusedRowCellValue("ContactParentId").ToString())
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
            bandedGridControlContacts.DataSource = _contactParentService.GetContactParentDetailDtoActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContactParentEditForm.ContactParentId = -1;
            CreateForms<ContactParentEditForm>.ShowDialogEditForm();
            GetAllContactActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContactParentEditForm.ContactParentId = Convert.ToInt32(bandedGridViewContacts.GetFocusedRowCellValue("ContactParentId").ToString());
            CreateForms<ContactParentEditForm>.ShowDialogEditForm();
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
                bandedGridControlContacts.DataSource = _contactParentService.GetContactParentDetailDtoActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlContacts.DataSource = _contactParentService.GetContactParentDetailDtoPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void ContactListForm_Load(object sender, EventArgs e)
        {
            GetAllContactActiveDetailDto();
        }

        private void bandedGridViewContacts_DoubleClick(object sender, EventArgs e)
        {
            ContactParentEditForm.ContactParentId = Convert.ToInt32(bandedGridViewContacts.GetFocusedRowCellValue("ContactParentId").ToString());
            CreateForms<ContactParentEditForm>.ShowDialogEditForm();
            GetAllContactActiveDetailDto();
        }
    }
}