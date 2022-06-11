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

namespace StudentManagementUI.Forms.SchoolForms
{
    public partial class SchoolListForm :BaseListForm
    {
        private readonly ISchoolService _schoolService;
        public SchoolListForm()
        {
            InitializeComponent();
            _schoolService = InstanceFactory.GetInstance<ISchoolService>();
        }

        private void SchoolListForm_Load(object sender, EventArgs e)
        {
            GetSchoolDetailDtoActive();
        }

        private void GetSchoolDetailDtoActive()
        {
            gridControlSchoolList.DataSource = _schoolService.GetSchoolDetailDtoActive().Data;
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption=="Passive List")
            {
                gridControlSchoolList.DataSource = _schoolService.GetSchoolDetailDtoPassive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlSchoolList.DataSource = _schoolService.GetSchoolDetailDtoActive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SchoolEditForm.SchoolId = -1;
            CreateForms<SchoolEditForm>.ShowDialogEditForm();
            GetSchoolDetailDtoActive();

        }

        private void gridControlSchoolList_DoubleClick(object sender, EventArgs e)
        {
            SchoolEditForm.SchoolId = Convert.ToInt32(gridViewSchoolList.GetFocusedRowCellValue("Id").ToString());
            CreateForms<SchoolEditForm>.ShowDialogEditForm();
            GetSchoolDetailDtoActive();
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlSchoolList_DoubleClick(null,null);
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetSchoolDetailDtoActive();
        }

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("City");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _schoolService.Delete(new School
                {
                    Id = Convert.ToInt32(gridViewSchoolList.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetSchoolDetailDtoActive();
                }
            }
        }
    }
}