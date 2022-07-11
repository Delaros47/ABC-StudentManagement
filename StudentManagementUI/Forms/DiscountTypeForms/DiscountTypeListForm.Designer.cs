namespace StudentManagementUI.Forms.DiscountTypeForms
{
    partial class DiscountTypeListForm
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
            this.gridControlDiscountTypes = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewDiscountTypes = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDiscountTypeName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiscountTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountTypes)).BeginInit();
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
            // gridControlDiscountTypes
            // 
            this.gridControlDiscountTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDiscountTypes.Location = new System.Drawing.Point(0, 102);
            this.gridControlDiscountTypes.MainView = this.gridViewDiscountTypes;
            this.gridControlDiscountTypes.MenuManager = this.ribbonControl;
            this.gridControlDiscountTypes.Name = "gridControlDiscountTypes";
            this.gridControlDiscountTypes.Size = new System.Drawing.Size(1120, 236);
            this.gridControlDiscountTypes.TabIndex = 3;
            this.gridControlDiscountTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiscountTypes});
            // 
            // gridViewDiscountTypes
            // 
            this.gridViewDiscountTypes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewDiscountTypes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDiscountTypes.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDiscountTypes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDiscountTypes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDiscountTypes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDiscountTypes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDiscountTypes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDiscountTypes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDiscountTypes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewDiscountTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colDiscountTypeName,
            this.colDescription});
            this.gridViewDiscountTypes.GridControl = this.gridControlDiscountTypes;
            this.gridViewDiscountTypes.Name = "gridViewDiscountTypes";
            this.gridViewDiscountTypes.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDiscountTypes.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDiscountTypes.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDiscountTypes.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewDiscountTypes.OptionsPrint.AutoWidth = false;
            this.gridViewDiscountTypes.OptionsPrint.PrintFooter = false;
            this.gridViewDiscountTypes.OptionsPrint.PrintGroupFooter = false;
            this.gridViewDiscountTypes.OptionsView.ColumnAutoWidth = false;
            this.gridViewDiscountTypes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDiscountTypes.OptionsView.RowAutoHeight = true;
            this.gridViewDiscountTypes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDiscountTypes.OptionsView.ShowGroupPanel = false;
            this.gridViewDiscountTypes.OptionsView.ShowViewCaption = true;
            this.gridViewDiscountTypes.StatusBarDescription = null;
            this.gridViewDiscountTypes.StatusBarShortcut = null;
            this.gridViewDiscountTypes.StatusBarShortcutDescription = null;
            this.gridViewDiscountTypes.ViewCaption = "Discount Types";
            this.gridViewDiscountTypes.DoubleClick += new System.EventHandler(this.gridViewDiscountTypes_DoubleClick);
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
            // colDiscountTypeName
            // 
            this.colDiscountTypeName.Caption = "Discount Type Name";
            this.colDiscountTypeName.FieldName = "DiscountTypeName";
            this.colDiscountTypeName.Name = "colDiscountTypeName";
            this.colDiscountTypeName.OptionsColumn.AllowEdit = false;
            this.colDiscountTypeName.StatusBarDescription = null;
            this.colDiscountTypeName.StatusBarShortcut = null;
            this.colDiscountTypeName.StatusBarShortcutDescription = null;
            this.colDiscountTypeName.Visible = true;
            this.colDiscountTypeName.VisibleIndex = 1;
            this.colDiscountTypeName.Width = 300;
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
            // DiscountTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlDiscountTypes);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "DiscountTypeListForm";
            this.Text = "Discount Type List";
            this.Load += new System.EventHandler(this.DiscountTypeListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlDiscountTypes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiscountTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlDiscountTypes;
        private UserControls.Grids.MyGridView gridViewDiscountTypes;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colDiscountTypeName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}