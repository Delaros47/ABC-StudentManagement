using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Commons.Functions;
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
using StudentManagementUI.Commons.Messages;

namespace StudentManagementUI.Forms.DocumentForms
{
    public partial class DocumentEditForm : BaseEditForm
    {
        public static int DocumentId = -1;
        private readonly IDocumentService _documentService;
        public DocumentEditForm()
        {
            InitializeComponent();
            _documentService = InstanceFactory.GetInstance<IDocumentService>();
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
            string privateCode = _documentService.GetLastDocumentPrivateCode().Data.PrivateCode;
            txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(privateCode);

        }

        private void CleanAllComponants()
        {
            ClearAll.Clean(myDataLayoutControl1);
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _documentService.Add(new Document
            {
                PrivateCode = txtPrivateCode.Text,
                DocumentName = txtDocumentName.Text,
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
            var result = _documentService.Update(new Document
            {
                Id = DocumentId,
                PrivateCode = txtPrivateCode.Text,
                DocumentName = txtDocumentName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessagesBox.UpdatedMessage(result.Message);
                CleanAllComponants();
            }
        }

        private void DocumentEditForm_Load(object sender, EventArgs e)
        {
            if (DocumentId != -1)
            {
                var result = _documentService.Get(DocumentId);
                if (result.Success)
                {
                    txtPrivateCode.Text = result.Data.PrivateCode;
                    txtDocumentName.Text = result.Data.DocumentName;
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