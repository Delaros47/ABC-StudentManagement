namespace StudentManagementUI.Forms.SpecialCodeForms
{
    partial class SpecialCodeListForm
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
            this.gridControlSpecialCodes = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewSpecialCodes = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colSpecialCodeName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSpecialCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSpecialCodes)).BeginInit();
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
            // gridControlSpecialCodes
            // 
            this.gridControlSpecialCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSpecialCodes.Location = new System.Drawing.Point(0, 102);
            this.gridControlSpecialCodes.MainView = this.gridViewSpecialCodes;
            this.gridControlSpecialCodes.MenuManager = this.ribbonControl;
            this.gridControlSpecialCodes.Name = "gridControlSpecialCodes";
            this.gridControlSpecialCodes.Size = new System.Drawing.Size(1120, 238);
            this.gridControlSpecialCodes.TabIndex = 3;
            this.gridControlSpecialCodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSpecialCodes});
            // 
            // gridViewSpecialCodes
            // 
            this.gridViewSpecialCodes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewSpecialCodes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSpecialCodes.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewSpecialCodes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewSpecialCodes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSpecialCodes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSpecialCodes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSpecialCodes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSpecialCodes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSpecialCodes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewSpecialCodes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colSpecialCodeName,
            this.colDescription});
            this.gridViewSpecialCodes.GridControl = this.gridControlSpecialCodes;
            this.gridViewSpecialCodes.Name = "gridViewSpecialCodes";
            this.gridViewSpecialCodes.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSpecialCodes.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSpecialCodes.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSpecialCodes.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSpecialCodes.OptionsPrint.AutoWidth = false;
            this.gridViewSpecialCodes.OptionsPrint.PrintFooter = false;
            this.gridViewSpecialCodes.OptionsPrint.PrintGroupFooter = false;
            this.gridViewSpecialCodes.OptionsView.ColumnAutoWidth = false;
            this.gridViewSpecialCodes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewSpecialCodes.OptionsView.RowAutoHeight = true;
            this.gridViewSpecialCodes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSpecialCodes.OptionsView.ShowGroupPanel = false;
            this.gridViewSpecialCodes.OptionsView.ShowViewCaption = true;
            this.gridViewSpecialCodes.StatusBarDescription = null;
            this.gridViewSpecialCodes.StatusBarShortcut = null;
            this.gridViewSpecialCodes.StatusBarShortcutDescription = null;
            this.gridViewSpecialCodes.ViewCaption = "Special Codes";
            this.gridViewSpecialCodes.DoubleClick += new System.EventHandler(this.gridViewSpecialCodes_DoubleClick);
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
            // colSpecialCodeName
            // 
            this.colSpecialCodeName.Caption = "Special Code Name";
            this.colSpecialCodeName.FieldName = "SpecialCodeName";
            this.colSpecialCodeName.Name = "colSpecialCodeName";
            this.colSpecialCodeName.OptionsColumn.AllowEdit = false;
            this.colSpecialCodeName.StatusBarDescription = null;
            this.colSpecialCodeName.StatusBarShortcut = null;
            this.colSpecialCodeName.StatusBarShortcutDescription = null;
            this.colSpecialCodeName.Visible = true;
            this.colSpecialCodeName.VisibleIndex = 1;
            this.colSpecialCodeName.Width = 350;
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
            // SpecialCodeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlSpecialCodes);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "SpecialCodeListForm";
            this.Text = "Special Code List";
            this.Load += new System.EventHandler(this.SpecialCodeListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlSpecialCodes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSpecialCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSpecialCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlSpecialCodes;
        private UserControls.Grids.MyGridView gridViewSpecialCodes;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colSpecialCodeName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}