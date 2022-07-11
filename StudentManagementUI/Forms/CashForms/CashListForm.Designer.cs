namespace StudentManagementUI.Forms.CashForms
{
    partial class CashListForm
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
            this.bandedGridControlCashes = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewlCashes = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCashName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSpecialCode1 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colSpecialCode2 = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlCashes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewlCashes)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1269, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 338);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1269, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // bandedGridControlCashes
            // 
            this.bandedGridControlCashes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlCashes.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlCashes.MainView = this.bandedGridViewlCashes;
            this.bandedGridControlCashes.MenuManager = this.ribbonControl;
            this.bandedGridControlCashes.Name = "bandedGridControlCashes";
            this.bandedGridControlCashes.Size = new System.Drawing.Size(1269, 236);
            this.bandedGridControlCashes.TabIndex = 3;
            this.bandedGridControlCashes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewlCashes});
            // 
            // bandedGridViewlCashes
            // 
            this.bandedGridViewlCashes.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewlCashes.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewlCashes.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewlCashes.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewlCashes.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewlCashes.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewlCashes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewlCashes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewlCashes.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewlCashes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewlCashes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewlCashes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewlCashes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewlCashes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewlCashes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewlCashes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewlCashes.BandPanelRowHeight = 40;
            this.bandedGridViewlCashes.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridViewlCashes.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colCashName,
            this.colSpecialCode1,
            this.colSpecialCode2,
            this.colDescription});
            this.bandedGridViewlCashes.GridControl = this.bandedGridControlCashes;
            this.bandedGridViewlCashes.Name = "bandedGridViewlCashes";
            this.bandedGridViewlCashes.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewlCashes.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewlCashes.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewlCashes.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewlCashes.OptionsPrint.AutoWidth = false;
            this.bandedGridViewlCashes.OptionsPrint.PrintFooter = false;
            this.bandedGridViewlCashes.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewlCashes.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewlCashes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewlCashes.OptionsView.RowAutoHeight = true;
            this.bandedGridViewlCashes.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewlCashes.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewlCashes.OptionsView.ShowViewCaption = true;
            this.bandedGridViewlCashes.StatusBarDescription = null;
            this.bandedGridViewlCashes.StatusBarShortcut = null;
            this.bandedGridViewlCashes.StatusBarShortcutDescription = null;
            this.bandedGridViewlCashes.ViewCaption = "Cashes";
            this.bandedGridViewlCashes.DoubleClick += new System.EventHandler(this.bandedGridViewlCashes_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Cash Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colCashName);
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
            // colCashName
            // 
            this.colCashName.Caption = "Cash Name";
            this.colCashName.FieldName = "CashName";
            this.colCashName.Name = "colCashName";
            this.colCashName.OptionsColumn.AllowEdit = false;
            this.colCashName.StatusBarDescription = null;
            this.colCashName.StatusBarShortcut = null;
            this.colCashName.StatusBarShortcutDescription = null;
            this.colCashName.Visible = true;
            this.colCashName.Width = 250;
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
            // CashListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 395);
            this.Controls.Add(this.bandedGridControlCashes);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CashListForm";
            this.Text = "Cash List";
            this.Load += new System.EventHandler(this.CashListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.bandedGridControlCashes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlCashes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewlCashes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl bandedGridControlCashes;
        private UserControls.Grids.MyBandedGridView bandedGridViewlCashes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colCashName;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode1;
        private UserControls.Grids.MyBandedGridColumn colSpecialCode2;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}