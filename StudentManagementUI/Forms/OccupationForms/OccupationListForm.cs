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

namespace StudentManagementUI.Forms.OccupationForms
{
    public partial class OccupationListForm : BaseListForm
    {
        private readonly IOccupationService _occupationService;
        public OccupationListForm()
        {
            InitializeComponent();
            _occupationService = InstanceFactory.GetInstance<IOccupationService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlOccupations;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Occupation");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _occupationService.Delete(new Occupation
                {
                    Id = Convert.ToInt32(gridViewOccupations.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllOccupationActive();
                }
            }
        }

        private void GetAllOccupationActive()
        {
            gridControlOccupations.DataSource = _occupationService.GetOccupationActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            OccupationEditForm.OccupationId = -1;
            CreateForms<OccupationEditForm>.ShowDialogEditForm();
            GetAllOccupationActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            OccupationEditForm.OccupationId = Convert.ToInt32(gridViewOccupations.GetFocusedRowCellValue("Id").ToString());
            CreateForms<OccupationEditForm>.ShowDialogEditForm();
            GetAllOccupationActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllOccupationActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlOccupations.DataSource = _occupationService.GetOccupationActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlOccupations.DataSource = _occupationService.GetOccupationPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void gridControlOccupations_DoubleClick(object sender, EventArgs e)
        {
            if (MainForm.FormConrol)
            {
                MainForm.FormConrol = false;
                MainForm.OccupationId = Convert.ToInt32(gridViewOccupations.GetFocusedRowCellValue("Id").ToString());
                this.Close();
            }
            else
            {
                OccupationEditForm.OccupationId = Convert.ToInt32(gridViewOccupations.GetFocusedRowCellValue("Id").ToString());
                CreateForms<OccupationEditForm>.ShowDialogEditForm();
                GetAllOccupationActive();
            }
            
        }

        private void OccupationListForm_Load(object sender, EventArgs e)
        {
            GetAllOccupationActive();
        }
    }
}