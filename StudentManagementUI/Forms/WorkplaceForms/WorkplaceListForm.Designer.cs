namespace StudentManagementUI.Forms.WorkplaceForms
{
    partial class WorkplaceListForm
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
            this.gridControlWorkplaces = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewWorkplaces = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colWorkplaceName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorkplaces)).BeginInit();
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
            // gridControlWorkplaces
            // 
            this.gridControlWorkplaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWorkplaces.Location = new System.Drawing.Point(0, 102);
            this.gridControlWorkplaces.MainView = this.gridViewWorkplaces;
            this.gridControlWorkplaces.MenuManager = this.ribbonControl;
            this.gridControlWorkplaces.Name = "gridControlWorkplaces";
            this.gridControlWorkplaces.Size = new System.Drawing.Size(1120, 236);
            this.gridControlWorkplaces.TabIndex = 3;
            this.gridControlWorkplaces.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorkplaces});
            // 
            // gridViewWorkplaces
            // 
            this.gridViewWorkplaces.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewWorkplaces.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewWorkplaces.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewWorkplaces.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewWorkplaces.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewWorkplaces.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewWorkplaces.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewWorkplaces.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewWorkplaces.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewWorkplaces.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewWorkplaces.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colWorkplaceName,
            this.colDescription});
            this.gridViewWorkplaces.GridControl = this.gridControlWorkplaces;
            this.gridViewWorkplaces.Name = "gridViewWorkplaces";
            this.gridViewWorkplaces.OptionsMenu.EnableColumnMenu = false;
            this.gridViewWorkplaces.OptionsMenu.EnableFooterMenu = false;
            this.gridViewWorkplaces.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewWorkplaces.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewWorkplaces.OptionsPrint.AutoWidth = false;
            this.gridViewWorkplaces.OptionsPrint.PrintFooter = false;
            this.gridViewWorkplaces.OptionsPrint.PrintGroupFooter = false;
            this.gridViewWorkplaces.OptionsView.ColumnAutoWidth = false;
            this.gridViewWorkplaces.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewWorkplaces.OptionsView.RowAutoHeight = true;
            this.gridViewWorkplaces.OptionsView.ShowAutoFilterRow = true;
            this.gridViewWorkplaces.OptionsView.ShowGroupPanel = false;
            this.gridViewWorkplaces.OptionsView.ShowViewCaption = true;
            this.gridViewWorkplaces.StatusBarDescription = null;
            this.gridViewWorkplaces.StatusBarShortcut = null;
            this.gridViewWorkplaces.StatusBarShortcutDescription = null;
            this.gridViewWorkplaces.ViewCaption = "Workplaces";
            this.gridViewWorkplaces.DoubleClick += new System.EventHandler(this.gridViewWorkplaces_DoubleClick);
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
            // colWorkplaceName
            // 
            this.colWorkplaceName.Caption = "Workplace Name";
            this.colWorkplaceName.FieldName = "WorkplaceName";
            this.colWorkplaceName.Name = "colWorkplaceName";
            this.colWorkplaceName.OptionsColumn.AllowEdit = false;
            this.colWorkplaceName.StatusBarDescription = null;
            this.colWorkplaceName.StatusBarShortcut = null;
            this.colWorkplaceName.StatusBarShortcutDescription = null;
            this.colWorkplaceName.Visible = true;
            this.colWorkplaceName.VisibleIndex = 1;
            this.colWorkplaceName.Width = 350;
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
            // WorkplaceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlWorkplaces);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "WorkplaceListForm";
            this.Text = "Workplace List";
            this.Load += new System.EventHandler(this.WorkplaceListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlWorkplaces, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorkplaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlWorkplaces;
        private UserControls.Grids.MyGridView gridViewWorkplaces;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colWorkplaceName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}