namespace StudentManagementUI.Forms.FamilyInformationForms
{
    partial class FamilyInformationListForm
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
            this.gridControlFamilyInformation = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewFamilyInformation = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colFamilyInformationName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFamilyInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFamilyInformation)).BeginInit();
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
            // gridControlFamilyInformation
            // 
            this.gridControlFamilyInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFamilyInformation.Location = new System.Drawing.Point(0, 102);
            this.gridControlFamilyInformation.MainView = this.gridViewFamilyInformation;
            this.gridControlFamilyInformation.MenuManager = this.ribbonControl;
            this.gridControlFamilyInformation.Name = "gridControlFamilyInformation";
            this.gridControlFamilyInformation.Size = new System.Drawing.Size(1120, 238);
            this.gridControlFamilyInformation.TabIndex = 3;
            this.gridControlFamilyInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFamilyInformation});
            // 
            // gridViewFamilyInformation
            // 
            this.gridViewFamilyInformation.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewFamilyInformation.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewFamilyInformation.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewFamilyInformation.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewFamilyInformation.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewFamilyInformation.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewFamilyInformation.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewFamilyInformation.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewFamilyInformation.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewFamilyInformation.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewFamilyInformation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colFamilyInformationName,
            this.colDescription});
            this.gridViewFamilyInformation.GridControl = this.gridControlFamilyInformation;
            this.gridViewFamilyInformation.Name = "gridViewFamilyInformation";
            this.gridViewFamilyInformation.OptionsMenu.EnableColumnMenu = false;
            this.gridViewFamilyInformation.OptionsMenu.EnableFooterMenu = false;
            this.gridViewFamilyInformation.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewFamilyInformation.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewFamilyInformation.OptionsPrint.AutoWidth = false;
            this.gridViewFamilyInformation.OptionsPrint.PrintFooter = false;
            this.gridViewFamilyInformation.OptionsPrint.PrintGroupFooter = false;
            this.gridViewFamilyInformation.OptionsView.ColumnAutoWidth = false;
            this.gridViewFamilyInformation.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewFamilyInformation.OptionsView.RowAutoHeight = true;
            this.gridViewFamilyInformation.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFamilyInformation.OptionsView.ShowGroupPanel = false;
            this.gridViewFamilyInformation.OptionsView.ShowViewCaption = true;
            this.gridViewFamilyInformation.StatusBarDescription = null;
            this.gridViewFamilyInformation.StatusBarShortcut = null;
            this.gridViewFamilyInformation.StatusBarShortcutDescription = null;
            this.gridViewFamilyInformation.ViewCaption = "Family Information";
            this.gridViewFamilyInformation.DoubleClick += new System.EventHandler(this.gridViewFamilyInformation_DoubleClick);
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
            // colFamilyInformationName
            // 
            this.colFamilyInformationName.Caption = "Family Information";
            this.colFamilyInformationName.FieldName = "InformationName";
            this.colFamilyInformationName.Name = "colFamilyInformationName";
            this.colFamilyInformationName.OptionsColumn.AllowEdit = false;
            this.colFamilyInformationName.StatusBarDescription = null;
            this.colFamilyInformationName.StatusBarShortcut = null;
            this.colFamilyInformationName.StatusBarShortcutDescription = null;
            this.colFamilyInformationName.Visible = true;
            this.colFamilyInformationName.VisibleIndex = 1;
            this.colFamilyInformationName.Width = 250;
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
            // FamilyInformationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlFamilyInformation);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "FamilyInformationListForm";
            this.Text = "Family Information";
            this.Load += new System.EventHandler(this.FamilyInformationListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlFamilyInformation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFamilyInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFamilyInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlFamilyInformation;
        private UserControls.Grids.MyGridView gridViewFamilyInformation;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colFamilyInformationName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}