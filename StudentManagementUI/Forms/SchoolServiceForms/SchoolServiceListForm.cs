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

namespace StudentManagementUI.Forms.SchoolServiceForms
{
    public partial class SchoolServiceListForm : BaseListForm
    {
        private readonly ISchoolServiceService _schoolServiceService;
        public SchoolServiceListForm()
        {
            InitializeComponent();
            _schoolServiceService = InstanceFactory.GetInstance<ISchoolServiceService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("School Service");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _schoolServiceService.Delete(new SchoolService
                {
                    Id = Convert.ToInt32(gridViewSchoolServices.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllSchoolServiceActive();
                }
            }
        }

        private void GetAllSchoolServiceActive()
        {
            gridControlSchoolServices.DataSource = _schoolServiceService.GetSchoolServiceActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SchoolServiceEditForm.SchoolServiceId = -1;
            CreateForms<SchoolServiceEditForm>.ShowDialogEditForm();
            GetAllSchoolServiceActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SchoolServiceEditForm.SchoolServiceId = Convert.ToInt32(gridViewSchoolServices.GetFocusedRowCellValue("Id").ToString());
            CreateForms<SchoolServiceEditForm>.ShowDialogEditForm();
            GetAllSchoolServiceActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllSchoolServiceActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlSchoolServices.DataSource = _schoolServiceService.GetSchoolServiceActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlSchoolServices.DataSource = _schoolServiceService.GetSchoolServicePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void SchoolServiceListForm_Load(object sender, EventArgs e)
        {
            GetAllSchoolServiceActive();
        }

        private void gridControlSchoolServices_DoubleClick(object sender, EventArgs e)
        {
            SchoolServiceEditForm.SchoolServiceId = Convert.ToInt32(gridViewSchoolServices.GetFocusedRowCellValue("Id").ToString());
            CreateForms<SchoolServiceEditForm>.ShowDialogEditForm();
            GetAllSchoolServiceActive();
        }
    }
}