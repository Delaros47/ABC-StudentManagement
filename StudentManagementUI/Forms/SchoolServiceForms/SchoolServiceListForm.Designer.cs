namespace StudentManagementUI.Forms.SchoolServiceForms
{
    partial class SchoolServiceListForm
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
            this.longNavigator = new StudentManagementUI.UserControls.Navigators.LongNavigator();
            this.gridControlSchoolServices = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewSchoolServices = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colSchoolServiceName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrice = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchoolServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchoolServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1167, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 338);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1167, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // gridControlSchoolServices
            // 
            this.gridControlSchoolServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSchoolServices.Location = new System.Drawing.Point(0, 102);
            this.gridControlSchoolServices.MainView = this.gridViewSchoolServices;
            this.gridControlSchoolServices.MenuManager = this.ribbonControl;
            this.gridControlSchoolServices.Name = "gridControlSchoolServices";
            this.gridControlSchoolServices.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit});
            this.gridControlSchoolServices.Size = new System.Drawing.Size(1167, 236);
            this.gridControlSchoolServices.TabIndex = 3;
            this.gridControlSchoolServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSchoolServices});
            this.gridControlSchoolServices.DoubleClick += new System.EventHandler(this.gridControlSchoolServices_DoubleClick);
            // 
            // gridViewSchoolServices
            // 
            this.gridViewSchoolServices.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewSchoolServices.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchoolServices.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewSchoolServices.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewSchoolServices.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchoolServices.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSchoolServices.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSchoolServices.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSchoolServices.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchoolServices.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewSchoolServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colSchoolServiceName,
            this.colPrice,
            this.colDescription});
            this.gridViewSchoolServices.GridControl = this.gridControlSchoolServices;
            this.gridViewSchoolServices.Name = "gridViewSchoolServices";
            this.gridViewSchoolServices.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSchoolServices.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSchoolServices.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSchoolServices.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSchoolServices.OptionsPrint.AutoWidth = false;
            this.gridViewSchoolServices.OptionsPrint.PrintFooter = false;
            this.gridViewSchoolServices.OptionsPrint.PrintGroupFooter = false;
            this.gridViewSchoolServices.OptionsView.ColumnAutoWidth = false;
            this.gridViewSchoolServices.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewSchoolServices.OptionsView.RowAutoHeight = true;
            this.gridViewSchoolServices.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSchoolServices.OptionsView.ShowGroupPanel = false;
            this.gridViewSchoolServices.OptionsView.ShowViewCaption = true;
            this.gridViewSchoolServices.StatusBarDescription = null;
            this.gridViewSchoolServices.StatusBarShortcut = null;
            this.gridViewSchoolServices.StatusBarShortcutDescription = null;
            this.gridViewSchoolServices.ViewCaption = "School Services";
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
            // colSchoolServiceName
            // 
            this.colSchoolServiceName.Caption = "School Service Name";
            this.colSchoolServiceName.FieldName = "SchoolServiceName";
            this.colSchoolServiceName.Name = "colSchoolServiceName";
            this.colSchoolServiceName.OptionsColumn.AllowEdit = false;
            this.colSchoolServiceName.StatusBarDescription = null;
            this.colSchoolServiceName.StatusBarShortcut = null;
            this.colSchoolServiceName.StatusBarShortcutDescription = null;
            this.colSchoolServiceName.Visible = true;
            this.colSchoolServiceName.VisibleIndex = 1;
            this.colSchoolServiceName.Width = 350;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.ColumnEdit = this.repositoryItemCalcEdit;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.StatusBarDescription = null;
            this.colPrice.StatusBarShortcut = null;
            this.colPrice.StatusBarShortcutDescription = null;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 150;
            // 
            // repositoryItemCalcEdit
            // 
            this.repositoryItemCalcEdit.AutoHeight = false;
            this.repositoryItemCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit.DisplayFormat.FormatString = "n2";
            this.repositoryItemCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit.MaskSettings.Set("mask", "n2");
            this.repositoryItemCalcEdit.Name = "repositoryItemCalcEdit";
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
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 450;
            // 
            // SchoolServiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 395);
            this.Controls.Add(this.gridControlSchoolServices);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "SchoolServiceListForm";
            this.Text = "School Service List";
            this.Load += new System.EventHandler(this.SchoolServiceListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlSchoolServices, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchoolServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchoolServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlSchoolServices;
        private UserControls.Grids.MyGridView gridViewSchoolServices;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colSchoolServiceName;
        private UserControls.Grids.MyGridColumn colPrice;
        private UserControls.Grids.MyGridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit;
    }
}