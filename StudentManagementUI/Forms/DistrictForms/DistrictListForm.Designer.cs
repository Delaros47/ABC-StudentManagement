namespace StudentManagementUI.Forms.DistrictForms
{
    partial class DistrictListForm
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
            this.gridControlDistricts = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewDistricts = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDistrictName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDistricts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDistricts)).BeginInit();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 340);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1120, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // gridControlDistricts
            // 
            this.gridControlDistricts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDistricts.Location = new System.Drawing.Point(0, 102);
            this.gridControlDistricts.MainView = this.gridViewDistricts;
            this.gridControlDistricts.MenuManager = this.ribbonControl;
            this.gridControlDistricts.Name = "gridControlDistricts";
            this.gridControlDistricts.Size = new System.Drawing.Size(1120, 238);
            this.gridControlDistricts.TabIndex = 3;
            this.gridControlDistricts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDistricts});
            // 
            // gridViewDistricts
            // 
            this.gridViewDistricts.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewDistricts.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDistricts.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDistricts.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDistricts.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDistricts.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDistricts.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDistricts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDistricts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDistricts.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewDistricts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colDistrictName,
            this.colDescription});
            this.gridViewDistricts.GridControl = this.gridControlDistricts;
            this.gridViewDistricts.Name = "gridViewDistricts";
            this.gridViewDistricts.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDistricts.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDistricts.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDistricts.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewDistricts.OptionsPrint.AutoWidth = false;
            this.gridViewDistricts.OptionsPrint.PrintFooter = false;
            this.gridViewDistricts.OptionsPrint.PrintGroupFooter = false;
            this.gridViewDistricts.OptionsView.ColumnAutoWidth = false;
            this.gridViewDistricts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDistricts.OptionsView.RowAutoHeight = true;
            this.gridViewDistricts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDistricts.OptionsView.ShowGroupPanel = false;
            this.gridViewDistricts.OptionsView.ShowViewCaption = true;
            this.gridViewDistricts.StatusBarDescription = null;
            this.gridViewDistricts.StatusBarShortcut = null;
            this.gridViewDistricts.StatusBarShortcutDescription = null;
            this.gridViewDistricts.ViewCaption = "Districts";
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
            // colDistrictName
            // 
            this.colDistrictName.Caption = "District Name";
            this.colDistrictName.FieldName = "DistrictName";
            this.colDistrictName.Name = "colDistrictName";
            this.colDistrictName.OptionsColumn.AllowEdit = false;
            this.colDistrictName.StatusBarDescription = null;
            this.colDistrictName.StatusBarShortcut = null;
            this.colDistrictName.StatusBarShortcutDescription = null;
            this.colDistrictName.Visible = true;
            this.colDistrictName.VisibleIndex = 1;
            this.colDistrictName.Width = 250;
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
            // DistrictListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlDistricts);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "DistrictListForm";
            this.Text = "District List";
            this.Load += new System.EventHandler(this.DistrictListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlDistricts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDistricts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDistricts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlDistricts;
        private UserControls.Grids.MyGridView gridViewDistricts;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colDistrictName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}