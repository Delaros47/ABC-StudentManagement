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
    public partial class DutyEditForm : BaseEditForm
    {
        public static int WorkplaceId = -1;
        private readonly IWorkplaceService _workplaceService;
        public DutyEditForm()
        {
            InitializeComponent();
            _workplaceService = InstanceFactory.GetInstance<IWorkplaceService>();
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
            string privateCode = _workplaceService.GetLastWorkplacePrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _workplaceService.Add(new Workplace
            {
                PrivateCode = txtPrivateCode.Text,
                WorkplaceName = txtWorkplaceName.Text,
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
            var result = _workplaceService.Update(new Workplace
            {
                Id = WorkplaceId,
                PrivateCode = txtPrivateCode.Text,
                WorkplaceName = txtWorkplaceName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void WorkplaceEditForm_Load(object sender, EventArgs e)
        {
            if (WorkplaceId != -1)
            {
                var result = _workplaceService.Get(WorkplaceId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtWorkplaceName.Text = result.Data.WorkplaceName;
                    txtDescription.Text = result.Data.Description;
                    tglState.IsOn = result.Data.State;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }
    }
}