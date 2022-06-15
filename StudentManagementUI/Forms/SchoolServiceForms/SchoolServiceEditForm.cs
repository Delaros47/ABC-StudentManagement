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

namespace StudentManagementUI.Forms.SchoolServiceForms
{
    public partial class SchoolServiceEditForm : BaseEditForm
    {
        public static int SchoolServiceId = -1;
        private readonly ISchoolServiceService _schoolServiceService;
        public SchoolServiceEditForm()
        {
            InitializeComponent();
            _schoolServiceService = InstanceFactory.GetInstance<ISchoolServiceService>();
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
            string privateCode = _schoolServiceService.GetLastSchoolServicePrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _schoolServiceService.Add(new SchoolService
            {
                PrivateCode = txtPrivateCode.Text,
                SchoolServiceName = txtSchoolService.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
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
            var result = _schoolServiceService.Update(new SchoolService
            {
                Id = SchoolServiceId,
                PrivateCode = txtPrivateCode.Text,
                SchoolServiceName = txtSchoolService.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void SchoolServiceEditForm_Load(object sender, EventArgs e)
        {
            if (SchoolServiceId != -1)
            {
                var result = _schoolServiceService.Get(SchoolServiceId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtSchoolService.Text = result.Data.SchoolServiceName;
                    txtPrice.Text = result.Data.Price.ToString();
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