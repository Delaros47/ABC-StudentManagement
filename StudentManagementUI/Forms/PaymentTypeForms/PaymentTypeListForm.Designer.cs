namespace StudentManagementUI.Forms.PaymentTypeForms
{
    partial class PaymentTypeListForm
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
            this.gridControlPayments = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewPaymentTypes = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPaymentTypeName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPaymentTypee = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentTypes)).BeginInit();
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
            // gridControlPayments
            // 
            this.gridControlPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPayments.Location = new System.Drawing.Point(0, 102);
            this.gridControlPayments.MainView = this.gridViewPaymentTypes;
            this.gridControlPayments.MenuManager = this.ribbonControl;
            this.gridControlPayments.Name = "gridControlPayments";
            this.gridControlPayments.Size = new System.Drawing.Size(1120, 238);
            this.gridControlPayments.TabIndex = 3;
            this.gridControlPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPaymentTypes});
            // 
            // gridViewPaymentTypes
            // 
            this.gridViewPaymentTypes.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewPaymentTypes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewPaymentTypes.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewPaymentTypes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewPaymentTypes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewPaymentTypes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewPaymentTypes.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPaymentTypes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPaymentTypes.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewPaymentTypes.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewPaymentTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colPaymentTypeName,
            this.colPaymentTypee,
            this.colDescription});
            this.gridViewPaymentTypes.GridControl = this.gridControlPayments;
            this.gridViewPaymentTypes.Name = "gridViewPaymentTypes";
            this.gridViewPaymentTypes.OptionsMenu.EnableColumnMenu = false;
            this.gridViewPaymentTypes.OptionsMenu.EnableFooterMenu = false;
            this.gridViewPaymentTypes.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPaymentTypes.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewPaymentTypes.OptionsPrint.AutoWidth = false;
            this.gridViewPaymentTypes.OptionsPrint.PrintFooter = false;
            this.gridViewPaymentTypes.OptionsPrint.PrintGroupFooter = false;
            this.gridViewPaymentTypes.OptionsView.ColumnAutoWidth = false;
            this.gridViewPaymentTypes.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewPaymentTypes.OptionsView.RowAutoHeight = true;
            this.gridViewPaymentTypes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPaymentTypes.OptionsView.ShowGroupPanel = false;
            this.gridViewPaymentTypes.OptionsView.ShowViewCaption = true;
            this.gridViewPaymentTypes.StatusBarDescription = null;
            this.gridViewPaymentTypes.StatusBarShortcut = null;
            this.gridViewPaymentTypes.StatusBarShortcutDescription = null;
            this.gridViewPaymentTypes.DoubleClick += new System.EventHandler(this.gridViewPaymentTypes_DoubleClick);
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
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.Caption = "Payment Type Name";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.OptionsColumn.AllowEdit = false;
            this.colPaymentTypeName.StatusBarDescription = null;
            this.colPaymentTypeName.StatusBarShortcut = null;
            this.colPaymentTypeName.StatusBarShortcutDescription = null;
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 1;
            this.colPaymentTypeName.Width = 200;
            // 
            // colPaymentTypee
            // 
            this.colPaymentTypee.Caption = "Payment Type";
            this.colPaymentTypee.FieldName = "PaymentTypee";
            this.colPaymentTypee.Name = "colPaymentTypee";
            this.colPaymentTypee.OptionsColumn.AllowEdit = false;
            this.colPaymentTypee.StatusBarDescription = null;
            this.colPaymentTypee.StatusBarShortcut = null;
            this.colPaymentTypee.StatusBarShortcutDescription = null;
            this.colPaymentTypee.Visible = true;
            this.colPaymentTypee.VisibleIndex = 2;
            this.colPaymentTypee.Width = 200;
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
            // PaymentTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlPayments);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "PaymentTypeListForm";
            this.Text = "Payment Type List";
            this.Load += new System.EventHandler(this.PaymentTypeListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlPayments, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlPayments;
        private UserControls.Grids.MyGridView gridViewPaymentTypes;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colPaymentTypeName;
        private UserControls.Grids.MyGridColumn colPaymentTypee;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}