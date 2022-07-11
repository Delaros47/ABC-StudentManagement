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

namespace StudentManagementUI.Forms.ClassForms
{
    public partial class ClassListForm : BaseListForm
    {
        private readonly IClassService _classService;
        public ClassListForm()
        {
            InitializeComponent();
            _classService = InstanceFactory.GetInstance<IClassService>();
            longNavigator.controlNavigator.NavigatableControl = bandedGridControlClasses;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Class");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _classService.Delete(new Class
                {
                    Id = Convert.ToInt32(bandedGridViewClasses.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllClassDetailDtoActive();
                }
            }
        }

        private void GetAllClassDetailDtoActive()
        {
            bandedGridControlClasses.DataSource = _classService.GetClassDetailDtoActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClassEditForm.ClassId = -1;
            CreateForms<ClassEditForm>.ShowDialogEditForm();
            GetAllClassDetailDtoActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClassEditForm.ClassId = Convert.ToInt32(bandedGridViewClasses.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ClassEditForm>.ShowDialogEditForm();
            GetAllClassDetailDtoActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllClassDetailDtoActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlClasses.DataSource = _classService.GetClassDetailDtoActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlClasses.DataSource = _classService.GetClassDetailDtoPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void ClassListForm_Load(object sender, EventArgs e)
        {
            GetAllClassDetailDtoActive();
        }

        private void bandedGridViewClasses_DoubleClick(object sender, EventArgs e)
        {

            ClassEditForm.ClassId = Convert.ToInt32(bandedGridViewClasses.GetFocusedRowCellValue("Id").ToString());
            CreateForms<ClassEditForm>.ShowDialogEditForm();
            GetAllClassDetailDtoActive();
        }
    }
}