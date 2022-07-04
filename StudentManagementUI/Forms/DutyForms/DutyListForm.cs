using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.GeneralForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.DutyForms
{
    public partial class DutyListForm : BaseListForm
    {
        private readonly IDutyService _dutyService;
        public DutyListForm()
        {
            InitializeComponent();
            _dutyService = InstanceFactory.GetInstance<IDutyService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Duty");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _dutyService.Delete(new Duty
                {
                    Id = Convert.ToInt32(gridViewDuties.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllDutyActive();
                }
            }
        }

        private void GetAllDutyActive()
        {
            gridControlDuties.DataSource = _dutyService.GetDutyActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DutyEditForm.DutyId = -1;
            CreateForms<DutyEditForm>.ShowDialogEditForm();
            GetAllDutyActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DutyEditForm.DutyId = Convert.ToInt32(gridViewDuties.GetFocusedRowCellValue("Id").ToString());
            CreateForms<DutyEditForm>.ShowDialogEditForm();
            GetAllDutyActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllDutyActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlDuties.DataSource = _dutyService.GetDutyActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlDuties.DataSource = _dutyService.GetDutyPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void DutyListForm_Load(object sender, EventArgs e)
        {
            GetAllDutyActive();
        }

        private void gridViewDuties_DoubleClick(object sender, EventArgs e)
        {
            if (MainForm.FormConrol)
            {
                MainForm.FormConrol = false;
                MainForm.DutyId = Convert.ToInt32(gridViewDuties.GetFocusedRowCellValue("Id").ToString());
                this.Close();
            }
            else
            {
                DutyEditForm.DutyId = Convert.ToInt32(gridViewDuties.GetFocusedRowCellValue("Id").ToString());
                CreateForms<DutyEditForm>.ShowDialogEditForm();
                GetAllDutyActive();
            }
            
        }
    }
}