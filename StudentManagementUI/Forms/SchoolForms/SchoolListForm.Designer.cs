namespace StudentManagementUI.Forms.SchoolForms
{
    partial class SchoolListForm
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
            this.gridControlSchoolList = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewSchoolList = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colSchoolName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colCityName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDistrictName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchoolList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchoolList)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1110, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 342);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1110, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // gridControlSchoolList
            // 
            this.gridControlSchoolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSchoolList.Location = new System.Drawing.Point(0, 102);
            this.gridControlSchoolList.MainView = this.gridViewSchoolList;
            this.gridControlSchoolList.MenuManager = this.ribbonControl;
            this.gridControlSchoolList.Name = "gridControlSchoolList";
            this.gridControlSchoolList.Size = new System.Drawing.Size(1110, 240);
            this.gridControlSchoolList.TabIndex = 3;
            this.gridControlSchoolList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSchoolList});
            this.gridControlSchoolList.DoubleClick += new System.EventHandler(this.gridControlSchoolList_DoubleClick);
            // 
            // gridViewSchoolList
            // 
            this.gridViewSchoolList.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewSchoolList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchoolList.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewSchoolList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewSchoolList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchoolList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSchoolList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSchoolList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSchoolList.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchoolList.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewSchoolList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colSchoolName,
            this.colCityName,
            this.colDistrictName,
            this.colDescription});
            this.gridViewSchoolList.GridControl = this.gridControlSchoolList;
            this.gridViewSchoolList.Name = "gridViewSchoolList";
            this.gridViewSchoolList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSchoolList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSchoolList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSchoolList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSchoolList.OptionsPrint.AutoWidth = false;
            this.gridViewSchoolList.OptionsPrint.PrintFooter = false;
            this.gridViewSchoolList.OptionsPrint.PrintGroupFooter = false;
            this.gridViewSchoolList.OptionsView.ColumnAutoWidth = false;
            this.gridViewSchoolList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewSchoolList.OptionsView.RowAutoHeight = true;
            this.gridViewSchoolList.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSchoolList.OptionsView.ShowGroupPanel = false;
            this.gridViewSchoolList.OptionsView.ShowViewCaption = true;
            this.gridViewSchoolList.StatusBarDescription = null;
            this.gridViewSchoolList.StatusBarShortcut = null;
            this.gridViewSchoolList.StatusBarShortcutDescription = null;
            this.gridViewSchoolList.ViewCaption = "Schools";
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
            this.colPrivateCode.Width = 130;
            // 
            // colSchoolName
            // 
            this.colSchoolName.Caption = "School Name";
            this.colSchoolName.FieldName = "SchoolName";
            this.colSchoolName.Name = "colSchoolName";
            this.colSchoolName.OptionsColumn.AllowEdit = false;
            this.colSchoolName.StatusBarDescription = null;
            this.colSchoolName.StatusBarShortcut = null;
            this.colSchoolName.StatusBarShortcutDescription = null;
            this.colSchoolName.Visible = true;
            this.colSchoolName.VisibleIndex = 1;
            this.colSchoolName.Width = 250;
            // 
            // colCityName
            // 
            this.colCityName.Caption = "City";
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.OptionsColumn.AllowEdit = false;
            this.colCityName.StatusBarDescription = null;
            this.colCityName.StatusBarShortcut = null;
            this.colCityName.StatusBarShortcutDescription = null;
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 2;
            this.colCityName.Width = 125;
            // 
            // colDistrictName
            // 
            this.colDistrictName.Caption = "District";
            this.colDistrictName.FieldName = "DistrictName";
            this.colDistrictName.Name = "colDistrictName";
            this.colDistrictName.OptionsColumn.AllowEdit = false;
            this.colDistrictName.StatusBarDescription = null;
            this.colDistrictName.StatusBarShortcut = null;
            this.colDistrictName.StatusBarShortcutDescription = null;
            this.colDistrictName.Visible = true;
            this.colDistrictName.VisibleIndex = 3;
            this.colDistrictName.Width = 125;
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
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 450;
            // 
            // SchoolListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 399);
            this.Controls.Add(this.gridControlSchoolList);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "SchoolListForm";
            this.Text = "School List";
            this.Load += new System.EventHandler(this.SchoolListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlSchoolList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchoolList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchoolList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlSchoolList;
        private UserControls.Grids.MyGridView gridViewSchoolList;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colSchoolName;
        private UserControls.Grids.MyGridColumn colCityName;
        private UserControls.Grids.MyGridColumn colDistrictName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}