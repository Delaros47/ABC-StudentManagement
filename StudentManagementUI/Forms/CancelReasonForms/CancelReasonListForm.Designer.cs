namespace StudentManagementUI.Forms.CancelReasonForms
{
    partial class CancelReasonListForm
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
            this.gridControlCancelReason = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewCancelReason = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colCancelReason = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCancelReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCancelReason)).BeginInit();
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
            // gridControlCancelReason
            // 
            this.gridControlCancelReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCancelReason.Location = new System.Drawing.Point(0, 102);
            this.gridControlCancelReason.MainView = this.gridViewCancelReason;
            this.gridControlCancelReason.MenuManager = this.ribbonControl;
            this.gridControlCancelReason.Name = "gridControlCancelReason";
            this.gridControlCancelReason.Size = new System.Drawing.Size(1120, 236);
            this.gridControlCancelReason.TabIndex = 3;
            this.gridControlCancelReason.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCancelReason});
            // 
            // gridViewCancelReason
            // 
            this.gridViewCancelReason.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCancelReason.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCancelReason.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCancelReason.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCancelReason.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCancelReason.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCancelReason.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCancelReason.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCancelReason.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCancelReason.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCancelReason.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colCancelReason,
            this.colDescription});
            this.gridViewCancelReason.GridControl = this.gridControlCancelReason;
            this.gridViewCancelReason.Name = "gridViewCancelReason";
            this.gridViewCancelReason.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCancelReason.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCancelReason.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCancelReason.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCancelReason.OptionsPrint.AutoWidth = false;
            this.gridViewCancelReason.OptionsPrint.PrintFooter = false;
            this.gridViewCancelReason.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCancelReason.OptionsView.ColumnAutoWidth = false;
            this.gridViewCancelReason.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCancelReason.OptionsView.RowAutoHeight = true;
            this.gridViewCancelReason.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCancelReason.OptionsView.ShowGroupPanel = false;
            this.gridViewCancelReason.OptionsView.ShowViewCaption = true;
            this.gridViewCancelReason.StatusBarDescription = null;
            this.gridViewCancelReason.StatusBarShortcut = null;
            this.gridViewCancelReason.StatusBarShortcutDescription = null;
            this.gridViewCancelReason.ViewCaption = "Cancel Reason";
            this.gridViewCancelReason.DoubleClick += new System.EventHandler(this.gridViewCancelReason_DoubleClick);
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
            // colCancelReason
            // 
            this.colCancelReason.Caption = "Cancel Reason";
            this.colCancelReason.FieldName = "CancelReasonName";
            this.colCancelReason.Name = "colCancelReason";
            this.colCancelReason.OptionsColumn.AllowEdit = false;
            this.colCancelReason.StatusBarDescription = null;
            this.colCancelReason.StatusBarShortcut = null;
            this.colCancelReason.StatusBarShortcutDescription = null;
            this.colCancelReason.Visible = true;
            this.colCancelReason.VisibleIndex = 1;
            this.colCancelReason.Width = 350;
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
            // CancelReasonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlCancelReason);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CancelReasonListForm";
            this.Text = "Cancel Reason List";
            this.Load += new System.EventHandler(this.CancelReasonListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlCancelReason, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCancelReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCancelReason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlCancelReason;
        private UserControls.Grids.MyGridView gridViewCancelReason;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colCancelReason;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}