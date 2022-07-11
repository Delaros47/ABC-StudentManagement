namespace StudentManagementUI.Forms.BankForms
{
    partial class BankListForm
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
            this.bandedGridControlBanks = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewBanks = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBankName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewBanks)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1251, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 338);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1251, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // bandedGridControlBanks
            // 
            this.bandedGridControlBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlBanks.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlBanks.MainView = this.bandedGridViewBanks;
            this.bandedGridControlBanks.MenuManager = this.ribbonControl;
            this.bandedGridControlBanks.Name = "bandedGridControlBanks";
            this.bandedGridControlBanks.Size = new System.Drawing.Size(1251, 236);
            this.bandedGridControlBanks.TabIndex = 3;
            this.bandedGridControlBanks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewBanks});
            // 
            // bandedGridViewBanks
            // 
            this.bandedGridViewBanks.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewBanks.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewBanks.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewBanks.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewBanks.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewBanks.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewBanks.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewBanks.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewBanks.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewBanks.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewBanks.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewBanks.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewBanks.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewBanks.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewBanks.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewBanks.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewBanks.BandPanelRowHeight = 40;
            this.bandedGridViewBanks.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridViewBanks.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colBankName,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colDescription});
            this.bandedGridViewBanks.GridControl = this.bandedGridControlBanks;
            this.bandedGridViewBanks.Name = "bandedGridViewBanks";
            this.bandedGridViewBanks.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewBanks.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewBanks.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewBanks.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewBanks.OptionsPrint.AutoWidth = false;
            this.bandedGridViewBanks.OptionsPrint.PrintFooter = false;
            this.bandedGridViewBanks.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewBanks.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewBanks.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewBanks.OptionsView.RowAutoHeight = true;
            this.bandedGridViewBanks.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewBanks.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewBanks.OptionsView.ShowViewCaption = true;
            this.bandedGridViewBanks.StatusBarDescription = null;
            this.bandedGridViewBanks.StatusBarShortcut = null;
            this.bandedGridViewBanks.StatusBarShortcutDescription = null;
            this.bandedGridViewBanks.ViewCaption = "Banks";
            this.bandedGridViewBanks.DoubleClick += new System.EventHandler(this.bandedGridViewBanks_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Bank Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colBankName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 400;
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
            this.colBankName.Width = 250;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Special Codes";
            this.gridBand2.Columns.Add(this.colSpecialCode1);
            this.gridBand2.Columns.Add(this.colSpecialCode2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 400;
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
            this.colSpecialCode1.Width = 200;
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
            this.colSpecialCode2.Width = 200;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Other";
            this.gridBand3.Columns.Add(this.colDescription);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
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
            this.colDescription.Width = 400;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // BankListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 395);
            this.Controls.Add(this.bandedGridControlBanks);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "BankListForm";
            this.Text = "Bank List";
            this.Load += new System.EventHandler(this.BankListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.bandedGridControlBanks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewBanks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl bandedGridControlBanks;
        private UserControls.Grids.MyBandedGridView bandedGridViewBanks;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colBankName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
    }
}