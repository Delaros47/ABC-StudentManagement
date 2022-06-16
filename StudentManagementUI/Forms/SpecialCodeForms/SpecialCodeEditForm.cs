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

namespace StudentManagementUI.Forms.SpecialCodeForms
{
    public partial class SpecialCodeEditForm : BaseEditForm
    {
        public static int SpecialCodeId = -1;
        private readonly ISpecialCodeService _specialCodeService;
        public SpecialCodeEditForm()
        {
            InitializeComponent();
            _specialCodeService = InstanceFactory.GetInstance<ISpecialCodeService>();
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
            string privateCode = _specialCodeService.GetLastSpecialCodePrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _specialCodeService.Add(new SpecialCode
            {
                PrivateCode = txtPrivateCode.Text,
                SpecialCodeName = txtSpecialCode.Text,
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
            var result = _specialCodeService.Update(new SpecialCode
            {
                Id = SpecialCodeId,
                PrivateCode = txtPrivateCode.Text,
                SpecialCodeName = txtSpecialCode.Text,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void SpecialCodeEditForm_Load(object sender, EventArgs e)
        {
            if (SpecialCodeId != -1)
            {
                var result = _specialCodeService.Get(SpecialCodeId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtSpecialCode.Text = result.Data.SpecialCodeName;
                    txtDescription.Text = result.Data.Description;
                }
            }
            else
            {
                GeneratePrivateCode();
            }
        }
    }
}