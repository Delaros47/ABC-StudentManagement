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

namespace StudentManagementUI.Forms.PromotionForms
{
    public partial class PromotionListForm : BaseListForm
    {
        private readonly IPromotionService _promotionService;
        public PromotionListForm()
        {
            InitializeComponent();
            _promotionService = InstanceFactory.GetInstance<IPromotionService>();
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Promotion");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _promotionService.Delete(new Promotion
                {
                    Id = Convert.ToInt32(gridViewPromotions.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllPromotionActive();
                }
            }
        }

        private void GetAllPromotionActive()
        {
            gridControlPromotions.DataSource = _promotionService.GetPromotionActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            PromotionEditForm.PromotionId = -1;
            CreateForms<PromotionEditForm>.ShowDialogEditForm();
            GetAllPromotionActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            PromotionEditForm.PromotionId = Convert.ToInt32(gridViewPromotions.GetFocusedRowCellValue("Id").ToString());
            CreateForms<PromotionEditForm>.ShowDialogEditForm();
            GetAllPromotionActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllPromotionActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlPromotions.DataSource = _promotionService.GetPromotionActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlPromotions.DataSource = _promotionService.GetPromotionPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }


        private void PromotionListForm_Load(object sender, EventArgs e)
        {
            GetAllPromotionActive();
        }

        private void gridViewPromotions_DoubleClick(object sender, EventArgs e)
        {
            PromotionEditForm.PromotionId = Convert.ToInt32(gridViewPromotions.GetFocusedRowCellValue("Id").ToString());
            CreateForms<PromotionEditForm>.ShowDialogEditForm();
            GetAllPromotionActive();
        }
    }
}