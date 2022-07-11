namespace StudentManagementUI.Forms.GuidanceCounselorForms
{
    partial class GuidanceCounselorListForm
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
            this.gridControlGuidanceCounselors = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewGuidanceCounselors = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colNameSurname = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPhone1 = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPhone2 = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuidanceCounselors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuidanceCounselors)).BeginInit();
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
            // gridControlGuidanceCounselors
            // 
            this.gridControlGuidanceCounselors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGuidanceCounselors.Location = new System.Drawing.Point(0, 102);
            this.gridControlGuidanceCounselors.MainView = this.gridViewGuidanceCounselors;
            this.gridControlGuidanceCounselors.MenuManager = this.ribbonControl;
            this.gridControlGuidanceCounselors.Name = "gridControlGuidanceCounselors";
            this.gridControlGuidanceCounselors.Size = new System.Drawing.Size(1120, 236);
            this.gridControlGuidanceCounselors.TabIndex = 3;
            this.gridControlGuidanceCounselors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGuidanceCounselors});
            // 
            // gridViewGuidanceCounselors
            // 
            this.gridViewGuidanceCounselors.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewGuidanceCounselors.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewGuidanceCounselors.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewGuidanceCounselors.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewGuidanceCounselors.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewGuidanceCounselors.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewGuidanceCounselors.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewGuidanceCounselors.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewGuidanceCounselors.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewGuidanceCounselors.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewGuidanceCounselors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colNameSurname,
            this.colPhone1,
            this.colPhone2,
            this.colDescription});
            this.gridViewGuidanceCounselors.GridControl = this.gridControlGuidanceCounselors;
            this.gridViewGuidanceCounselors.Name = "gridViewGuidanceCounselors";
            this.gridViewGuidanceCounselors.OptionsMenu.EnableColumnMenu = false;
            this.gridViewGuidanceCounselors.OptionsMenu.EnableFooterMenu = false;
            this.gridViewGuidanceCounselors.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewGuidanceCounselors.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewGuidanceCounselors.OptionsPrint.AutoWidth = false;
            this.gridViewGuidanceCounselors.OptionsPrint.PrintFooter = false;
            this.gridViewGuidanceCounselors.OptionsPrint.PrintGroupFooter = false;
            this.gridViewGuidanceCounselors.OptionsView.ColumnAutoWidth = false;
            this.gridViewGuidanceCounselors.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewGuidanceCounselors.OptionsView.RowAutoHeight = true;
            this.gridViewGuidanceCounselors.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGuidanceCounselors.OptionsView.ShowGroupPanel = false;
            this.gridViewGuidanceCounselors.OptionsView.ShowViewCaption = true;
            this.gridViewGuidanceCounselors.StatusBarDescription = null;
            this.gridViewGuidanceCounselors.StatusBarShortcut = null;
            this.gridViewGuidanceCounselors.StatusBarShortcutDescription = null;
            this.gridViewGuidanceCounselors.ViewCaption = "Guidance Counselors";
            this.gridViewGuidanceCounselors.DoubleClick += new System.EventHandler(this.gridViewGuidanceCounselors_DoubleClick);
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
            // colNameSurname
            // 
            this.colNameSurname.Caption = "Name Surname";
            this.colNameSurname.FieldName = "NameSurname";
            this.colNameSurname.Name = "colNameSurname";
            this.colNameSurname.OptionsColumn.AllowEdit = false;
            this.colNameSurname.StatusBarDescription = null;
            this.colNameSurname.StatusBarShortcut = null;
            this.colNameSurname.StatusBarShortcutDescription = null;
            this.colNameSurname.Visible = true;
            this.colNameSurname.VisibleIndex = 1;
            this.colNameSurname.Width = 200;
            // 
            // colPhone1
            // 
            this.colPhone1.Caption = "Phone-1";
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowEdit = false;
            this.colPhone1.StatusBarDescription = null;
            this.colPhone1.StatusBarShortcut = null;
            this.colPhone1.StatusBarShortcutDescription = null;
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 2;
            this.colPhone1.Width = 150;
            // 
            // colPhone2
            // 
            this.colPhone2.Caption = "Phone-2";
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowEdit = false;
            this.colPhone2.StatusBarDescription = null;
            this.colPhone2.StatusBarShortcut = null;
            this.colPhone2.StatusBarShortcutDescription = null;
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 3;
            this.colPhone2.Width = 150;
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
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 450;
            // 
            // GuidanceCounselorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlGuidanceCounselors);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "GuidanceCounselorListForm";
            this.Text = "Guidance Counselor List";
            this.Load += new System.EventHandler(this.GuidanceCounselorListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlGuidanceCounselors, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuidanceCounselors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuidanceCounselors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlGuidanceCounselors;
        private UserControls.Grids.MyGridView gridViewGuidanceCounselors;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colNameSurname;
        private UserControls.Grids.MyGridColumn colPhone1;
        private UserControls.Grids.MyGridColumn colPhone2;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}