namespace StudentManagementUI.Forms.ServiceTypeForms
{
    partial class ServiceTypeListForm
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
            this.gridControlServiceTypes = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewServiceTypes = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colServiceTypeName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colServiceTypee = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServiceTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServiceTypes)).BeginInit();
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
            // gridControlServiceTypes
            // 
            this.gridControlServiceTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlServiceTypes.Location = new System.Drawing.Point(0, 102);
            this.gridControlServiceTypes.MainView = this.gridViewServiceTypes;
            this.gridControlServiceTypes.MenuManager = this.ribbonControl;
            this.gridControlServiceTypes.Name = "gridControlServiceTypes";
            this.gridControlServiceTypes.Size = new System.Drawing.Size(1120, 236);
            this.gridControlServiceTypes.TabIndex = 3;
            this.gridControlServiceTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServiceTypes});
            // 
            // gridViewServiceTypes
            // 
            this.gridViewServiceTypes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewServiceTypes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewServiceTypes.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewServiceTypes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewServiceTypes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewServiceTypes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewServiceTypes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewServiceTypes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewServiceTypes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewServiceTypes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewServiceTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colServiceTypeName,
            this.colServiceTypee,
            this.colDescription});
            this.gridViewServiceTypes.GridControl = this.gridControlServiceTypes;
            this.gridViewServiceTypes.Name = "gridViewServiceTypes";
            this.gridViewServiceTypes.OptionsMenu.EnableColumnMenu = false;
            this.gridViewServiceTypes.OptionsMenu.EnableFooterMenu = false;
            this.gridViewServiceTypes.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewServiceTypes.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewServiceTypes.OptionsPrint.AutoWidth = false;
            this.gridViewServiceTypes.OptionsPrint.PrintFooter = false;
            this.gridViewServiceTypes.OptionsPrint.PrintGroupFooter = false;
            this.gridViewServiceTypes.OptionsView.ColumnAutoWidth = false;
            this.gridViewServiceTypes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewServiceTypes.OptionsView.RowAutoHeight = true;
            this.gridViewServiceTypes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewServiceTypes.OptionsView.ShowGroupPanel = false;
            this.gridViewServiceTypes.OptionsView.ShowViewCaption = true;
            this.gridViewServiceTypes.StatusBarDescription = null;
            this.gridViewServiceTypes.StatusBarShortcut = null;
            this.gridViewServiceTypes.StatusBarShortcutDescription = null;
            this.gridViewServiceTypes.ViewCaption = "Service Types";
            this.gridViewServiceTypes.DoubleClick += new System.EventHandler(this.gridViewServiceTypes_DoubleClick);
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
            // colServiceTypeName
            // 
            this.colServiceTypeName.Caption = "Service Type Name";
            this.colServiceTypeName.FieldName = "ServiceTypeName";
            this.colServiceTypeName.Name = "colServiceTypeName";
            this.colServiceTypeName.OptionsColumn.AllowEdit = false;
            this.colServiceTypeName.StatusBarDescription = null;
            this.colServiceTypeName.StatusBarShortcut = null;
            this.colServiceTypeName.StatusBarShortcutDescription = null;
            this.colServiceTypeName.Visible = true;
            this.colServiceTypeName.VisibleIndex = 1;
            this.colServiceTypeName.Width = 200;
            // 
            // colServiceTypee
            // 
            this.colServiceTypee.Caption = "Service Type";
            this.colServiceTypee.FieldName = "ServiceTypee";
            this.colServiceTypee.Name = "colServiceTypee";
            this.colServiceTypee.OptionsColumn.AllowEdit = false;
            this.colServiceTypee.StatusBarDescription = null;
            this.colServiceTypee.StatusBarShortcut = null;
            this.colServiceTypee.StatusBarShortcutDescription = null;
            this.colServiceTypee.Visible = true;
            this.colServiceTypee.VisibleIndex = 2;
            this.colServiceTypee.Width = 200;
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
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 450;
            // 
            // ServiceTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlServiceTypes);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ServiceTypeListForm";
            this.Text = "Service Type List";
            this.Load += new System.EventHandler(this.ServiceTypeListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlServiceTypes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServiceTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServiceTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlServiceTypes;
        private UserControls.Grids.MyGridView gridViewServiceTypes;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colServiceTypeName;
        private UserControls.Grids.MyGridColumn colServiceTypee;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}