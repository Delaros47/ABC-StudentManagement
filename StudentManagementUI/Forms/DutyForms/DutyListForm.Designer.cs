namespace StudentManagementUI.Forms.DutyForms
{
    partial class DutyListForm
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
            this.gridControlDuties = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewDuties = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDutyName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDuties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDuties)).BeginInit();
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
            // gridControlDuties
            // 
            this.gridControlDuties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDuties.Location = new System.Drawing.Point(0, 102);
            this.gridControlDuties.MainView = this.gridViewDuties;
            this.gridControlDuties.MenuManager = this.ribbonControl;
            this.gridControlDuties.Name = "gridControlDuties";
            this.gridControlDuties.Size = new System.Drawing.Size(1120, 236);
            this.gridControlDuties.TabIndex = 3;
            this.gridControlDuties.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDuties});
            // 
            // gridViewDuties
            // 
            this.gridViewDuties.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewDuties.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDuties.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDuties.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDuties.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDuties.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDuties.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDuties.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDuties.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewDuties.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewDuties.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colDutyName,
            this.colDescription});
            this.gridViewDuties.GridControl = this.gridControlDuties;
            this.gridViewDuties.Name = "gridViewDuties";
            this.gridViewDuties.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDuties.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDuties.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDuties.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewDuties.OptionsPrint.AutoWidth = false;
            this.gridViewDuties.OptionsPrint.PrintFooter = false;
            this.gridViewDuties.OptionsPrint.PrintGroupFooter = false;
            this.gridViewDuties.OptionsView.ColumnAutoWidth = false;
            this.gridViewDuties.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewDuties.OptionsView.RowAutoHeight = true;
            this.gridViewDuties.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDuties.OptionsView.ShowGroupPanel = false;
            this.gridViewDuties.OptionsView.ShowViewCaption = true;
            this.gridViewDuties.StatusBarDescription = null;
            this.gridViewDuties.StatusBarShortcut = null;
            this.gridViewDuties.StatusBarShortcutDescription = null;
            this.gridViewDuties.ViewCaption = "Duties";
            this.gridViewDuties.DoubleClick += new System.EventHandler(this.gridViewDuties_DoubleClick);
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
            // colDutyName
            // 
            this.colDutyName.Caption = "Duty Name";
            this.colDutyName.FieldName = "DutyName";
            this.colDutyName.Name = "colDutyName";
            this.colDutyName.OptionsColumn.AllowEdit = false;
            this.colDutyName.StatusBarDescription = null;
            this.colDutyName.StatusBarShortcut = null;
            this.colDutyName.StatusBarShortcutDescription = null;
            this.colDutyName.Visible = true;
            this.colDutyName.VisibleIndex = 1;
            this.colDutyName.Width = 300;
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
            // DutyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlDuties);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "DutyListForm";
            this.Text = "Duty List";
            this.Load += new System.EventHandler(this.DutyListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlDuties, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDuties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDuties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlDuties;
        private UserControls.Grids.MyGridView gridViewDuties;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colDutyName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}