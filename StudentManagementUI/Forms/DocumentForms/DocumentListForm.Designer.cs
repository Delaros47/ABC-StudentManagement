namespace StudentManagementUI.Forms.DocumentForms
{
    partial class DocumentListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.longNavigator1 = new StudentManagementUI.UserControls.Navigators.LongNavigator();
            this.gridControlDocuments = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewDocuments = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDocumentName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 340);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1120, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // gridControlDocuments
            // 
            this.gridControlDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDocuments.Location = new System.Drawing.Point(0, 102);
            this.gridControlDocuments.MainView = this.gridViewDocuments;
            this.gridControlDocuments.MenuManager = this.ribbonControl;
            this.gridControlDocuments.Name = "gridControlDocuments";
            this.gridControlDocuments.Size = new System.Drawing.Size(1120, 238);
            this.gridControlDocuments.TabIndex = 3;
            this.gridControlDocuments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDocuments});
            // 
            // gridViewDocuments
            // 
            this.gridViewDocuments.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewDocuments.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDocuments.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDocuments.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDocuments.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDocuments.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDocuments.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDocuments.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDocuments.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDocuments.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewDocuments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colDocumentName,
            this.colDescription});
            this.gridViewDocuments.GridControl = this.gridControlDocuments;
            this.gridViewDocuments.Name = "gridViewDocuments";
            this.gridViewDocuments.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDocuments.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDocuments.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDocuments.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewDocuments.OptionsPrint.AutoWidth = false;
            this.gridViewDocuments.OptionsPrint.PrintFooter = false;
            this.gridViewDocuments.OptionsPrint.PrintGroupFooter = false;
            this.gridViewDocuments.OptionsView.ColumnAutoWidth = false;
            this.gridViewDocuments.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDocuments.OptionsView.RowAutoHeight = true;
            this.gridViewDocuments.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDocuments.OptionsView.ShowGroupPanel = false;
            this.gridViewDocuments.OptionsView.ShowViewCaption = true;
            this.gridViewDocuments.StatusBarDescription = null;
            this.gridViewDocuments.StatusBarShortcut = null;
            this.gridViewDocuments.StatusBarShortcutDescription = null;
            this.gridViewDocuments.ViewCaption = "Documents";
            this.gridViewDocuments.DoubleClick += new System.EventHandler(this.gridViewDocuments_DoubleClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarDescription = null;
            this.colId.StatusBarShortcut = null;
            this.colId.StatusBarShortcutDescription = null;
            // 
            // colPrivateCode
            // 
            this.colPrivateCode.AppearanceCell.Options.UseTextOptions = true;
            this.colPrivateCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrivateCode.Caption = "Private Code";
            this.colPrivateCode.FieldName = "PrivateCode";
            this.colPrivateCode.Name = "colPrivateCode";
            this.colPrivateCode.OptionsColumn.AllowEdit = false;
            this.colPrivateCode.StatusBarDescription = null;
            this.colPrivateCode.StatusBarShortcut = null;
            this.colPrivateCode.StatusBarShortcutDescription = null;
            this.colPrivateCode.Visible = true;
            this.colPrivateCode.VisibleIndex = 0;
            this.colPrivateCode.Width = 150;
            // 
            // colDocumentName
            // 
            this.colDocumentName.Caption = "Document Name";
            this.colDocumentName.FieldName = "DocumentName";
            this.colDocumentName.Name = "colDocumentName";
            this.colDocumentName.OptionsColumn.AllowEdit = false;
            this.colDocumentName.StatusBarDescription = null;
            this.colDocumentName.StatusBarShortcut = null;
            this.colDocumentName.StatusBarShortcutDescription = null;
            this.colDocumentName.Visible = true;
            this.colDocumentName.VisibleIndex = 1;
            this.colDocumentName.Width = 350;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.StatusBarDescription = null;
            this.colDescription.StatusBarShortcut = null;
            this.colDescription.StatusBarShortcutDescription = null;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 450;
            // 
            // DocumentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlDocuments);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "DocumentListForm";
            this.Text = "Document List";
            this.Load += new System.EventHandler(this.DocumentListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlDocuments, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlDocuments;
        private UserControls.Grids.MyGridView gridViewDocuments;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colDocumentName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}