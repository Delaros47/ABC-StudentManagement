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

namespace StudentManagementUI.Forms.StudentForms
{
    public partial class StudentListForm : BaseListForm
    {
        private readonly IStudentService _studentService;
        public StudentListForm()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Student");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _studentService.Delete(new Student
                {
                    Id = Convert.ToInt32(bandedGridViewStudents.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllStudentActiveDetailDto();
                }
            }
        }

        private void GetAllStudentActiveDetailDto()
        {
            bandedGridControlStudents.DataSource = _studentService.GetStudentDetailDtoActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            StudentEditForm.StudentId = -1;
            CreateForms<StudentEditForm>.ShowDialogEditForm();
            GetAllStudentActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            StudentEditForm.StudentId = Convert.ToInt32(bandedGridViewStudents.GetFocusedRowCellValue("Id").ToString());
            CreateForms<StudentEditForm>.ShowDialogEditForm();
            GetAllStudentActiveDetailDto();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllStudentActiveDetailDto();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlStudents.DataSource = _studentService.GetStudentDetailDtoActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlStudents.DataSource = _studentService.GetStudentDetailDtoPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            GetAllStudentActiveDetailDto();
        }

        private void bandedGridViewStudents_DoubleClick(object sender, EventArgs e)
        {
            StudentEditForm.StudentId = Convert.ToInt32(bandedGridViewStudents.GetFocusedRowCellValue("Id").ToString());
            CreateForms<StudentEditForm>.ShowDialogEditForm();
            GetAllStudentActiveDetailDto();
        }
    }
}