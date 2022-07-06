namespace StudentManagementUI.Forms.StudentForms
{
    partial class StudentListForm
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
            this.bandedGridControlStudents = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewStudents = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdentityNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSurname = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colGender = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colFatherName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colMotherName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colPhone = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode3 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode4 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode5 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewStudents)).BeginInit();
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
            // bandedGridControlStudents
            // 
            this.bandedGridControlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlStudents.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlStudents.MainView = this.bandedGridViewStudents;
            this.bandedGridControlStudents.MenuManager = this.ribbonControl;
            this.bandedGridControlStudents.Name = "bandedGridControlStudents";
            this.bandedGridControlStudents.Size = new System.Drawing.Size(1253, 238);
            this.bandedGridControlStudents.TabIndex = 3;
            this.bandedGridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewStudents});
            // 
            // bandedGridViewStudents
            // 
            this.bandedGridViewStudents.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewStudents.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewStudents.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewStudents.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewStudents.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewStudents.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewStudents.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewStudents.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewStudents.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewStudents.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewStudents.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewStudents.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewStudents.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewStudents.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewStudents.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewStudents.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewStudents.BandPanelRowHeight = 40;
            this.bandedGridViewStudents.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridViewStudents.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colIdentityNumber,
            this.colName,
            this.colSurname,
            this.colGender,
            this.colPhone,
            this.colFatherName,
            this.colMotherName,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colSpecialCode3,
            this.colSpecialCode4,
            this.colSpecialCode5});
            this.bandedGridViewStudents.GridControl = this.bandedGridControlStudents;
            this.bandedGridViewStudents.Name = "bandedGridViewStudents";
            this.bandedGridViewStudents.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewStudents.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewStudents.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewStudents.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewStudents.OptionsPrint.AutoWidth = false;
            this.bandedGridViewStudents.OptionsPrint.PrintFooter = false;
            this.bandedGridViewStudents.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewStudents.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewStudents.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewStudents.OptionsView.RowAutoHeight = true;
            this.bandedGridViewStudents.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewStudents.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewStudents.OptionsView.ShowViewCaption = true;
            this.bandedGridViewStudents.StatusBarDescription = null;
            this.bandedGridViewStudents.StatusBarShortcut = null;
            this.bandedGridViewStudents.StatusBarShortcutDescription = null;
            this.bandedGridViewStudents.ViewCaption = "Student Informations";
            this.bandedGridViewStudents.DoubleClick += new System.EventHandler(this.bandedGridViewStudents_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "General Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colIdentityNumber);
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Columns.Add(this.colSurname);
            this.gridBand1.Columns.Add(this.colGender);
            this.gridBand1.Columns.Add(this.colFatherName);
            this.gridBand1.Columns.Add(this.colMotherName);
            this.gridBand1.Columns.Add(this.colPhone);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1139;
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
            this.colPrivateCode.Width = 115;
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
            this.colIdentityNumber.Width = 170;
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
            this.colName.Width = 170;
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
            this.colSurname.Width = 166;
            // 
            // colGender
            // 
            this.colGender.Caption = "Gender";
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowEdit = false;
            this.colGender.StatusBarDescription = null;
            this.colGender.StatusBarShortcut = null;
            this.colGender.StatusBarShortcutDescription = null;
            this.colGender.Visible = true;
            this.colGender.Width = 90;
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
            this.colFatherName.Width = 162;
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
            this.colMotherName.Width = 161;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.StatusBarDescription = null;
            this.colPhone.StatusBarShortcut = null;
            this.colPhone.StatusBarShortcutDescription = null;
            this.colPhone.Visible = true;
            this.colPhone.Width = 105;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Special Codes";
            this.gridBand2.Columns.Add(this.colSpecialCode1);
            this.gridBand2.Columns.Add(this.colSpecialCode2);
            this.gridBand2.Columns.Add(this.colSpecialCode3);
            this.gridBand2.Columns.Add(this.colSpecialCode4);
            this.gridBand2.Columns.Add(this.colSpecialCode5);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 623;
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
            this.colSpecialCode1.Width = 131;
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
            this.colSpecialCode2.Width = 132;
            // 
            // colSpecialCode3
            // 
            this.colSpecialCode3.Caption = "Special Code-3";
            this.colSpecialCode3.FieldName = "SpecialCode3";
            this.colSpecialCode3.Name = "colSpecialCode3";
            this.colSpecialCode3.OptionsColumn.AllowEdit = false;
            this.colSpecialCode3.StatusBarDescription = null;
            this.colSpecialCode3.StatusBarShortcut = null;
            this.colSpecialCode3.StatusBarShortcutDescription = null;
            this.colSpecialCode3.Visible = true;
            this.colSpecialCode3.Width = 137;
            // 
            // colSpecialCode4
            // 
            this.colSpecialCode4.Caption = "Special Code-4";
            this.colSpecialCode4.FieldName = "SpecialCode4";
            this.colSpecialCode4.Name = "colSpecialCode4";
            this.colSpecialCode4.OptionsColumn.AllowEdit = false;
            this.colSpecialCode4.StatusBarDescription = null;
            this.colSpecialCode4.StatusBarShortcut = null;
            this.colSpecialCode4.StatusBarShortcutDescription = null;
            this.colSpecialCode4.Visible = true;
            this.colSpecialCode4.Width = 124;
            // 
            // colSpecialCode5
            // 
            this.colSpecialCode5.Caption = "Special Code-5";
            this.colSpecialCode5.FieldName = "SpecialCode5";
            this.colSpecialCode5.Name = "colSpecialCode5";
            this.colSpecialCode5.OptionsColumn.AllowEdit = false;
            this.colSpecialCode5.StatusBarDescription = null;
            this.colSpecialCode5.StatusBarShortcut = null;
            this.colSpecialCode5.StatusBarShortcutDescription = null;
            this.colSpecialCode5.Visible = true;
            this.colSpecialCode5.Width = 99;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 395);
            this.Controls.Add(this.bandedGridControlStudents);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "StudentListForm";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.bandedGridControlStudents, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyBandedGridControl bandedGridControlStudents;
        private UserControls.Grids.MyBandedGridView bandedGridViewStudents;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grids.MyBandedGridColumn colIdentityNumber;
        private UserControls.Grids.MyBandedGridColumn colName;
        private UserControls.Grids.MyBandedGridColumn colSurname;
        private UserControls.Grids.MyBandedGridColumn colGender;
        private UserControls.Grids.MyBandedGridColumn colFatherName;
        private UserControls.Grids.MyBandedGridColumn colMotherName;
        private UserControls.Grids.MyBandedGridColumn colPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode3;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode4;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode5;
    }
}