namespace StudentManagementUI.Forms.ClassForms
{
    partial class ClassListForm
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
            this.bandedGridControlClasses = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewClasses = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colClassName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colGroupName = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAimStudentNumber = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCalcEditNumber = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAimRevenue = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCalcEditDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditDecimal)).BeginInit();
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
            this.longNavigator.Location = new System.Drawing.Point(0, 340);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1269, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // bandedGridControlClasses
            // 
            this.bandedGridControlClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlClasses.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlClasses.MainView = this.bandedGridViewClasses;
            this.bandedGridControlClasses.MenuManager = this.ribbonControl;
            this.bandedGridControlClasses.Name = "bandedGridControlClasses";
            this.bandedGridControlClasses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEditNumber,
            this.repositoryItemCalcEditDecimal});
            this.bandedGridControlClasses.Size = new System.Drawing.Size(1269, 238);
            this.bandedGridControlClasses.TabIndex = 3;
            this.bandedGridControlClasses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewClasses});
            // 
            // bandedGridViewClasses
            // 
            this.bandedGridViewClasses.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewClasses.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewClasses.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewClasses.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewClasses.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewClasses.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewClasses.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewClasses.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewClasses.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewClasses.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewClasses.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.bandedGridViewClasses.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewClasses.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewClasses.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewClasses.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewClasses.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewClasses.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewClasses.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewClasses.BandPanelRowHeight = 40;
            this.bandedGridViewClasses.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridViewClasses.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colClassName,
            this.colGroupName,
            this.colAimStudentNumber,
            this.colAimRevenue,
            this.colDescription});
            this.bandedGridViewClasses.GridControl = this.bandedGridControlClasses;
            this.bandedGridViewClasses.Name = "bandedGridViewClasses";
            this.bandedGridViewClasses.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewClasses.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewClasses.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewClasses.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewClasses.OptionsPrint.AutoWidth = false;
            this.bandedGridViewClasses.OptionsPrint.PrintFooter = false;
            this.bandedGridViewClasses.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewClasses.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewClasses.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewClasses.OptionsView.RowAutoHeight = true;
            this.bandedGridViewClasses.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewClasses.OptionsView.ShowFooter = true;
            this.bandedGridViewClasses.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewClasses.OptionsView.ShowViewCaption = true;
            this.bandedGridViewClasses.StatusBarDescription = null;
            this.bandedGridViewClasses.StatusBarShortcut = null;
            this.bandedGridViewClasses.StatusBarShortcutDescription = null;
            this.bandedGridViewClasses.ViewCaption = "Classes";
            this.bandedGridViewClasses.DoubleClick += new System.EventHandler(this.bandedGridViewClasses_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Class Informations";
            this.gridBand1.Columns.Add(this.colPrivateCode);
            this.gridBand1.Columns.Add(this.colClassName);
            this.gridBand1.Columns.Add(this.colGroupName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 514;
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
            this.colPrivateCode.Width = 153;
            // 
            // colClassName
            // 
            this.colClassName.Caption = "Class Name";
            this.colClassName.FieldName = "ClassName";
            this.colClassName.Name = "colClassName";
            this.colClassName.OptionsColumn.AllowEdit = false;
            this.colClassName.StatusBarDescription = null;
            this.colClassName.StatusBarShortcut = null;
            this.colClassName.StatusBarShortcutDescription = null;
            this.colClassName.Visible = true;
            this.colClassName.Width = 201;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Class Group Name";
            this.colGroupName.FieldName = "ClassGroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.AllowEdit = false;
            this.colGroupName.StatusBarDescription = null;
            this.colGroupName.StatusBarShortcut = null;
            this.colGroupName.StatusBarShortcutDescription = null;
            this.colGroupName.Visible = true;
            this.colGroupName.Width = 160;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Aim Informations";
            this.gridBand2.Columns.Add(this.colAimStudentNumber);
            this.gridBand2.Columns.Add(this.colAimRevenue);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 301;
            // 
            // colAimStudentNumber
            // 
            this.colAimStudentNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colAimStudentNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAimStudentNumber.Caption = "Aim Student Number";
            this.colAimStudentNumber.ColumnEdit = this.repositoryItemCalcEditNumber;
            this.colAimStudentNumber.FieldName = "AimStudentNumber";
            this.colAimStudentNumber.Name = "colAimStudentNumber";
            this.colAimStudentNumber.OptionsColumn.AllowEdit = false;
            this.colAimStudentNumber.StatusBarDescription = null;
            this.colAimStudentNumber.StatusBarShortcut = null;
            this.colAimStudentNumber.StatusBarShortcutDescription = null;
            this.colAimStudentNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AimStudentNumber", "{0:n0}")});
            this.colAimStudentNumber.Visible = true;
            this.colAimStudentNumber.Width = 150;
            // 
            // repositoryItemCalcEditNumber
            // 
            this.repositoryItemCalcEditNumber.AutoHeight = false;
            this.repositoryItemCalcEditNumber.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditNumber.DisplayFormat.FormatString = "d";
            this.repositoryItemCalcEditNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditNumber.MaskSettings.Set("mask", "d");
            this.repositoryItemCalcEditNumber.Name = "repositoryItemCalcEditNumber";
            // 
            // colAimRevenue
            // 
            this.colAimRevenue.Caption = "Aim Revenue";
            this.colAimRevenue.ColumnEdit = this.repositoryItemCalcEditDecimal;
            this.colAimRevenue.FieldName = "AimRevenue";
            this.colAimRevenue.Name = "colAimRevenue";
            this.colAimRevenue.OptionsColumn.AllowEdit = false;
            this.colAimRevenue.StatusBarDescription = null;
            this.colAimRevenue.StatusBarShortcut = null;
            this.colAimRevenue.StatusBarShortcutDescription = null;
            this.colAimRevenue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AimRevenue", "{0:n2}")});
            this.colAimRevenue.Visible = true;
            this.colAimRevenue.Width = 151;
            // 
            // repositoryItemCalcEditDecimal
            // 
            this.repositoryItemCalcEditDecimal.AutoHeight = false;
            this.repositoryItemCalcEditDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditDecimal.DisplayFormat.FormatString = "n2";
            this.repositoryItemCalcEditDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEditDecimal.MaskSettings.Set("mask", "n2");
            this.repositoryItemCalcEditDecimal.Name = "repositoryItemCalcEditDecimal";
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Other Informations";
            this.gridBand3.Columns.Add(this.colDescription);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 411;
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
            this.colDescription.Width = 411;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 395);
            this.Controls.Add(this.bandedGridControlClasses);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ClassListForm";
            this.Text = "Class List";
            this.Load += new System.EventHandler(this.ClassListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.bandedGridControlClasses, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl bandedGridControlClasses;
        private UserControls.Grids.MyBandedGridView bandedGridViewClasses;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
        private UserControls.Grids.MyBandedGridColumn colClassName;
        private UserControls.Grids.MyBandedGridColumn colGroupName;
        private UserControls.Grids.MyBandedGridColumn colAimStudentNumber;
        private UserControls.Grids.MyBandedGridColumn colAimRevenue;
        private UserControls.Grids.MyBandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditDecimal;
    }
}