namespace StudentManagementUI.Forms.ForeignLanguageForms
{
    partial class ForeignLanguageListForm
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
            this.gridControlForeignLanguage = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewForeignLanguage = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colForeignLanguageName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlForeignLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewForeignLanguage)).BeginInit();
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
            // gridControlForeignLanguage
            // 
            this.gridControlForeignLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlForeignLanguage.Location = new System.Drawing.Point(0, 102);
            this.gridControlForeignLanguage.MainView = this.gridViewForeignLanguage;
            this.gridControlForeignLanguage.MenuManager = this.ribbonControl;
            this.gridControlForeignLanguage.Name = "gridControlForeignLanguage";
            this.gridControlForeignLanguage.Size = new System.Drawing.Size(1120, 236);
            this.gridControlForeignLanguage.TabIndex = 3;
            this.gridControlForeignLanguage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewForeignLanguage});
            // 
            // gridViewForeignLanguage
            // 
            this.gridViewForeignLanguage.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewForeignLanguage.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewForeignLanguage.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewForeignLanguage.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewForeignLanguage.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewForeignLanguage.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewForeignLanguage.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewForeignLanguage.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewForeignLanguage.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewForeignLanguage.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewForeignLanguage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colForeignLanguageName,
            this.colDescription});
            this.gridViewForeignLanguage.GridControl = this.gridControlForeignLanguage;
            this.gridViewForeignLanguage.Name = "gridViewForeignLanguage";
            this.gridViewForeignLanguage.OptionsMenu.EnableColumnMenu = false;
            this.gridViewForeignLanguage.OptionsMenu.EnableFooterMenu = false;
            this.gridViewForeignLanguage.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewForeignLanguage.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewForeignLanguage.OptionsPrint.AutoWidth = false;
            this.gridViewForeignLanguage.OptionsPrint.PrintFooter = false;
            this.gridViewForeignLanguage.OptionsPrint.PrintGroupFooter = false;
            this.gridViewForeignLanguage.OptionsView.ColumnAutoWidth = false;
            this.gridViewForeignLanguage.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewForeignLanguage.OptionsView.RowAutoHeight = true;
            this.gridViewForeignLanguage.OptionsView.ShowAutoFilterRow = true;
            this.gridViewForeignLanguage.OptionsView.ShowGroupPanel = false;
            this.gridViewForeignLanguage.OptionsView.ShowViewCaption = true;
            this.gridViewForeignLanguage.StatusBarDescription = null;
            this.gridViewForeignLanguage.StatusBarShortcut = null;
            this.gridViewForeignLanguage.StatusBarShortcutDescription = null;
            this.gridViewForeignLanguage.ViewCaption = "Foreign Languages";
            this.gridViewForeignLanguage.DoubleClick += new System.EventHandler(this.gridViewForeignLanguage_DoubleClick);
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
            // colForeignLanguageName
            // 
            this.colForeignLanguageName.Caption = "Foreign Language";
            this.colForeignLanguageName.FieldName = "ForeignLanguageName";
            this.colForeignLanguageName.Name = "colForeignLanguageName";
            this.colForeignLanguageName.OptionsColumn.AllowEdit = false;
            this.colForeignLanguageName.StatusBarDescription = null;
            this.colForeignLanguageName.StatusBarShortcut = null;
            this.colForeignLanguageName.StatusBarShortcutDescription = null;
            this.colForeignLanguageName.Visible = true;
            this.colForeignLanguageName.VisibleIndex = 1;
            this.colForeignLanguageName.Width = 250;
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
            // ForeignLanguageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlForeignLanguage);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ForeignLanguageListForm";
            this.Text = "Foreign Language List";
            this.Load += new System.EventHandler(this.ForeignLanguageListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlForeignLanguage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlForeignLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewForeignLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlForeignLanguage;
        private UserControls.Grids.MyGridView gridViewForeignLanguage;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colForeignLanguageName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}