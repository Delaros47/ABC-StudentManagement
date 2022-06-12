namespace StudentManagementUI.Forms.ClassGroupForms
{
    partial class ClassGroupListForm
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
            this.gridControlClassGroups = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewClassGroups = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colClassGroupName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClassGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClassGroups)).BeginInit();
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
            this.longNavigator1.Location = new System.Drawing.Point(0, 340);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1120, 24);
            this.longNavigator1.TabIndex = 2;
            // 
            // gridControlClassGroups
            // 
            this.gridControlClassGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClassGroups.Location = new System.Drawing.Point(0, 102);
            this.gridControlClassGroups.MainView = this.gridViewClassGroups;
            this.gridControlClassGroups.MenuManager = this.ribbonControl;
            this.gridControlClassGroups.Name = "gridControlClassGroups";
            this.gridControlClassGroups.Size = new System.Drawing.Size(1120, 238);
            this.gridControlClassGroups.TabIndex = 3;
            this.gridControlClassGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClassGroups});
            // 
            // gridViewClassGroups
            // 
            this.gridViewClassGroups.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewClassGroups.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewClassGroups.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewClassGroups.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewClassGroups.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewClassGroups.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewClassGroups.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewClassGroups.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassGroups.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewClassGroups.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewClassGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colClassGroupName,
            this.colDescription});
            this.gridViewClassGroups.GridControl = this.gridControlClassGroups;
            this.gridViewClassGroups.Name = "gridViewClassGroups";
            this.gridViewClassGroups.OptionsMenu.EnableColumnMenu = false;
            this.gridViewClassGroups.OptionsMenu.EnableFooterMenu = false;
            this.gridViewClassGroups.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewClassGroups.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewClassGroups.OptionsPrint.AutoWidth = false;
            this.gridViewClassGroups.OptionsPrint.PrintFooter = false;
            this.gridViewClassGroups.OptionsPrint.PrintGroupFooter = false;
            this.gridViewClassGroups.OptionsView.ColumnAutoWidth = false;
            this.gridViewClassGroups.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewClassGroups.OptionsView.RowAutoHeight = true;
            this.gridViewClassGroups.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClassGroups.OptionsView.ShowGroupPanel = false;
            this.gridViewClassGroups.OptionsView.ShowViewCaption = true;
            this.gridViewClassGroups.StatusBarDescription = null;
            this.gridViewClassGroups.StatusBarShortcut = null;
            this.gridViewClassGroups.StatusBarShortcutDescription = null;
            this.gridViewClassGroups.ViewCaption = "Class Groups";
            this.gridViewClassGroups.DoubleClick += new System.EventHandler(this.gridViewClassGroups_DoubleClick);
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
            // colClassGroupName
            // 
            this.colClassGroupName.Caption = "Class Group Name";
            this.colClassGroupName.FieldName = "ClassGroupName";
            this.colClassGroupName.Name = "colClassGroupName";
            this.colClassGroupName.OptionsColumn.AllowEdit = false;
            this.colClassGroupName.StatusBarDescription = null;
            this.colClassGroupName.StatusBarShortcut = null;
            this.colClassGroupName.StatusBarShortcutDescription = null;
            this.colClassGroupName.Visible = true;
            this.colClassGroupName.VisibleIndex = 1;
            this.colClassGroupName.Width = 200;
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
            // ClassGroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlClassGroups);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "ClassGroupListForm";
            this.Text = "Class Group List";
            this.Load += new System.EventHandler(this.ClassGroupListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlClassGroups, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClassGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClassGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlClassGroups;
        private UserControls.Grids.MyGridView gridViewClassGroups;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colClassGroupName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}