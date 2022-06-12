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

namespace StudentManagementUI.Forms.ClassGroupForms
{
    public partial class ClassGroupListForm : BaseListForm
    {
        private readonly IClassGroupService _classGroupService;
        public ClassGroupListForm()
        {
            InitializeComponent();
            _classGroupService = InstanceFactory.GetInstance<IClassGroupService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Class Group");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _classGroupService.Delete(new ClassGroup
                {
                    Id = Convert.ToInt32(gridViewClassGroups.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllClassGroupActive();
                }
            }
        }

        private void GetAllClassGroupActive()
        {
            gridControlClassGroups.DataSource = _classGroupService.GetClassGroupActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClassGroupEditForm.ClassGroupId = -1;
            CreateForms<ClassGroupEditForm>.ShowDialogEditForm();
            GetAllClassGroupActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClassGroupEditForm.ClassGroupId = Convert.ToInt32(gridViewClassGroups.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ClassGroupEditForm>.ShowDialogEditForm();
            GetAllClassGroupActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllClassGroupActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlClassGroups.DataSource = _classGroupService.GetClassGroupPassive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlClassGroups.DataSource = _classGroupService.GetClassGroupActive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void ClassGroupListForm_Load(object sender, EventArgs e)
        {
            GetAllClassGroupActive();
        }

        private void gridViewClassGroups_DoubleClick(object sender, EventArgs e)
        {
            ClassGroupEditForm.ClassGroupId = Convert.ToInt32(gridViewClassGroups.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ClassGroupEditForm>.ShowDialogEditForm();
            GetAllClassGroupActive();
        }
    }
}