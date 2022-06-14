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

namespace StudentManagementUI.Forms.DiscountTypeForms
{
    public partial class DiscountTypeEditForm : BaseEditForm
    {
        public static int DiscountTypeId = -1;
        private readonly IDiscountTypeService _discountTypeService;
        public DiscountTypeEditForm()
        {
            InitializeComponent();
            _discountTypeService = InstanceFactory.GetInstance<IDiscountTypeService>();
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
            if (_discountTypeService.GetLastDiscountTypePrivateCode().Data!=null)
            {
                string privateCode = _discountTypeService.GetLastDiscountTypePrivateCode().Data.PrivateCode;
                txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);
            }
            
        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _discountTypeService.Add(new DiscountType
            {
                PrivateCode = txtPrivateCode.Text,
                DiscountTypeName = txtDiscountType.Text,
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
            var result = _discountTypeService.Update(new DiscountType
            {
                Id = DiscountTypeId,
                PrivateCode = txtPrivateCode.Text,
                DiscountTypeName = txtDiscountType.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void DiscountTypeEditForm_Load(object sender, EventArgs e)
        {
            if (DiscountTypeId != -1)
            {
                var result = _discountTypeService.Get(DiscountTypeId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtDiscountType.Text = result.Data.DiscountTypeName;
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