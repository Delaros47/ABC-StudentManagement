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

namespace StudentManagementUI.Forms.GuidanceCounselorForms
{
    public partial class GuidanceCounselorListForm : BaseListForm
    {
        private readonly IGuidanceCounselorService _guidanceCounselorService;
        public GuidanceCounselorListForm()
        {
            InitializeComponent();
            _guidanceCounselorService = InstanceFactory.GetInstance<IGuidanceCounselorService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Guidance Counselor");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _guidanceCounselorService.Delete(new GuidanceCounselor
                {
                    Id = Convert.ToInt32(gridViewGuidanceCounselors.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllGuidanceCounselorActive();
                }
            }
        }

        private void GetAllGuidanceCounselorActive()
        {
            gridControlGuidanceCounselors.DataSource = _guidanceCounselorService.GetGuidanceCounselorActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            GuidanceCounselorEditForm.GuidanceCounselorId = -1;
            CreateForms<GuidanceCounselorEditForm>.ShowDialogEditForm();
            GetAllGuidanceCounselorActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            GuidanceCounselorEditForm.GuidanceCounselorId = Convert.ToInt32(gridViewGuidanceCounselors.GetFocusedRowCellValue("Id").ToString());
            CreateForms<GuidanceCounselorEditForm>.ShowDialogEditForm();
            GetAllGuidanceCounselorActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllGuidanceCounselorActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlGuidanceCounselors.DataSource = _guidanceCounselorService.GetGuidanceCounselorActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlGuidanceCounselors.DataSource = _guidanceCounselorService.GetGuidanceCounselorPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void GuidanceCounselorListForm_Load(object sender, EventArgs e)
        {
            GetAllGuidanceCounselorActive();
        }

        private void gridViewGuidanceCounselors_DoubleClick(object sender, EventArgs e)
        {
            GuidanceCounselorEditForm.GuidanceCounselorId = Convert.ToInt32(gridViewGuidanceCounselors.GetFocusedRowCellValue("Id").ToString());
            CreateForms<GuidanceCounselorEditForm>.ShowDialogEditForm();
            GetAllGuidanceCounselorActive();
        }
    }
}