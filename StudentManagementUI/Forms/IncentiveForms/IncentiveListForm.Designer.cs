namespace StudentManagementUI.Forms.IncentiveForms
{
    partial class IncentiveListForm
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
            this.gridControlIncentiveList = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewIncentiveList = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colIncentiveName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIncentiveList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncentiveList)).BeginInit();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 338);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1120, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // gridControlIncentiveList
            // 
            this.gridControlIncentiveList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIncentiveList.Location = new System.Drawing.Point(0, 102);
            this.gridControlIncentiveList.MainView = this.gridViewIncentiveList;
            this.gridControlIncentiveList.MenuManager = this.ribbonControl;
            this.gridControlIncentiveList.Name = "gridControlIncentiveList";
            this.gridControlIncentiveList.Size = new System.Drawing.Size(1120, 236);
            this.gridControlIncentiveList.TabIndex = 3;
            this.gridControlIncentiveList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIncentiveList});
            // 
            // gridViewIncentiveList
            // 
            this.gridViewIncentiveList.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewIncentiveList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewIncentiveList.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewIncentiveList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewIncentiveList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewIncentiveList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewIncentiveList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewIncentiveList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewIncentiveList.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewIncentiveList.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewIncentiveList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colIncentiveName,
            this.colDescription});
            this.gridViewIncentiveList.GridControl = this.gridControlIncentiveList;
            this.gridViewIncentiveList.Name = "gridViewIncentiveList";
            this.gridViewIncentiveList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewIncentiveList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewIncentiveList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewIncentiveList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewIncentiveList.OptionsPrint.AutoWidth = false;
            this.gridViewIncentiveList.OptionsPrint.PrintFooter = false;
            this.gridViewIncentiveList.OptionsPrint.PrintGroupFooter = false;
            this.gridViewIncentiveList.OptionsView.ColumnAutoWidth = false;
            this.gridViewIncentiveList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewIncentiveList.OptionsView.RowAutoHeight = true;
            this.gridViewIncentiveList.OptionsView.ShowAutoFilterRow = true;
            this.gridViewIncentiveList.OptionsView.ShowGroupPanel = false;
            this.gridViewIncentiveList.OptionsView.ShowViewCaption = true;
            this.gridViewIncentiveList.StatusBarDescription = null;
            this.gridViewIncentiveList.StatusBarShortcut = null;
            this.gridViewIncentiveList.StatusBarShortcutDescription = null;
            this.gridViewIncentiveList.ViewCaption = "Incentives";
            this.gridViewIncentiveList.DoubleClick += new System.EventHandler(this.gridViewIncentiveList_DoubleClick);
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
            // colIncentiveName
            // 
            this.colIncentiveName.Caption = "Incentive Name";
            this.colIncentiveName.FieldName = "IncentiveName";
            this.colIncentiveName.Name = "colIncentiveName";
            this.colIncentiveName.OptionsColumn.AllowEdit = false;
            this.colIncentiveName.StatusBarDescription = null;
            this.colIncentiveName.StatusBarShortcut = null;
            this.colIncentiveName.StatusBarShortcutDescription = null;
            this.colIncentiveName.Visible = true;
            this.colIncentiveName.VisibleIndex = 1;
            this.colIncentiveName.Width = 350;
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
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 450;
            // 
            // IncentiveListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlIncentiveList);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IncentiveListForm";
            this.Text = "Incentive List";
            this.Load += new System.EventHandler(this.IncentiveListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlIncentiveList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIncentiveList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncentiveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlIncentiveList;
        private UserControls.Grids.MyGridView gridViewIncentiveList;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colIncentiveName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}