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

namespace StudentManagementUI.Forms.LawyerForms
{
    public partial class LawyerListForm : BaseListForm
    {
        private readonly ILawyerService _lawyerService;
        public LawyerListForm()
        {
            InitializeComponent();
            _lawyerService = InstanceFactory.GetInstance<ILawyerService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Bank");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _lawyerService.Delete(new Lawyer
                {
                    Id = Convert.ToInt32(bandedGridViewLawyers.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllLawyerActiveDetailDto();
                }
            }
        }

        private void GetAllLawyerActiveDetailDto()
        {
            bandedGridControlLawyers.DataSource = _lawyerService.GetLawyerDetailActiveDto().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            LawyerEditForm.LawyerId = -1;
            CreateForms<LawyerEditForm>.ShowDialogEditForm();
            GetAllLawyerActiveDetailDto();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            LawyerEditForm.LawyerId = Convert.ToInt32(bandedGridViewLawyers.GetFocusedRowCellValue("Id").ToString());
            CreateForms<LawyerEditForm>.ShowDialogEditForm();
            GetAllLawyerActiveDetailDto();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllLawyerActiveDetailDto();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                bandedGridControlLawyers.DataSource = _lawyerService.GetLawyerDetailActiveDto().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                bandedGridControlLawyers.DataSource = _lawyerService.GetLawyerDetailPassiveDto().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void LawyerListForm_Load(object sender, EventArgs e)
        {
            GetAllLawyerActiveDetailDto();
        }

        private void bandedGridViewLawyers_DoubleClick(object sender, EventArgs e)
        {
            LawyerEditForm.LawyerId = Convert.ToInt32(bandedGridViewLawyers.GetFocusedRowCellValue("Id").ToString());
            CreateForms<LawyerEditForm>.ShowDialogEditForm();
            GetAllLawyerActiveDetailDto();
        }
    }
}