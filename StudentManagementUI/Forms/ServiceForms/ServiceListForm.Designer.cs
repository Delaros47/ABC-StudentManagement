namespace StudentManagementUI.Forms.ServiceForms
{
    partial class ServiceListForm
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
            this.gridControlServices = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewServices = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colServiceName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colServiceTypeName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colStartDate = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colEndDate = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrice = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1253, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 340);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1253, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // gridControlServices
            // 
            this.gridControlServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlServices.Location = new System.Drawing.Point(0, 102);
            this.gridControlServices.MainView = this.gridViewServices;
            this.gridControlServices.MenuManager = this.ribbonControl;
            this.gridControlServices.Name = "gridControlServices";
            this.gridControlServices.Size = new System.Drawing.Size(1253, 238);
            this.gridControlServices.TabIndex = 3;
            this.gridControlServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});
            // 
            // gridViewServices
            // 
            this.gridViewServices.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewServices.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewServices.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewServices.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewServices.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewServices.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewServices.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewServices.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewServices.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewServices.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colServiceName,
            this.colServiceTypeName,
            this.colStartDate,
            this.colEndDate,
            this.colPrice,
            this.colDescription});
            this.gridViewServices.GridControl = this.gridControlServices;
            this.gridViewServices.Name = "gridViewServices";
            this.gridViewServices.OptionsMenu.EnableColumnMenu = false;
            this.gridViewServices.OptionsMenu.EnableFooterMenu = false;
            this.gridViewServices.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewServices.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewServices.OptionsPrint.AutoWidth = false;
            this.gridViewServices.OptionsPrint.PrintFooter = false;
            this.gridViewServices.OptionsPrint.PrintGroupFooter = false;
            this.gridViewServices.OptionsView.ColumnAutoWidth = false;
            this.gridViewServices.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewServices.OptionsView.RowAutoHeight = true;
            this.gridViewServices.OptionsView.ShowAutoFilterRow = true;
            this.gridViewServices.OptionsView.ShowGroupPanel = false;
            this.gridViewServices.OptionsView.ShowViewCaption = true;
            this.gridViewServices.StatusBarDescription = null;
            this.gridViewServices.StatusBarShortcut = null;
            this.gridViewServices.StatusBarShortcutDescription = null;
            this.gridViewServices.ViewCaption = "Services";
            this.gridViewServices.DoubleClick += new System.EventHandler(this.gridViewServices_DoubleClick);
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
            // colServiceName
            // 
            this.colServiceName.Caption = "Service Name";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.OptionsColumn.AllowEdit = false;
            this.colServiceName.StatusBarDescription = null;
            this.colServiceName.StatusBarShortcut = null;
            this.colServiceName.StatusBarShortcutDescription = null;
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 1;
            this.colServiceName.Width = 200;
            // 
            // colServiceTypeName
            // 
            this.colServiceTypeName.Caption = "Service Type Name";
            this.colServiceTypeName.FieldName = "ServiceTypeName";
            this.colServiceTypeName.Name = "colServiceTypeName";
            this.colServiceTypeName.OptionsColumn.AllowEdit = false;
            this.colServiceTypeName.StatusBarDescription = null;
            this.colServiceTypeName.StatusBarShortcut = null;
            this.colServiceTypeName.StatusBarShortcutDescription = null;
            this.colServiceTypeName.Visible = true;
            this.colServiceTypeName.VisibleIndex = 2;
            this.colServiceTypeName.Width = 200;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Start Date";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsColumn.AllowEdit = false;
            this.colStartDate.StatusBarDescription = null;
            this.colStartDate.StatusBarShortcut = null;
            this.colStartDate.StatusBarShortcutDescription = null;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            this.colStartDate.Width = 100;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "End Date";
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.OptionsColumn.AllowEdit = false;
            this.colEndDate.StatusBarDescription = null;
            this.colEndDate.StatusBarShortcut = null;
            this.colEndDate.StatusBarShortcutDescription = null;
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 4;
            this.colEndDate.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.StatusBarDescription = null;
            this.colPrice.StatusBarShortcut = null;
            this.colPrice.StatusBarShortcutDescription = null;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            this.colPrice.Width = 100;
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
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 350;
            // 
            // ServiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 395);
            this.Controls.Add(this.gridControlServices);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "ServiceListForm";
            this.Text = "Service List";
            this.Load += new System.EventHandler(this.ServiceListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlServices, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlServices;
        private UserControls.Grids.MyGridView gridViewServices;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colServiceName;
        private UserControls.Grids.MyGridColumn colServiceTypeName;
        private UserControls.Grids.MyGridColumn colStartDate;
        private UserControls.Grids.MyGridColumn colEndDate;
        private UserControls.Grids.MyGridColumn colPrice;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}