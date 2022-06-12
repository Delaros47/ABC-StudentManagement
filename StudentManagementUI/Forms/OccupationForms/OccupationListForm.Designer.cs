namespace StudentManagementUI.Forms.OccupationForms
{
    partial class OccupationListForm
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
            this.gridControlOccupations = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewOccupations = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colOccupation = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOccupations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOccupations)).BeginInit();
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
            // gridControlOccupations
            // 
            this.gridControlOccupations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOccupations.Location = new System.Drawing.Point(0, 102);
            this.gridControlOccupations.MainView = this.gridViewOccupations;
            this.gridControlOccupations.MenuManager = this.ribbonControl;
            this.gridControlOccupations.Name = "gridControlOccupations";
            this.gridControlOccupations.Size = new System.Drawing.Size(1120, 238);
            this.gridControlOccupations.TabIndex = 3;
            this.gridControlOccupations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOccupations});
            this.gridControlOccupations.DoubleClick += new System.EventHandler(this.gridControlOccupations_DoubleClick);
            // 
            // gridViewOccupations
            // 
            this.gridViewOccupations.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewOccupations.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewOccupations.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewOccupations.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewOccupations.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewOccupations.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewOccupations.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewOccupations.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewOccupations.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewOccupations.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewOccupations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colOccupation,
            this.colDescription});
            this.gridViewOccupations.GridControl = this.gridControlOccupations;
            this.gridViewOccupations.Name = "gridViewOccupations";
            this.gridViewOccupations.OptionsMenu.EnableColumnMenu = false;
            this.gridViewOccupations.OptionsMenu.EnableFooterMenu = false;
            this.gridViewOccupations.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewOccupations.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewOccupations.OptionsPrint.AutoWidth = false;
            this.gridViewOccupations.OptionsPrint.PrintFooter = false;
            this.gridViewOccupations.OptionsPrint.PrintGroupFooter = false;
            this.gridViewOccupations.OptionsView.ColumnAutoWidth = false;
            this.gridViewOccupations.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewOccupations.OptionsView.RowAutoHeight = true;
            this.gridViewOccupations.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOccupations.OptionsView.ShowGroupPanel = false;
            this.gridViewOccupations.OptionsView.ShowViewCaption = true;
            this.gridViewOccupations.StatusBarDescription = null;
            this.gridViewOccupations.StatusBarShortcut = null;
            this.gridViewOccupations.StatusBarShortcutDescription = null;
            this.gridViewOccupations.ViewCaption = "Occupations";
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
            // colOccupation
            // 
            this.colOccupation.Caption = "Occupation";
            this.colOccupation.FieldName = "OccupationName";
            this.colOccupation.Name = "colOccupation";
            this.colOccupation.OptionsColumn.AllowEdit = false;
            this.colOccupation.StatusBarDescription = null;
            this.colOccupation.StatusBarShortcut = null;
            this.colOccupation.StatusBarShortcutDescription = null;
            this.colOccupation.Visible = true;
            this.colOccupation.VisibleIndex = 1;
            this.colOccupation.Width = 250;
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
            // OccupationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.gridControlOccupations);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "OccupationListForm";
            this.Text = "Occupation List";
            this.Load += new System.EventHandler(this.OccupationListForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.gridControlOccupations, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOccupations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOccupations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridControl gridControlOccupations;
        private UserControls.Grids.MyGridView gridViewOccupations;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colOccupation;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}