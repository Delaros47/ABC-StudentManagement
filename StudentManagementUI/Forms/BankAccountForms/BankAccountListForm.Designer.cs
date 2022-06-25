namespace StudentManagementUI.Forms.BankAccountForms
{
    partial class BankAccountListForm
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
            this.bandedGridControlBankAccounts = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewBankAccounts = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAccountName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colAccountType = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colBankName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colBankBranch = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAccountOpeningDate = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colBlockedDayNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colAccountNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colIbanNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWorkPlaceNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colTerminalNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewBankAccounts)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1303, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 338);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1303, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // bandedGridControlBankAccounts
            // 
            this.bandedGridControlBankAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlBankAccounts.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlBankAccounts.MainView = this.bandedGridViewBankAccounts;
            this.bandedGridControlBankAccounts.MenuManager = this.ribbonControl;
            this.bandedGridControlBankAccounts.Name = "bandedGridControlBankAccounts";
            this.bandedGridControlBankAccounts.Size = new System.Drawing.Size(1303, 236);
            this.bandedGridControlBankAccounts.TabIndex = 3;
            this.bandedGridControlBankAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewBankAccounts});
            // 
            // bandedGridViewBankAccounts
            // 
            this.bandedGridViewBankAccounts.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewBankAccounts.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewBankAccounts.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewBankAccounts.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewBankAccounts.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewBankAccounts.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewBankAccounts.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewBankAccounts.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewBankAccounts.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewBankAccounts.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewBankAccounts.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewBankAccounts.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewBankAccounts.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewBankAccounts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewBankAccounts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewBankAccounts.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewBankAccounts.BandPanelRowHeight = 40;
            this.bandedGridViewBankAccounts.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.bandedGridViewBankAccounts.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colAccountName,
            this.colAccountType,
            this.colBankName,
            this.colBankBranch,
            this.colAccountOpeningDate,
            this.colAccountNumber,
            this.colIbanNumber,
            this.colBlockedDayNumber,
            this.colWorkPlaceNumber,
            this.colTerminalNumber,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colDescription});
            this.bandedGridViewBankAccounts.GridControl = this.bandedGridControlBankAccounts;
            this.bandedGridViewBankAccounts.Name = "bandedGridViewBankAccounts";
            this.bandedGridViewBankAccounts.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewBankAccounts.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewBankAccounts.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewBankAccounts.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewBankAccounts.OptionsPrint.AutoWidth = false;
            this.bandedGridViewBankAccounts.OptionsPrint.PrintFooter = false;
            this.bandedGridViewBankAccounts.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewBankAccounts.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewBankAccounts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewBankAccounts.OptionsView.RowAutoHeight = true;
            this.bandedGridViewBankAccounts.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewBankAccounts.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewBankAccounts.OptionsView.ShowViewCaption = true;
            this.bandedGridViewBankAccounts.StatusBarDescription = null;
            this.bandedGridViewBankAccounts.StatusBarShortcut = null;
            this.bandedGridViewBankAccounts.StatusBarShortcutDescription = null;
            this.bandedGridViewBankAccounts.ViewCaption = "Bank Accounts";
            this.bandedGridViewBankAccounts.DoubleClick += new System.EventHandler(this.bandedGridViewBankAccounts_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Account Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colAccountName);
            this.gridBand1.Columns.Add(this.colAccountType);
            this.gridBand1.Columns.Add(this.colBankName);
            this.gridBand1.Columns.Add(this.colBankBranch);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 800;
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
            // colAccountName
            // 
            this.colAccountName.Caption = "Account Name";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.OptionsColumn.AllowEdit = false;
            this.colAccountName.StatusBarDescription = null;
            this.colAccountName.StatusBarShortcut = null;
            this.colAccountName.StatusBarShortcutDescription = null;
            this.colAccountName.Visible = true;
            this.colAccountName.Width = 200;
            // 
            // colAccountType
            // 
            this.colAccountType.Caption = "Account Type";
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.OptionsColumn.AllowEdit = false;
            this.colAccountType.StatusBarDescription = null;
            this.colAccountType.StatusBarShortcut = null;
            this.colAccountType.StatusBarShortcutDescription = null;
            this.colAccountType.Visible = true;
            this.colAccountType.Width = 150;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Bank Name";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowEdit = false;
            this.colBankName.StatusBarDescription = null;
            this.colBankName.StatusBarShortcut = null;
            this.colBankName.StatusBarShortcutDescription = null;
            this.colBankName.Visible = true;
            this.colBankName.Width = 150;
            // 
            // colBankBranch
            // 
            this.colBankBranch.Caption = "Bank Branch";
            this.colBankBranch.FieldName = "BankBranch";
            this.colBankBranch.Name = "colBankBranch";
            this.colBankBranch.OptionsColumn.AllowEdit = false;
            this.colBankBranch.StatusBarDescription = null;
            this.colBankBranch.StatusBarShortcut = null;
            this.colBankBranch.StatusBarShortcutDescription = null;
            this.colBankBranch.Visible = true;
            this.colBankBranch.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Account Detail Informations";
            this.gridBand2.Columns.Add(this.colAccountOpeningDate);
            this.gridBand2.Columns.Add(this.colBlockedDayNumber);
            this.gridBand2.Columns.Add(this.colAccountNumber);
            this.gridBand2.Columns.Add(this.colIbanNumber);
            this.gridBand2.Columns.Add(this.colWorkPlaceNumber);
            this.gridBand2.Columns.Add(this.colTerminalNumber);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 950;
            // 
            // colAccountOpeningDate
            // 
            this.colAccountOpeningDate.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountOpeningDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountOpeningDate.Caption = "Account Opening Date";
            this.colAccountOpeningDate.FieldName = "AccountOpeningDate";
            this.colAccountOpeningDate.Name = "colAccountOpeningDate";
            this.colAccountOpeningDate.OptionsColumn.AllowEdit = false;
            this.colAccountOpeningDate.StatusBarDescription = null;
            this.colAccountOpeningDate.StatusBarShortcut = null;
            this.colAccountOpeningDate.StatusBarShortcutDescription = null;
            this.colAccountOpeningDate.Visible = true;
            this.colAccountOpeningDate.Width = 150;
            // 
            // colBlockedDayNumber
            // 
            this.colBlockedDayNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colBlockedDayNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBlockedDayNumber.Caption = "Blocked Day Number";
            this.colBlockedDayNumber.FieldName = "BlockedDayNumber";
            this.colBlockedDayNumber.Name = "colBlockedDayNumber";
            this.colBlockedDayNumber.OptionsColumn.AllowEdit = false;
            this.colBlockedDayNumber.StatusBarDescription = null;
            this.colBlockedDayNumber.StatusBarShortcut = null;
            this.colBlockedDayNumber.StatusBarShortcutDescription = null;
            this.colBlockedDayNumber.Visible = true;
            this.colBlockedDayNumber.Width = 150;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountNumber.Caption = "Account Number";
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.OptionsColumn.AllowEdit = false;
            this.colAccountNumber.StatusBarDescription = null;
            this.colAccountNumber.StatusBarShortcut = null;
            this.colAccountNumber.StatusBarShortcutDescription = null;
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.Width = 150;
            // 
            // colIbanNumber
            // 
            this.colIbanNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colIbanNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIbanNumber.Caption = "IBAN Number";
            this.colIbanNumber.FieldName = "IbanNumber";
            this.colIbanNumber.Name = "colIbanNumber";
            this.colIbanNumber.OptionsColumn.AllowEdit = false;
            this.colIbanNumber.StatusBarDescription = null;
            this.colIbanNumber.StatusBarShortcut = null;
            this.colIbanNumber.StatusBarShortcutDescription = null;
            this.colIbanNumber.Visible = true;
            this.colIbanNumber.Width = 200;
            // 
            // colWorkPlaceNumber
            // 
            this.colWorkPlaceNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colWorkPlaceNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWorkPlaceNumber.Caption = "WorkPlace Number";
            this.colWorkPlaceNumber.FieldName = "WorkPlaceNumber";
            this.colWorkPlaceNumber.Name = "colWorkPlaceNumber";
            this.colWorkPlaceNumber.OptionsColumn.AllowEdit = false;
            this.colWorkPlaceNumber.StatusBarDescription = null;
            this.colWorkPlaceNumber.StatusBarShortcut = null;
            this.colWorkPlaceNumber.StatusBarShortcutDescription = null;
            this.colWorkPlaceNumber.Visible = true;
            this.colWorkPlaceNumber.Width = 150;
            // 
            // colTerminalNumber
            // 
            this.colTerminalNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colTerminalNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTerminalNumber.Caption = "Terminal Number";
            this.colTerminalNumber.FieldName = "TerminalNumber";
            this.colTerminalNumber.Name = "colTerminalNumber";
            this.colTerminalNumber.OptionsColumn.AllowEdit = false;
            this.colTerminalNumber.StatusBarDescription = null;
            this.colTerminalNumber.StatusBarShortcut = null;
            this.colTerminalNumber.StatusBarShortcutDescription = null;
            this.colTerminalNumber.Visible = true;
            this.colTerminalNumber.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Special Codes";
            this.gridBand3.Columns.Add(this.colSpecialCode1);
            this.gridBand3.Columns.Add(this.colSpecialCode2);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
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
            // gridBand4
            // 
            this.gridBand4.Caption = "Other";
            this.gridBand4.Columns.Add(this.colDescription);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
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
            // BankAccountListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 395);
            this.Controls.Add(this.bandedGridControlBankAccounts);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "BankAccountListForm";
            this.Text = "Bank Account List";
            this.Load += new System.EventHandler(this.BankAccountListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.bandedGridControlBankAccounts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewBankAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyBandedGridControl bandedGridControlBankAccounts;
        private UserControls.Grids.MyBandedGridView bandedGridViewBankAccounts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colAccountName;
        private UserControls.Grids.MyBandedGridColumn colAccountType;
        private UserControls.Grids.MyBandedGridColumn colBankName;
        private UserControls.Grids.MyBandedGridColumn colBankBranch;
        private UserControls.Grids.MyBandedGridColumn colAccountOpeningDate;
        private UserControls.Grids.MyBandedGridColumn colAccountNumber;
        private UserControls.Grids.MyBandedGridColumn colIbanNumber;
        private UserControls.Grids.MyBandedGridColumn colBlockedDayNumber;
        private UserControls.Grids.MyBandedGridColumn colWorkPlaceNumber;
        private UserControls.Grids.MyBandedGridColumn colTerminalNumber;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}