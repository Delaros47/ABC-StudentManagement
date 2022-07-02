namespace StudentManagementUI.Forms.ContactForms
{
    partial class ContactListForm
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
            this.bandedGridControlContacts = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewContacts = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdentityNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSurname = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colOccupation = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colDuty = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colFatherName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colMotherName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colBloodType = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colBirthPlace = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colCardNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colIBanNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCellPhone1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colInternalPhone1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplacePhone1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAddress = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colHomeAddressCity = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colHomeAddressDistrict = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWorkAddress = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWorkAddressCity = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWorkAddressDistrict = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDateOfBirth = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSerialNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSequenceNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colCity = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colDistrict = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colNeighbourhood = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colVolumeNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colFamilySequenceNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPersonSequenceNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPlaceIssued = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityIssuedReason = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityRegisterNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colIdentityIssuedDate = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colHomePhone = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWorkplacePhone2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colInternalPhone2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colCellPhone2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colWeb = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colEmail = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewContacts)).BeginInit();
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
            this.longNavigator1.Location = new System.Drawing.Point(0, 338);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1120, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // bandedGridControlContacts
            // 
            this.bandedGridControlContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlContacts.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlContacts.MainView = this.bandedGridViewContacts;
            this.bandedGridControlContacts.MenuManager = this.ribbonControl;
            this.bandedGridControlContacts.Name = "bandedGridControlContacts";
            this.bandedGridControlContacts.Size = new System.Drawing.Size(1120, 236);
            this.bandedGridControlContacts.TabIndex = 3;
            this.bandedGridControlContacts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewContacts});
            // 
            // bandedGridViewContacts
            // 
            this.bandedGridViewContacts.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewContacts.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewContacts.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewContacts.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewContacts.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewContacts.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewContacts.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewContacts.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewContacts.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewContacts.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewContacts.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewContacts.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewContacts.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewContacts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewContacts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewContacts.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewContacts.BandPanelRowHeight = 40;
            this.bandedGridViewContacts.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.bandedGridViewContacts.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colIdentityNumber,
            this.colName,
            this.colSurname,
            this.colFatherName,
            this.colMotherName,
            this.colBirthPlace,
            this.colBloodType,
            this.colDateOfBirth,
            this.colSerialNumber,
            this.colSequenceNumber,
            this.colCity,
            this.colDistrict,
            this.colNeighbourhood,
            this.colVolumeNumber,
            this.colFamilySequenceNumber,
            this.colPersonSequenceNumber,
            this.colPlaceIssued,
            this.colIdentityIssuedReason,
            this.colIdentityRegisterNumber,
            this.colIdentityIssuedDate,
            this.colHomePhone,
            this.colWorkplacePhone1,
            this.colWorkplacePhone2,
            this.colInternalPhone1,
            this.colInternalPhone2,
            this.colCellPhone1,
            this.colCellPhone2,
            this.colWeb,
            this.colEmail,
            this.colAddress,
            this.colHomeAddressCity,
            this.colHomeAddressDistrict,
            this.colWorkAddress,
            this.colWorkAddressCity,
            this.colWorkAddressDistrict,
            this.colOccupation,
            this.colDuty,
            this.colIBanNumber,
            this.colCardNumber,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colDescription});
            this.bandedGridViewContacts.GridControl = this.bandedGridControlContacts;
            this.bandedGridViewContacts.Name = "bandedGridViewContacts";
            this.bandedGridViewContacts.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewContacts.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewContacts.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewContacts.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewContacts.OptionsPrint.AutoWidth = false;
            this.bandedGridViewContacts.OptionsPrint.PrintFooter = false;
            this.bandedGridViewContacts.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewContacts.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewContacts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewContacts.OptionsView.RowAutoHeight = true;
            this.bandedGridViewContacts.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewContacts.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewContacts.OptionsView.ShowViewCaption = true;
            this.bandedGridViewContacts.StatusBarDescription = null;
            this.bandedGridViewContacts.StatusBarShortcut = null;
            this.bandedGridViewContacts.StatusBarShortcutDescription = null;
            this.bandedGridViewContacts.ViewCaption = "Contacts";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "General Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colIdentityNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colSurname);
            this.gridBand1.Columns.Add(this.colOccupation);
            this.gridBand1.Columns.Add(this.colDuty);
            this.gridBand1.Columns.Add(this.colFatherName);
            this.gridBand1.Columns.Add(this.colMotherName);
            this.gridBand1.Columns.Add(this.colBloodType);
            this.gridBand1.Columns.Add(this.colBirthPlace);
            this.gridBand1.Columns.Add(this.colCardNumber);
            this.gridBand1.Columns.Add(this.colIBanNumber);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1549;
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
            this.colPrivateCode.Width = 134;
            // 
            // colIdentityNumber
            // 
            this.colIdentityNumber.Caption = "Identity Number";
            this.colIdentityNumber.FieldName = "IdentityNumber";
            this.colIdentityNumber.Name = "colIdentityNumber";
            this.colIdentityNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityNumber.StatusBarDescription = null;
            this.colIdentityNumber.StatusBarShortcut = null;
            this.colIdentityNumber.StatusBarShortcutDescription = null;
            this.colIdentityNumber.Visible = true;
            this.colIdentityNumber.Width = 139;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.StatusBarDescription = null;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutDescription = null;
            this.colName.Visible = true;
            this.colName.Width = 143;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.OptionsColumn.AllowEdit = false;
            this.colSurname.StatusBarDescription = null;
            this.colSurname.StatusBarShortcut = null;
            this.colSurname.StatusBarShortcutDescription = null;
            this.colSurname.Visible = true;
            this.colSurname.Width = 146;
            // 
            // colOccupation
            // 
            this.colOccupation.Caption = "Occupation";
            this.colOccupation.FieldName = "Occupation";
            this.colOccupation.Name = "colOccupation";
            this.colOccupation.OptionsColumn.AllowEdit = false;
            this.colOccupation.StatusBarDescription = null;
            this.colOccupation.StatusBarShortcut = null;
            this.colOccupation.StatusBarShortcutDescription = null;
            this.colOccupation.Visible = true;
            this.colOccupation.Width = 125;
            // 
            // colDuty
            // 
            this.colDuty.Caption = "Duty";
            this.colDuty.FieldName = "Duty";
            this.colDuty.Name = "colDuty";
            this.colDuty.OptionsColumn.AllowEdit = false;
            this.colDuty.StatusBarDescription = null;
            this.colDuty.StatusBarShortcut = null;
            this.colDuty.StatusBarShortcutDescription = null;
            this.colDuty.Visible = true;
            this.colDuty.Width = 113;
            // 
            // colFatherName
            // 
            this.colFatherName.Caption = "Father Name";
            this.colFatherName.FieldName = "FatherName";
            this.colFatherName.Name = "colFatherName";
            this.colFatherName.OptionsColumn.AllowEdit = false;
            this.colFatherName.StatusBarDescription = null;
            this.colFatherName.StatusBarShortcut = null;
            this.colFatherName.StatusBarShortcutDescription = null;
            this.colFatherName.Visible = true;
            this.colFatherName.Width = 134;
            // 
            // colMotherName
            // 
            this.colMotherName.Caption = "Mother Name";
            this.colMotherName.FieldName = "MotherName";
            this.colMotherName.Name = "colMotherName";
            this.colMotherName.OptionsColumn.AllowEdit = false;
            this.colMotherName.StatusBarDescription = null;
            this.colMotherName.StatusBarShortcut = null;
            this.colMotherName.StatusBarShortcutDescription = null;
            this.colMotherName.Visible = true;
            this.colMotherName.Width = 122;
            // 
            // colBloodType
            // 
            this.colBloodType.Caption = "Blood Type";
            this.colBloodType.FieldName = "BloodType";
            this.colBloodType.Name = "colBloodType";
            this.colBloodType.OptionsColumn.AllowEdit = false;
            this.colBloodType.StatusBarDescription = null;
            this.colBloodType.StatusBarShortcut = null;
            this.colBloodType.StatusBarShortcutDescription = null;
            this.colBloodType.Visible = true;
            this.colBloodType.Width = 135;
            // 
            // colBirthPlace
            // 
            this.colBirthPlace.Caption = "Birth Place";
            this.colBirthPlace.FieldName = "BirthPlace";
            this.colBirthPlace.Name = "colBirthPlace";
            this.colBirthPlace.OptionsColumn.AllowEdit = false;
            this.colBirthPlace.StatusBarDescription = null;
            this.colBirthPlace.StatusBarShortcut = null;
            this.colBirthPlace.StatusBarShortcutDescription = null;
            this.colBirthPlace.Visible = true;
            this.colBirthPlace.Width = 104;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "Card Number";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowEdit = false;
            this.colCardNumber.StatusBarDescription = null;
            this.colCardNumber.StatusBarShortcut = null;
            this.colCardNumber.StatusBarShortcutDescription = null;
            this.colCardNumber.Visible = true;
            this.colCardNumber.Width = 147;
            // 
            // colIBanNumber
            // 
            this.colIBanNumber.Caption = "IBan Number";
            this.colIBanNumber.FieldName = "IBanNumber";
            this.colIBanNumber.Name = "colIBanNumber";
            this.colIBanNumber.OptionsColumn.AllowEdit = false;
            this.colIBanNumber.StatusBarDescription = null;
            this.colIBanNumber.StatusBarShortcut = null;
            this.colIBanNumber.StatusBarShortcutDescription = null;
            this.colIBanNumber.Visible = true;
            this.colIBanNumber.Width = 107;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Phone";
            this.gridBand2.Columns.Add(this.colCellPhone1);
            this.gridBand2.Columns.Add(this.colInternalPhone1);
            this.gridBand2.Columns.Add(this.colWorkplacePhone1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 406;
            // 
            // colCellPhone1
            // 
            this.colCellPhone1.Caption = "Cell Phone-1";
            this.colCellPhone1.FieldName = "CellPhone1";
            this.colCellPhone1.Name = "colCellPhone1";
            this.colCellPhone1.OptionsColumn.AllowEdit = false;
            this.colCellPhone1.StatusBarDescription = null;
            this.colCellPhone1.StatusBarShortcut = null;
            this.colCellPhone1.StatusBarShortcutDescription = null;
            this.colCellPhone1.Visible = true;
            this.colCellPhone1.Width = 156;
            // 
            // colInternalPhone1
            // 
            this.colInternalPhone1.Caption = "Internal Phone-1";
            this.colInternalPhone1.FieldName = "InternalPhone1";
            this.colInternalPhone1.Name = "colInternalPhone1";
            this.colInternalPhone1.OptionsColumn.AllowEdit = false;
            this.colInternalPhone1.StatusBarDescription = null;
            this.colInternalPhone1.StatusBarShortcut = null;
            this.colInternalPhone1.StatusBarShortcutDescription = null;
            this.colInternalPhone1.Visible = true;
            this.colInternalPhone1.Width = 154;
            // 
            // colWorkplacePhone1
            // 
            this.colWorkplacePhone1.Caption = "Workplace Phone-1";
            this.colWorkplacePhone1.FieldName = "WorkplacePhone1";
            this.colWorkplacePhone1.Name = "colWorkplacePhone1";
            this.colWorkplacePhone1.OptionsColumn.AllowEdit = false;
            this.colWorkplacePhone1.StatusBarDescription = null;
            this.colWorkplacePhone1.StatusBarShortcut = null;
            this.colWorkplacePhone1.StatusBarShortcutDescription = null;
            this.colWorkplacePhone1.Visible = true;
            this.colWorkplacePhone1.Width = 96;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Address";
            this.gridBand3.Columns.Add(this.colAddress);
            this.gridBand3.Columns.Add(this.colHomeAddressCity);
            this.gridBand3.Columns.Add(this.colHomeAddressDistrict);
            this.gridBand3.Columns.Add(this.colWorkAddress);
            this.gridBand3.Columns.Add(this.colWorkAddressCity);
            this.gridBand3.Columns.Add(this.colWorkAddressDistrict);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 880;
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
            this.colAddress.Width = 138;
            // 
            // colHomeAddressCity
            // 
            this.colHomeAddressCity.Caption = "Home Address City";
            this.colHomeAddressCity.FieldName = "HomeAddressCity";
            this.colHomeAddressCity.Name = "colHomeAddressCity";
            this.colHomeAddressCity.OptionsColumn.AllowEdit = false;
            this.colHomeAddressCity.StatusBarDescription = null;
            this.colHomeAddressCity.StatusBarShortcut = null;
            this.colHomeAddressCity.StatusBarShortcutDescription = null;
            this.colHomeAddressCity.Visible = true;
            this.colHomeAddressCity.Width = 137;
            // 
            // colHomeAddressDistrict
            // 
            this.colHomeAddressDistrict.Caption = "Home Address District";
            this.colHomeAddressDistrict.FieldName = "HomeAddressDistrict";
            this.colHomeAddressDistrict.Name = "colHomeAddressDistrict";
            this.colHomeAddressDistrict.OptionsColumn.AllowEdit = false;
            this.colHomeAddressDistrict.StatusBarDescription = null;
            this.colHomeAddressDistrict.StatusBarShortcut = null;
            this.colHomeAddressDistrict.StatusBarShortcutDescription = null;
            this.colHomeAddressDistrict.Visible = true;
            this.colHomeAddressDistrict.Width = 187;
            // 
            // colWorkAddress
            // 
            this.colWorkAddress.Caption = "Work Address";
            this.colWorkAddress.FieldName = "WorkAddress";
            this.colWorkAddress.Name = "colWorkAddress";
            this.colWorkAddress.OptionsColumn.AllowEdit = false;
            this.colWorkAddress.StatusBarDescription = null;
            this.colWorkAddress.StatusBarShortcut = null;
            this.colWorkAddress.StatusBarShortcutDescription = null;
            this.colWorkAddress.Visible = true;
            this.colWorkAddress.Width = 161;
            // 
            // colWorkAddressCity
            // 
            this.colWorkAddressCity.Caption = "Work Address City";
            this.colWorkAddressCity.FieldName = "WorkAddressCity";
            this.colWorkAddressCity.Name = "colWorkAddressCity";
            this.colWorkAddressCity.OptionsColumn.AllowEdit = false;
            this.colWorkAddressCity.StatusBarDescription = null;
            this.colWorkAddressCity.StatusBarShortcut = null;
            this.colWorkAddressCity.StatusBarShortcutDescription = null;
            this.colWorkAddressCity.Visible = true;
            this.colWorkAddressCity.Width = 135;
            // 
            // colWorkAddressDistrict
            // 
            this.colWorkAddressDistrict.Caption = "Work Address District";
            this.colWorkAddressDistrict.FieldName = "WorkAddressDistrict";
            this.colWorkAddressDistrict.Name = "colWorkAddressDistrict";
            this.colWorkAddressDistrict.OptionsColumn.AllowEdit = false;
            this.colWorkAddressDistrict.StatusBarDescription = null;
            this.colWorkAddressDistrict.StatusBarShortcut = null;
            this.colWorkAddressDistrict.StatusBarShortcutDescription = null;
            this.colWorkAddressDistrict.Visible = true;
            this.colWorkAddressDistrict.Width = 122;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Special Codes";
            this.gridBand4.Columns.Add(this.colSpecialCode1);
            this.gridBand4.Columns.Add(this.colSpecialCode2);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 262;
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
            this.colSpecialCode1.Width = 157;
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
            this.colSpecialCode2.Width = 105;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Others";
            this.gridBand5.Columns.Add(this.colDescription);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 169;
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
            this.colDescription.Width = 169;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.Caption = "Date Of Birth";
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.OptionsColumn.AllowEdit = false;
            this.colDateOfBirth.StatusBarDescription = null;
            this.colDateOfBirth.StatusBarShortcut = null;
            this.colDateOfBirth.StatusBarShortcutDescription = null;
            this.colDateOfBirth.Visible = true;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Serial Number";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.OptionsColumn.AllowEdit = false;
            this.colSerialNumber.StatusBarDescription = null;
            this.colSerialNumber.StatusBarShortcut = null;
            this.colSerialNumber.StatusBarShortcutDescription = null;
            this.colSerialNumber.Visible = true;
            // 
            // colSequenceNumber
            // 
            this.colSequenceNumber.Caption = "Sequence Number";
            this.colSequenceNumber.FieldName = "SequenceNumber";
            this.colSequenceNumber.Name = "colSequenceNumber";
            this.colSequenceNumber.OptionsColumn.AllowEdit = false;
            this.colSequenceNumber.StatusBarDescription = null;
            this.colSequenceNumber.StatusBarShortcut = null;
            this.colSequenceNumber.StatusBarShortcutDescription = null;
            this.colSequenceNumber.Visible = true;
            // 
            // colCity
            // 
            this.colCity.Caption = "City Name";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.StatusBarDescription = null;
            this.colCity.StatusBarShortcut = null;
            this.colCity.StatusBarShortcutDescription = null;
            this.colCity.Visible = true;
            // 
            // colDistrict
            // 
            this.colDistrict.Caption = "District";
            this.colDistrict.FieldName = "District";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.OptionsColumn.AllowEdit = false;
            this.colDistrict.StatusBarDescription = null;
            this.colDistrict.StatusBarShortcut = null;
            this.colDistrict.StatusBarShortcutDescription = null;
            this.colDistrict.Visible = true;
            // 
            // colNeighbourhood
            // 
            this.colNeighbourhood.Caption = "Neighbourhood";
            this.colNeighbourhood.FieldName = "Neighbourhood";
            this.colNeighbourhood.Name = "colNeighbourhood";
            this.colNeighbourhood.OptionsColumn.AllowEdit = false;
            this.colNeighbourhood.StatusBarDescription = null;
            this.colNeighbourhood.StatusBarShortcut = null;
            this.colNeighbourhood.StatusBarShortcutDescription = null;
            this.colNeighbourhood.Visible = true;
            // 
            // colVolumeNumber
            // 
            this.colVolumeNumber.Caption = "Volume Number";
            this.colVolumeNumber.FieldName = "VolumeNumber";
            this.colVolumeNumber.Name = "colVolumeNumber";
            this.colVolumeNumber.OptionsColumn.AllowEdit = false;
            this.colVolumeNumber.StatusBarDescription = null;
            this.colVolumeNumber.StatusBarShortcut = null;
            this.colVolumeNumber.StatusBarShortcutDescription = null;
            this.colVolumeNumber.Visible = true;
            // 
            // colFamilySequenceNumber
            // 
            this.colFamilySequenceNumber.Caption = "Family Sequence Number";
            this.colFamilySequenceNumber.FieldName = "FamilySequenceNumber";
            this.colFamilySequenceNumber.Name = "colFamilySequenceNumber";
            this.colFamilySequenceNumber.OptionsColumn.AllowEdit = false;
            this.colFamilySequenceNumber.StatusBarDescription = null;
            this.colFamilySequenceNumber.StatusBarShortcut = null;
            this.colFamilySequenceNumber.StatusBarShortcutDescription = null;
            this.colFamilySequenceNumber.Visible = true;
            // 
            // colPersonSequenceNumber
            // 
            this.colPersonSequenceNumber.Caption = "Person Sequence Number";
            this.colPersonSequenceNumber.FieldName = "PersonSequenceNumber";
            this.colPersonSequenceNumber.Name = "colPersonSequenceNumber";
            this.colPersonSequenceNumber.OptionsColumn.AllowEdit = false;
            this.colPersonSequenceNumber.StatusBarDescription = null;
            this.colPersonSequenceNumber.StatusBarShortcut = null;
            this.colPersonSequenceNumber.StatusBarShortcutDescription = null;
            this.colPersonSequenceNumber.Visible = true;
            // 
            // colPlaceIssued
            // 
            this.colPlaceIssued.Caption = "Place Issued";
            this.colPlaceIssued.FieldName = "PlaceIssued";
            this.colPlaceIssued.Name = "colPlaceIssued";
            this.colPlaceIssued.OptionsColumn.AllowEdit = false;
            this.colPlaceIssued.StatusBarDescription = null;
            this.colPlaceIssued.StatusBarShortcut = null;
            this.colPlaceIssued.StatusBarShortcutDescription = null;
            this.colPlaceIssued.Visible = true;
            // 
            // colIdentityIssuedReason
            // 
            this.colIdentityIssuedReason.Caption = "Identity Issued Reason";
            this.colIdentityIssuedReason.FieldName = "IdentityIssuedReason";
            this.colIdentityIssuedReason.Name = "colIdentityIssuedReason";
            this.colIdentityIssuedReason.OptionsColumn.AllowEdit = false;
            this.colIdentityIssuedReason.StatusBarDescription = null;
            this.colIdentityIssuedReason.StatusBarShortcut = null;
            this.colIdentityIssuedReason.StatusBarShortcutDescription = null;
            this.colIdentityIssuedReason.Visible = true;
            // 
            // colIdentityRegisterNumber
            // 
            this.colIdentityRegisterNumber.Caption = "Identity Register Number";
            this.colIdentityRegisterNumber.FieldName = "IdentityRegisterNumber";
            this.colIdentityRegisterNumber.Name = "colIdentityRegisterNumber";
            this.colIdentityRegisterNumber.OptionsColumn.AllowEdit = false;
            this.colIdentityRegisterNumber.StatusBarDescription = null;
            this.colIdentityRegisterNumber.StatusBarShortcut = null;
            this.colIdentityRegisterNumber.StatusBarShortcutDescription = null;
            this.colIdentityRegisterNumber.Visible = true;
            // 
            // colIdentityIssuedDate
            // 
            this.colIdentityIssuedDate.Caption = "Identity Issued Date";
            this.colIdentityIssuedDate.FieldName = "IdentityIssuedDate";
            this.colIdentityIssuedDate.Name = "colIdentityIssuedDate";
            this.colIdentityIssuedDate.OptionsColumn.AllowEdit = false;
            this.colIdentityIssuedDate.StatusBarDescription = null;
            this.colIdentityIssuedDate.StatusBarShortcut = null;
            this.colIdentityIssuedDate.StatusBarShortcutDescription = null;
            this.colIdentityIssuedDate.Visible = true;
            // 
            // colHomePhone
            // 
            this.colHomePhone.Caption = "Home Phone";
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.OptionsColumn.AllowEdit = false;
            this.colHomePhone.StatusBarDescription = null;
            this.colHomePhone.StatusBarShortcut = null;
            this.colHomePhone.StatusBarShortcutDescription = null;
            this.colHomePhone.Visible = true;
            // 
            // colWorkplacePhone2
            // 
            this.colWorkplacePhone2.Caption = "Workplace Phone-2";
            this.colWorkplacePhone2.FieldName = "WorkplacePhone2";
            this.colWorkplacePhone2.Name = "colWorkplacePhone2";
            this.colWorkplacePhone2.OptionsColumn.AllowEdit = false;
            this.colWorkplacePhone2.StatusBarDescription = null;
            this.colWorkplacePhone2.StatusBarShortcut = null;
            this.colWorkplacePhone2.StatusBarShortcutDescription = null;
            this.colWorkplacePhone2.Visible = true;
            // 
            // colInternalPhone2
            // 
            this.colInternalPhone2.Caption = "Internal Phone-2";
            this.colInternalPhone2.FieldName = "InternalPhone2";
            this.colInternalPhone2.Name = "colInternalPhone2";
            this.colInternalPhone2.OptionsColumn.AllowEdit = false;
            this.colInternalPhone2.StatusBarDescription = null;
            this.colInternalPhone2.StatusBarShortcut = null;
            this.colInternalPhone2.StatusBarShortcutDescription = null;
            this.colInternalPhone2.Visible = true;
            // 
            // colCellPhone2
            // 
            this.colCellPhone2.Caption = "Cell Phone-2";
            this.colCellPhone2.FieldName = "CellPhone2";
            this.colCellPhone2.Name = "colCellPhone2";
            this.colCellPhone2.OptionsColumn.AllowEdit = false;
            this.colCellPhone2.StatusBarDescription = null;
            this.colCellPhone2.StatusBarShortcut = null;
            this.colCellPhone2.StatusBarShortcutDescription = null;
            this.colCellPhone2.Visible = true;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web Site";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarDescription = null;
            this.colWeb.StatusBarShortcut = null;
            this.colWeb.StatusBarShortcutDescription = null;
            this.colWeb.Visible = true;
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
            // 
            // ContactListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.bandedGridControlContacts);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "ContactListForm";
            this.Text = "Contact List";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.bandedGridControlContacts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyBandedGridControl bandedGridControlContacts;
        private UserControls.Grids.MyBandedGridView bandedGridViewContacts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colSurname;
        private UserControls.Grids.MyBandedGridColumn colFatherName;
        private UserControls.Grids.MyBandedGridColumn colMotherName;
        private UserControls.Grids.MyBandedGridColumn colBirthPlace;
        private UserControls.Grids.MyBandedGridColumn colBloodType;
        private UserControls.Grids.MyBandedGridColumn colDateOfBirth;
        private UserControls.Grids.MyBandedGridColumn colSerialNumber;
        private UserControls.Grids.MyBandedGridColumn colSequenceNumber;
        private UserControls.Grids.MyBandedGridColumn colCity;
        private UserControls.Grids.MyBandedGridColumn colDistrict;
        private UserControls.Grids.MyBandedGridColumn colNeighbourhood;
        private UserControls.Grids.MyBandedGridColumn colVolumeNumber;
        private UserControls.Grids.MyBandedGridColumn colFamilySequenceNumber;
        private UserControls.Grids.MyBandedGridColumn colPersonSequenceNumber;
        private UserControls.Grids.MyBandedGridColumn colPlaceIssued;
        private UserControls.Grids.MyBandedGridColumn colIdentityIssuedReason;
        private UserControls.Grids.MyBandedGridColumn colIdentityRegisterNumber;
        private UserControls.Grids.MyBandedGridColumn colIdentityIssuedDate;
        private UserControls.Grids.MyBandedGridColumn colHomePhone;
        private UserControls.Grids.MyBandedGridColumn colWorkplacePhone1;
        private UserControls.Grids.MyBandedGridColumn colWorkplacePhone2;
        private UserControls.Grids.MyBandedGridColumn colInternalPhone1;
        private UserControls.Grids.MyBandedGridColumn colInternalPhone2;
        private UserControls.Grids.MyBandedGridColumn colCellPhone1;
        private UserControls.Grids.MyBandedGridColumn colCellPhone2;
        private UserControls.Grids.MyBandedGridColumn colWeb;
        private UserControls.Grids.MyBandedGridColumn colEmail;
        private UserControls.Grids.MyBandedGridColumn colAddress;
        private UserControls.Grids.MyBandedGridColumn colHomeAddressCity;
        private UserControls.Grids.MyBandedGridColumn colHomeAddressDistrict;
        private UserControls.Grids.MyBandedGridColumn colWorkAddress;
        private UserControls.Grids.MyBandedGridColumn colWorkAddressCity;
        private UserControls.Grids.MyBandedGridColumn colWorkAddressDistrict;
        private UserControls.Grids.MyBandedGridColumn colOccupation;
        private UserControls.Grids.MyBandedGridColumn colDuty;
        private UserControls.Grids.MyBandedGridColumn colIBanNumber;
        private UserControls.Grids.MyBandedGridColumn colCardNumber;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
    }
}