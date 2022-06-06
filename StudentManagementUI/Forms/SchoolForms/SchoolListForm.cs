using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Commons.Functions;
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
            //GetSchoolDetailDto();
        }

        private void GetSchoolDetailDto()
        {
            gridControlSchoolList.DataSource = _schoolService.GetSchoolDetailDto().Data;
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption=="Active List")
            {
                gridControlSchoolList.DataSource = _schoolService.GetSchoolDetailDtoPassive().Data;
                e.Item.Caption = "Passive List";
            }
            else
            {
                gridControlSchoolList.DataSource = _schoolService.GetSchoolDetailDtoActive().Data;
                e.Item.Caption = "Active List";
            }
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForms<SchoolEditForm>.ShowDialogEditForm();
        }

    }
}