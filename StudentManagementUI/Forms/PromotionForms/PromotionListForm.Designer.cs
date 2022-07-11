namespace StudentManagementUI.Forms.PromotionForms
{
    partial class PromotionListForm
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
            this.gridControlPromotions = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewPromotions = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPromotionName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPromotions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPromotions)).BeginInit();
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
            // gridControlPromotions
            // 
            this.gridControlPromotions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPromotions.Location = new System.Drawing.Point(0, 102);
            this.gridControlPromotions.MainView = this.gridViewPromotions;
            this.gridControlPromotions.MenuManager = this.ribbonControl;
            this.gridControlPromotions.Name = "gridControlPromotions";
            this.gridControlPromotions.Size = new System.Drawing.Size(1120, 236);
            this.gridControlPromotions.TabIndex = 3;
            this.gridControlPromotions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPromotions});
            // 
            // gridViewPromotions
            // 
            this.gridViewPromotions.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewPromotions.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewPromotions.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewPromotions.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewPromotions.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewPromotions.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewPromotions.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPromotions.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPromotions.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewPromotions.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewPromotions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colPromotionName,
            this.colDescription});
            this.gridViewPromotions.GridControl = this.gridControlPromotions;
            this.gridViewPromotions.Name = "gridViewPromotions";
            this.gridViewPromotions.OptionsMenu.EnableColumnMenu = false;
            this.gridViewPromotions.OptionsMenu.EnableFooterMenu = false;
            this.gridViewPromotions.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPromotions.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPromotions.OptionsPrint.AutoWidth = false;
            this.gridViewPromotions.OptionsPrint.PrintFooter = false;
            this.gridViewPromotions.OptionsPrint.PrintGroupFooter = false;
            this.gridViewPromotions.OptionsView.ColumnAutoWidth = false;
            this.gridViewPromotions.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewPromotions.OptionsView.RowAutoHeight = true;
            this.gridViewPromotions.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPromotions.OptionsView.ShowGroupPanel = false;
            this.gridViewPromotions.OptionsView.ShowViewCaption = true;
            this.gridViewPromotions.StatusBarDescription = null;
            this.gridViewPromotions.StatusBarShortcut = null;
            this.gridViewPromotions.StatusBarShortcutDescription = null;
            this.gridViewPromotions.ViewCaption = "Promotions";
            this.gridViewPromotions.DoubleClick += new System.EventHandler(this.gridViewPromotions_DoubleClick);
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
            // colPromotionName
            // 
            this.colPromotionName.Caption = "Promotion Name";
            this.colPromotionName.FieldName = "PromotionName";
            this.colPromotionName.Name = "colPromotionName";
            this.colPromotionName.OptionsColumn.AllowEdit = false;
            this.colPromotionName.StatusBarDescription = null;
            this.colPromotionName.StatusBarShortcut = null;
            this.colPromotionName.StatusBarShortcutDescription = null;
            this.colPromotionName.Visible = true;
            this.colPromotionName.VisibleIndex = 1;
            this.colPromotionName.Width = 350;
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
            // PromotionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlPromotions);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "PromotionListForm";
            this.Text = "Promotion List";
            this.Load += new System.EventHandler(this.PromotionListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlPromotions, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPromotions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPromotions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlPromotions;
        private UserControls.Grids.MyGridView gridViewPromotions;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colPromotionName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}