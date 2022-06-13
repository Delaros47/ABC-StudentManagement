using DevExpress.XtraEditors;
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

namespace StudentManagementUI.Forms.DutyForms
{
    public partial class DutyListForm : BaseListForm
    {
        private readonly IWorkplaceService _workplaceService;
        public DutyListForm()
        {
            InitializeComponent();
            _workplaceService = InstanceFactory.GetInstance<IWorkplaceService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Family Intimacy");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _workplaceService.Delete(new Workplace
                {
                    Id = Convert.ToInt32(gridViewWorkplaces.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllWorkplaceActive();
                }
            }
        }

        private void GetAllWorkplaceActive()
        {
            gridControlWorkplaces.DataSource = _workplaceService.GetWorkplaceActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            WorkplaceEditForm.WorkplaceId = -1;
            CreateForms<WorkplaceEditForm>.ShowDialogEditForm();
            GetAllWorkplaceActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            WorkplaceEditForm.WorkplaceId = Convert.ToInt32(gridViewWorkplaces.GetFocusedRowCellValue("Id").ToString());
            CreateForms<WorkplaceEditForm>.ShowDialogEditForm();
            GetAllWorkplaceActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllWorkplaceActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlWorkplaces.DataSource = _workplaceService.GetWorkplaceActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlWorkplaces.DataSource = _workplaceService.GetWorkplacePassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void WorkplaceListForm_Load(object sender, EventArgs e)
        {
            GetAllWorkplaceActive();
        }

        private void gridViewWorkplaces_DoubleClick(object sender, EventArgs e)
        {
            WorkplaceEditForm.WorkplaceId = Convert.ToInt32(gridViewWorkplaces.GetFocusedRowCellValue("Id").ToString());
            CreateForms<WorkplaceEditForm>.ShowDialogEditForm();
            GetAllWorkplaceActive();
        }
    }
}