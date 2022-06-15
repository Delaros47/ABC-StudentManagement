using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.ClassGroupForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.ClassForms
{
    public partial class ClassEditForm : BaseEditForm

    {
        public static int ClassId = -1;
        public static int ClassGroupId = -1;
        public static bool ControlForm = false;
        private readonly IClassService _classService;
        private readonly IClassGroupService _classGroupService;
        public ClassEditForm()
        {
            InitializeComponent();
            _classService = InstanceFactory.GetInstance<IClassService>();
            _classGroupService = InstanceFactory.GetInstance<IClassGroupService>();
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
            string privateCode = _classService.GetLastClassPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _classService.Add(new Class
            {
                PrivateCode = txtPrivateCode.Text,
                ClassName = txtClassName.Text,
                ClassGroupId = ClassGroupId,
                AimRevenue = Convert.ToDecimal(txtAimRevenue.Text),
                AimStudentNumber = Convert.ToInt32(txtAimStudentNumber.Text),
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
                CleanAllComponants();
            }
        }

        protected override void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _classService.Update(new Class
            {
                Id = ClassId,
                PrivateCode = txtPrivateCode.Text,
                ClassGroupId =ClassGroupId,
                ClassName = txtClassName.Text,
                AimRevenue = Convert.ToDecimal(txtAimRevenue.Text),
                AimStudentNumber = Convert.ToInt32(txtAimStudentNumber.Text),
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void ClassEditForm_Load(object sender, EventArgs e)
        {
            if (ClassId != -1)
            {
                var result = _classService.Get(ClassId);
                var classGroup = _classGroupService.Get(result.Data.ClassGroupId);
                ClassGroupId = classGroup.Data.Id;
                if (result.Success && classGroup.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtClassName.Text = result.Data.ClassName;
                    txtAimStudentNumber.Text = result.Data.AimStudentNumber.ToString();
                    txtAimRevenue.Text = result.Data.AimRevenue.ToString();
                    btnClassGroupName.Text = classGroup.Data.ClassGroupName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }

        private void btnClassGroupName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ControlForm = true;
            CreateForms<ClassGroupListForm>.ShowDialogListFormWithoutParent();
            if (ClassGroupId!=-1)
            {
                var result = _classGroupService.Get(ClassGroupId);
                if (result.Success)
                {
                    btnClassGroupName.Text = result.Data.ClassGroupName;
                }
            }
        }
    }
}