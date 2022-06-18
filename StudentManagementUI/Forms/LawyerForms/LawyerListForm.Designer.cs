namespace StudentManagementUI.Forms.LawyerForms
{
    partial class LawyerListForm
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
            this.bandedGridControlLawyers = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewLawyers = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNameSurname = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colContractNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colContractStartDate = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colContractEndDate = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlLawyers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewLawyers)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1298, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 338);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1298, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // bandedGridControlLawyers
            // 
            this.bandedGridControlLawyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlLawyers.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlLawyers.MainView = this.bandedGridViewLawyers;
            this.bandedGridControlLawyers.MenuManager = this.ribbonControl;
            this.bandedGridControlLawyers.Name = "bandedGridControlLawyers";
            this.bandedGridControlLawyers.Size = new System.Drawing.Size(1298, 236);
            this.bandedGridControlLawyers.TabIndex = 3;
            this.bandedGridControlLawyers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewLawyers});
            // 
            // bandedGridViewLawyers
            // 
            this.bandedGridViewLawyers.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewLawyers.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewLawyers.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewLawyers.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewLawyers.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewLawyers.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewLawyers.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewLawyers.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewLawyers.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewLawyers.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewLawyers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewLawyers.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewLawyers.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewLawyers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewLawyers.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewLawyers.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewLawyers.BandPanelRowHeight = 40;
            this.bandedGridViewLawyers.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.bandedGridViewLawyers.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colNameSurname,
            this.colContractNumber,
            this.colContractStartDate,
            this.colContractEndDate,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colDescription});
            this.bandedGridViewLawyers.GridControl = this.bandedGridControlLawyers;
            this.bandedGridViewLawyers.Name = "bandedGridViewLawyers";
            this.bandedGridViewLawyers.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewLawyers.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewLawyers.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewLawyers.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewLawyers.OptionsPrint.AutoWidth = false;
            this.bandedGridViewLawyers.OptionsPrint.PrintFooter = false;
            this.bandedGridViewLawyers.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewLawyers.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewLawyers.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewLawyers.OptionsView.RowAutoHeight = true;
            this.bandedGridViewLawyers.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewLawyers.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewLawyers.OptionsView.ShowViewCaption = true;
            this.bandedGridViewLawyers.StatusBarDescription = null;
            this.bandedGridViewLawyers.StatusBarShortcut = null;
            this.bandedGridViewLawyers.StatusBarShortcutDescription = null;
            this.bandedGridViewLawyers.ViewCaption = "Lawyers";
            this.bandedGridViewLawyers.DoubleClick += new System.EventHandler(this.bandedGridViewLawyers_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Lawyer Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colNameSurname);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 300;
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
            this.colPrivateCode.Width = 125;
            // 
            // colNameSurname
            // 
            this.colNameSurname.Caption = "Name Surname";
            this.colNameSurname.FieldName = "NameSurname";
            this.colNameSurname.Name = "colNameSurname";
            this.colNameSurname.OptionsColumn.AllowEdit = false;
            this.colNameSurname.StatusBarDescription = null;
            this.colNameSurname.StatusBarShortcut = null;
            this.colNameSurname.StatusBarShortcutDescription = null;
            this.colNameSurname.Visible = true;
            this.colNameSurname.Width = 175;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Contract Informations";
            this.gridBand2.Columns.Add(this.colContractNumber);
            this.gridBand2.Columns.Add(this.colContractStartDate);
            this.gridBand2.Columns.Add(this.colContractEndDate);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 425;
            // 
            // colContractNumber
            // 
            this.colContractNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colContractNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractNumber.Caption = "Contract Number";
            this.colContractNumber.FieldName = "ContractNumber";
            this.colContractNumber.Name = "colContractNumber";
            this.colContractNumber.OptionsColumn.AllowEdit = false;
            this.colContractNumber.StatusBarDescription = null;
            this.colContractNumber.StatusBarShortcut = null;
            this.colContractNumber.StatusBarShortcutDescription = null;
            this.colContractNumber.Visible = true;
            this.colContractNumber.Width = 125;
            // 
            // colContractStartDate
            // 
            this.colContractStartDate.AppearanceCell.Options.UseTextOptions = true;
            this.colContractStartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractStartDate.Caption = "Contract Start Date";
            this.colContractStartDate.FieldName = "ContractStartDate";
            this.colContractStartDate.Name = "colContractStartDate";
            this.colContractStartDate.OptionsColumn.AllowEdit = false;
            this.colContractStartDate.StatusBarDescription = null;
            this.colContractStartDate.StatusBarShortcut = null;
            this.colContractStartDate.StatusBarShortcutDescription = null;
            this.colContractStartDate.Visible = true;
            this.colContractStartDate.Width = 150;
            // 
            // colContractEndDate
            // 
            this.colContractEndDate.AppearanceCell.Options.UseTextOptions = true;
            this.colContractEndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractEndDate.Caption = "Contract End Date";
            this.colContractEndDate.FieldName = "ContractEndDate";
            this.colContractEndDate.Name = "colContractEndDate";
            this.colContractEndDate.OptionsColumn.AllowEdit = false;
            this.colContractEndDate.StatusBarDescription = null;
            this.colContractEndDate.StatusBarShortcut = null;
            this.colContractEndDate.StatusBarShortcutDescription = null;
            this.colContractEndDate.Visible = true;
            this.colContractEndDate.Width = 150;
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
            this.gridBand4.Width = 250;
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
            this.colDescription.Width = 250;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // LawyerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 395);
            this.Controls.Add(this.bandedGridControlLawyers);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "LawyerListForm";
            this.Text = "Lawyer List";
            this.Load += new System.EventHandler(this.LawyerListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.bandedGridControlLawyers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlLawyers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewLawyers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyBandedGridControl bandedGridControlLawyers;
        private UserControls.Grids.MyBandedGridView bandedGridViewLawyers;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colNameSurname;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colContractNumber;
        private UserControls.Grids.MyBandedGridColumn colContractStartDate;
        private UserControls.Grids.MyBandedGridColumn colContractEndDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
    }
}