namespace StudentManagementUI.Forms.FamilyIntimacyForms
{
    partial class FamilyIntimacyListForm
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
            this.gridControlFamilyIntimacies = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewFamilyIntimacies = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colFamilyIntimacyName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFamilyIntimacies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFamilyIntimacies)).BeginInit();
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
            // gridControlFamilyIntimacies
            // 
            this.gridControlFamilyIntimacies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFamilyIntimacies.Location = new System.Drawing.Point(0, 102);
            this.gridControlFamilyIntimacies.MainView = this.gridViewFamilyIntimacies;
            this.gridControlFamilyIntimacies.MenuManager = this.ribbonControl;
            this.gridControlFamilyIntimacies.Name = "gridControlFamilyIntimacies";
            this.gridControlFamilyIntimacies.Size = new System.Drawing.Size(1120, 238);
            this.gridControlFamilyIntimacies.TabIndex = 3;
            this.gridControlFamilyIntimacies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFamilyIntimacies});
            // 
            // gridViewFamilyIntimacies
            // 
            this.gridViewFamilyIntimacies.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewFamilyIntimacies.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewFamilyIntimacies.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewFamilyIntimacies.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewFamilyIntimacies.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewFamilyIntimacies.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewFamilyIntimacies.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewFamilyIntimacies.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewFamilyIntimacies.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewFamilyIntimacies.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewFamilyIntimacies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colFamilyIntimacyName,
            this.colDescription});
            this.gridViewFamilyIntimacies.GridControl = this.gridControlFamilyIntimacies;
            this.gridViewFamilyIntimacies.Name = "gridViewFamilyIntimacies";
            this.gridViewFamilyIntimacies.OptionsMenu.EnableColumnMenu = false;
            this.gridViewFamilyIntimacies.OptionsMenu.EnableFooterMenu = false;
            this.gridViewFamilyIntimacies.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewFamilyIntimacies.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewFamilyIntimacies.OptionsPrint.AutoWidth = false;
            this.gridViewFamilyIntimacies.OptionsPrint.PrintFooter = false;
            this.gridViewFamilyIntimacies.OptionsPrint.PrintGroupFooter = false;
            this.gridViewFamilyIntimacies.OptionsView.ColumnAutoWidth = false;
            this.gridViewFamilyIntimacies.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewFamilyIntimacies.OptionsView.RowAutoHeight = true;
            this.gridViewFamilyIntimacies.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFamilyIntimacies.OptionsView.ShowGroupPanel = false;
            this.gridViewFamilyIntimacies.OptionsView.ShowViewCaption = true;
            this.gridViewFamilyIntimacies.StatusBarDescription = null;
            this.gridViewFamilyIntimacies.StatusBarShortcut = null;
            this.gridViewFamilyIntimacies.StatusBarShortcutDescription = null;
            this.gridViewFamilyIntimacies.ViewCaption = "Family Intimacies";
            this.gridViewFamilyIntimacies.DoubleClick += new System.EventHandler(this.gridViewFamilyIntimacies_DoubleClick);
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
            // colFamilyIntimacyName
            // 
            this.colFamilyIntimacyName.Caption = "Family Intimacy Name";
            this.colFamilyIntimacyName.FieldName = "FamilyIntimacyName";
            this.colFamilyIntimacyName.Name = "colFamilyIntimacyName";
            this.colFamilyIntimacyName.OptionsColumn.AllowEdit = false;
            this.colFamilyIntimacyName.StatusBarDescription = null;
            this.colFamilyIntimacyName.StatusBarShortcut = null;
            this.colFamilyIntimacyName.StatusBarShortcutDescription = null;
            this.colFamilyIntimacyName.Visible = true;
            this.colFamilyIntimacyName.VisibleIndex = 1;
            this.colFamilyIntimacyName.Width = 250;
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
            // FamilyIntimacyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlFamilyIntimacies);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "FamilyIntimacyListForm";
            this.Text = "Family Intimacy List";
            this.Load += new System.EventHandler(this.FamilyIntimacyListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlFamilyIntimacies, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFamilyIntimacies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFamilyIntimacies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlFamilyIntimacies;
        private UserControls.Grids.MyGridView gridViewFamilyIntimacies;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colFamilyIntimacyName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}