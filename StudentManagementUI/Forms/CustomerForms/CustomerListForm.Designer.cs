namespace StudentManagementUI.Forms.CustomerForms
{
    partial class CustomerListForm
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
            this.bandedGridControlCustomers = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewCustomers = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdentityNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colCustomerName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colTaxNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colAddress = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWeb = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colFax = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colEmail = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colTaxOffice = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPhone1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPhone2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPhone3 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPhone4 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewCustomers)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1278, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 338);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1278, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // bandedGridControlCustomers
            // 
            this.bandedGridControlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlCustomers.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlCustomers.MainView = this.bandedGridViewCustomers;
            this.bandedGridControlCustomers.MenuManager = this.ribbonControl;
            this.bandedGridControlCustomers.Name = "bandedGridControlCustomers";
            this.bandedGridControlCustomers.Size = new System.Drawing.Size(1278, 236);
            this.bandedGridControlCustomers.TabIndex = 3;
            this.bandedGridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewCustomers});
            // 
            // bandedGridViewCustomers
            // 
            this.bandedGridViewCustomers.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewCustomers.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewCustomers.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewCustomers.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewCustomers.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewCustomers.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewCustomers.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewCustomers.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewCustomers.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewCustomers.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewCustomers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewCustomers.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewCustomers.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewCustomers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewCustomers.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewCustomers.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewCustomers.BandPanelRowHeight = 40;
            this.bandedGridViewCustomers.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colCustomerName,
            this.colIdentityNumber,
            this.colPhone1,
            this.colPhone2,
            this.colPhone3,
            this.colPhone4,
            this.colFax,
            this.colWeb,
            this.colEmail,
            this.colTaxOffice,
            this.colTaxNumber,
            this.colAddress,
            this.colDescription,
            this.colSpecialCode1,
            this.colSpecialCode2});
            this.bandedGridViewCustomers.GridControl = this.bandedGridControlCustomers;
            this.bandedGridViewCustomers.Name = "bandedGridViewCustomers";
            this.bandedGridViewCustomers.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewCustomers.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewCustomers.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewCustomers.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewCustomers.OptionsPrint.AutoWidth = false;
            this.bandedGridViewCustomers.OptionsPrint.PrintFooter = false;
            this.bandedGridViewCustomers.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewCustomers.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewCustomers.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewCustomers.OptionsView.RowAutoHeight = true;
            this.bandedGridViewCustomers.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewCustomers.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewCustomers.OptionsView.ShowViewCaption = true;
            this.bandedGridViewCustomers.StatusBarDescription = null;
            this.bandedGridViewCustomers.StatusBarShortcut = null;
            this.bandedGridViewCustomers.StatusBarShortcutDescription = null;
            this.bandedGridViewCustomers.ViewCaption = "Customers";
            this.bandedGridViewCustomers.DoubleClick += new System.EventHandler(this.bandedGridViewCustomers_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Customer Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colIdentityNumber);
            this.gridBand1.Columns.Add(this.colCustomerName);
            this.gridBand1.Columns.Add(this.colTaxNumber);
            this.gridBand1.Columns.Add(this.colAddress);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Columns.Add(this.colFax);
            this.gridBand1.Columns.Add(this.colEmail);
            this.gridBand1.Columns.Add(this.colTaxOffice);
            this.gridBand1.Columns.Add(this.colPhone1);
            this.gridBand1.Columns.Add(this.colPhone2);
            this.gridBand1.Columns.Add(this.colPhone3);
            this.gridBand1.Columns.Add(this.colPhone4);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1950;
            // 
            // colPrivateCode
            // 
            this.colPrivateCode.AppearanceCell.Options.UseTextOptions = true;
            this.colPrivateCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrivateCode.Caption = "Private Code";
            this.colPrivateCode.FieldName = "PrivateCode";
            this.colPrivateCode.Name = "colPrivateCode";
            this.colPrivateCode.OptionsColumn.AllowEdit = false;
            this.colPrivateCode.Visible = true;
            this.colPrivateCode.Width = 150;
            // 
            // colIdentityNumber
            // 
            this.colIdentityNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colIdentityNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdentityNumber.Caption = "Identity Number";
            this.colIdentityNumber.FieldName = "IdentityNumber";
            this.colIdentityNumber.Name = "colIdentityNumber";
            this.colIdentityNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityNumber.StatusBarDescription = null;
            this.colIdentityNumber.StatusBarShortcut = null;
            this.colIdentityNumber.StatusBarShortcutDescription = null;
            this.colIdentityNumber.Visible = true;
            this.colIdentityNumber.Width = 150;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name Surname";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.StatusBarDescription = null;
            this.colCustomerName.StatusBarShortcut = null;
            this.colCustomerName.StatusBarShortcutDescription = null;
            this.colCustomerName.Visible = true;
            this.colCustomerName.Width = 150;
            // 
            // colTaxNumber
            // 
            this.colTaxNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colTaxNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaxNumber.Caption = "Tax Number";
            this.colTaxNumber.FieldName = "TaxNumber";
            this.colTaxNumber.Name = "colTaxNumber";
            this.colTaxNumber.OptionsColumn.AllowEdit = false;
            this.colTaxNumber.StatusBarDescription = null;
            this.colTaxNumber.StatusBarShortcut = null;
            this.colTaxNumber.StatusBarShortcutDescription = null;
            this.colTaxNumber.Visible = true;
            this.colTaxNumber.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.StatusBarDescription = null;
            this.colAddress.StatusBarShortcut = null;
            this.colAddress.StatusBarShortcutDescription = null;
            this.colAddress.Visible = true;
            this.colAddress.Width = 200;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web Address";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarDescription = null;
            this.colWeb.StatusBarShortcut = null;
            this.colWeb.StatusBarShortcutDescription = null;
            this.colWeb.Visible = true;
            this.colWeb.Width = 150;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.StatusBarDescription = null;
            this.colFax.StatusBarShortcut = null;
            this.colFax.StatusBarShortcutDescription = null;
            this.colFax.Visible = true;
            this.colFax.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email Address";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarDescription = null;
            this.colEmail.StatusBarShortcut = null;
            this.colEmail.StatusBarShortcutDescription = null;
            this.colEmail.Visible = true;
            this.colEmail.Width = 150;
            // 
            // colTaxOffice
            // 
            this.colTaxOffice.Caption = "Tax Office";
            this.colTaxOffice.FieldName = "TaxOffice";
            this.colTaxOffice.Name = "colTaxOffice";
            this.colTaxOffice.OptionsColumn.AllowEdit = false;
            this.colTaxOffice.StatusBarDescription = null;
            this.colTaxOffice.StatusBarShortcut = null;
            this.colTaxOffice.StatusBarShortcutDescription = null;
            this.colTaxOffice.Visible = true;
            this.colTaxOffice.Width = 150;
            // 
            // colPhone1
            // 
            this.colPhone1.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone1.Caption = "Phone-1";
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowEdit = false;
            this.colPhone1.StatusBarDescription = null;
            this.colPhone1.StatusBarShortcut = null;
            this.colPhone1.StatusBarShortcutDescription = null;
            this.colPhone1.Visible = true;
            this.colPhone1.Width = 100;
            // 
            // colPhone2
            // 
            this.colPhone2.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone2.Caption = "Phone-2";
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowEdit = false;
            this.colPhone2.StatusBarDescription = null;
            this.colPhone2.StatusBarShortcut = null;
            this.colPhone2.StatusBarShortcutDescription = null;
            this.colPhone2.Visible = true;
            this.colPhone2.Width = 150;
            // 
            // colPhone3
            // 
            this.colPhone3.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone3.Caption = "Phone-3";
            this.colPhone3.FieldName = "Phone3";
            this.colPhone3.Name = "colPhone3";
            this.colPhone3.OptionsColumn.AllowEdit = false;
            this.colPhone3.StatusBarDescription = null;
            this.colPhone3.StatusBarShortcut = null;
            this.colPhone3.StatusBarShortcutDescription = null;
            this.colPhone3.Visible = true;
            this.colPhone3.Width = 150;
            // 
            // colPhone4
            // 
            this.colPhone4.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone4.Caption = "Phone-4";
            this.colPhone4.FieldName = "Phone4";
            this.colPhone4.Name = "colPhone4";
            this.colPhone4.OptionsColumn.AllowEdit = false;
            this.colPhone4.StatusBarDescription = null;
            this.colPhone4.StatusBarShortcut = null;
            this.colPhone4.StatusBarShortcutDescription = null;
            this.colPhone4.Visible = true;
            this.colPhone4.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Special Codes";
            this.gridBand2.Columns.Add(this.colSpecialCode1);
            this.gridBand2.Columns.Add(this.colSpecialCode2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 300;
            // 
            // colSpecialCode1
            // 
            this.colSpecialCode1.Caption = "Special Code-1";
            this.colSpecialCode1.FieldName = "SpecialCode1";
            this.colSpecialCode1.Name = "colSpecialCode1";
            this.colSpecialCode1.OptionsColumn.AllowEdit = false;
            this.colSpecialCode1.StatusBarDescription = null;
            this.colSpecialCode1.StatusBarShortcut = null;
            this.colSpecialCode1.StatusBarShortcutDescription = null;
            this.colSpecialCode1.Visible = true;
            this.colSpecialCode1.Width = 150;
            // 
            // colSpecialCode2
            // 
            this.colSpecialCode2.Caption = "Special Code-2";
            this.colSpecialCode2.FieldName = "SpecialCode2";
            this.colSpecialCode2.Name = "colSpecialCode2";
            this.colSpecialCode2.OptionsColumn.AllowEdit = false;
            this.colSpecialCode2.StatusBarDescription = null;
            this.colSpecialCode2.StatusBarShortcut = null;
            this.colSpecialCode2.StatusBarShortcutDescription = null;
            this.colSpecialCode2.Visible = true;
            this.colSpecialCode2.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Others";
            this.gridBand3.Columns.Add(this.colDescription);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
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
            this.colDescription.Width = 300;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 395);
            this.Controls.Add(this.bandedGridControlCustomers);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CustomerListForm";
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.bandedGridControlCustomers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl bandedGridControlCustomers;
        private UserControls.Grids.MyBandedGridView bandedGridViewCustomers;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colCustomerName;
        private UserControls.Grids.MyBandedGridColumn colIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colPhone1;
        private UserControls.Grids.MyBandedGridColumn colPhone2;
        private UserControls.Grids.MyBandedGridColumn colPhone3;
        private UserControls.Grids.MyBandedGridColumn colPhone4;
        private UserControls.Grids.MyBandedGridColumn colFax;
        private UserControls.Grids.MyBandedGridColumn colWeb;
        private UserControls.Grids.MyBandedGridColumn colEmail;
        private UserControls.Grids.MyBandedGridColumn colTaxOffice;
        private UserControls.Grids.MyBandedGridColumn colTaxNumber;
        private UserControls.Grids.MyBandedGridColumn colAddress;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}