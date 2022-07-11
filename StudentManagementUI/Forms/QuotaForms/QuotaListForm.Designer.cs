namespace StudentManagementUI.Forms.QuotaForms
{
    partial class QuotaListForm
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
            this.gridControlQuotas = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewQuotas = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colQuotaName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.myGridColumn2 = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotas)).BeginInit();
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
            // gridControlQuotas
            // 
            this.gridControlQuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuotas.Location = new System.Drawing.Point(0, 102);
            this.gridControlQuotas.MainView = this.gridViewQuotas;
            this.gridControlQuotas.MenuManager = this.ribbonControl;
            this.gridControlQuotas.Name = "gridControlQuotas";
            this.gridControlQuotas.Size = new System.Drawing.Size(1120, 236);
            this.gridControlQuotas.TabIndex = 3;
            this.gridControlQuotas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuotas});
            // 
            // gridViewQuotas
            // 
            this.gridViewQuotas.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewQuotas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewQuotas.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewQuotas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewQuotas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewQuotas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewQuotas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewQuotas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewQuotas.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewQuotas.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewQuotas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colQuotaName,
            this.myGridColumn2});
            this.gridViewQuotas.GridControl = this.gridControlQuotas;
            this.gridViewQuotas.Name = "gridViewQuotas";
            this.gridViewQuotas.OptionsMenu.EnableColumnMenu = false;
            this.gridViewQuotas.OptionsMenu.EnableFooterMenu = false;
            this.gridViewQuotas.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewQuotas.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewQuotas.OptionsPrint.AutoWidth = false;
            this.gridViewQuotas.OptionsPrint.PrintFooter = false;
            this.gridViewQuotas.OptionsPrint.PrintGroupFooter = false;
            this.gridViewQuotas.OptionsView.ColumnAutoWidth = false;
            this.gridViewQuotas.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewQuotas.OptionsView.RowAutoHeight = true;
            this.gridViewQuotas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewQuotas.OptionsView.ShowGroupPanel = false;
            this.gridViewQuotas.OptionsView.ShowViewCaption = true;
            this.gridViewQuotas.StatusBarDescription = null;
            this.gridViewQuotas.StatusBarShortcut = null;
            this.gridViewQuotas.StatusBarShortcutDescription = null;
            this.gridViewQuotas.ViewCaption = "Quotas";
            this.gridViewQuotas.DoubleClick += new System.EventHandler(this.gridViewQuotas_DoubleClick);
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
            // colQuotaName
            // 
            this.colQuotaName.Caption = "Quota Name";
            this.colQuotaName.FieldName = "QuotaName";
            this.colQuotaName.Name = "colQuotaName";
            this.colQuotaName.OptionsColumn.AllowEdit = false;
            this.colQuotaName.StatusBarDescription = null;
            this.colQuotaName.StatusBarShortcut = null;
            this.colQuotaName.StatusBarShortcutDescription = null;
            this.colQuotaName.Visible = true;
            this.colQuotaName.VisibleIndex = 1;
            this.colQuotaName.Width = 250;
            // 
            // myGridColumn2
            // 
            this.myGridColumn2.Caption = "Description";
            this.myGridColumn2.Name = "myGridColumn2";
            this.myGridColumn2.OptionsColumn.AllowEdit = false;
            this.myGridColumn2.StatusBarDescription = null;
            this.myGridColumn2.StatusBarShortcut = null;
            this.myGridColumn2.StatusBarShortcutDescription = null;
            this.myGridColumn2.Visible = true;
            this.myGridColumn2.VisibleIndex = 2;
            this.myGridColumn2.Width = 450;
            // 
            // QuotaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlQuotas);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "QuotaListForm";
            this.Text = "Quota List";
            this.Load += new System.EventHandler(this.QuotaListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlQuotas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlQuotas;
        private UserControls.Grids.MyGridView gridViewQuotas;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colQuotaName;
        private UserControls.Grids.MyGridColumn myGridColumn2;
    }
}