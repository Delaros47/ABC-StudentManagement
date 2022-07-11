using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementUI.Commons.Functions;

namespace StudentManagementUI.Forms.DocumentForms
{
    public partial class DocumentListForm : BaseListForm
    {
        private readonly IDocumentService _documentService;
        public DocumentListForm()
        {
            InitializeComponent();
            _documentService = InstanceFactory.GetInstance<IDocumentService>();
            longNavigator.controlNavigator.NavigatableControl = gridControlDocuments;
        }


        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogresult = MyMessagesBox.DeletedMessage("Document");
            if (dialogresult == DialogResult.Yes)
            {
                var result = _documentService.Delete(new Document
                {
                    Id = Convert.ToInt32(gridViewDocuments.GetFocusedRowCellValue("Id").ToString())
                });
                if (result.Success)
                {
                    MyMessagesBox.DeleteMessage(result.Message);
                    GetAllDocumentActive();
                }
            }
        }

        private void GetAllDocumentActive()
        {
            gridControlDocuments.DataSource = _documentService.GetDocumentActive().Data;
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocumentEditForm.DocumentId = -1;
            CreateForms<DocumentEditForm>.ShowDialogEditForm();
            GetAllDocumentActive();
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocumentEditForm.DocumentId = Convert.ToInt32(gridViewDocuments.GetFocusedRowCellValue("Id").ToString());
            CreateForms<DocumentEditForm>.ShowDialogEditForm();
            GetAllDocumentActive();
        }

        protected override void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetAllDocumentActive();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption == "Passive List")
            {
                gridControlDocuments.DataSource = _documentService.GetDocumentActive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlDocuments.DataSource = _documentService.GetDocumentPassive().Data;
                e.Item.Caption = "Passive List";
            }
        }

        private void DocumentListForm_Load(object sender, EventArgs e)
        {
            GetAllDocumentActive();
        }

        private void gridViewDocuments_DoubleClick(object sender, EventArgs e)
        {
            DocumentEditForm.DocumentId = Convert.ToInt32(gridViewDocuments.GetFocusedRowCellValue("Id").ToString());
            CreateForms<DocumentEditForm>.ShowDialogEditForm();
            GetAllDocumentActive();
        }
    }
}