namespace StudentManagementUI.Forms.StudentForms
{
    partial class StudentListForm
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
            this.bandedGridControlStudents = new StudentManagementUI.UserControls.Grids.MyBandedGridControl();
            this.bandedGridViewStudents = new StudentManagementUI.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPrivateCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewStudents)).BeginInit();
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
            // bandedGridControlStudents
            // 
            this.bandedGridControlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandedGridControlStudents.Location = new System.Drawing.Point(0, 102);
            this.bandedGridControlStudents.MainView = this.bandedGridViewStudents;
            this.bandedGridControlStudents.MenuManager = this.ribbonControl;
            this.bandedGridControlStudents.Name = "bandedGridControlStudents";
            this.bandedGridControlStudents.Size = new System.Drawing.Size(1120, 238);
            this.bandedGridControlStudents.TabIndex = 3;
            this.bandedGridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridViewStudents});
            // 
            // bandedGridViewStudents
            // 
            this.bandedGridViewStudents.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewStudents.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bandedGridViewStudents.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridViewStudents.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridViewStudents.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridViewStudents.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewStudents.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bandedGridViewStudents.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewStudents.Appearance.FooterPanel.Options.UseFont = true;
            this.bandedGridViewStudents.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridViewStudents.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewStudents.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridViewStudents.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridViewStudents.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridViewStudents.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.bandedGridViewStudents.Appearance.ViewCaption.Options.UseForeColor = true;
            this.bandedGridViewStudents.BandPanelRowHeight = 40;
            this.bandedGridViewStudents.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridViewStudents.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colPrivateCode});
            this.bandedGridViewStudents.GridControl = this.bandedGridControlStudents;
            this.bandedGridViewStudents.Name = "bandedGridViewStudents";
            this.bandedGridViewStudents.OptionsMenu.EnableColumnMenu = false;
            this.bandedGridViewStudents.OptionsMenu.EnableFooterMenu = false;
            this.bandedGridViewStudents.OptionsMenu.EnableGroupPanelMenu = false;
            this.bandedGridViewStudents.OptionsNavigation.EnterMoveNextColumn = true;
            this.bandedGridViewStudents.OptionsPrint.AutoWidth = false;
            this.bandedGridViewStudents.OptionsPrint.PrintFooter = false;
            this.bandedGridViewStudents.OptionsPrint.PrintGroupFooter = false;
            this.bandedGridViewStudents.OptionsView.ColumnAutoWidth = false;
            this.bandedGridViewStudents.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.bandedGridViewStudents.OptionsView.RowAutoHeight = true;
            this.bandedGridViewStudents.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridViewStudents.OptionsView.ShowGroupPanel = false;
            this.bandedGridViewStudents.OptionsView.ShowViewCaption = true;
            this.bandedGridViewStudents.StatusBarDescription = null;
            this.bandedGridViewStudents.StatusBarShortcut = null;
            this.bandedGridViewStudents.StatusBarShortcutDescription = null;
            this.bandedGridViewStudents.ViewCaption = "Students";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPrivateCode
            // 
            this.colPrivateCode.AppearanceCell.Options.UseTextOptions = true;
            this.colPrivateCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrivateCode.Caption = "Private Code";
            this.colPrivateCode.FieldName = "PrivateCode";
            this.colPrivateCode.Name = "colPrivateCode";
            this.colPrivateCode.OptionsColumn.AllowEdit = false;
            this.colPrivateCode.Visible = true;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.bandedGridControlStudents);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "StudentListForm";
            this.Text = "Student List";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.bandedGridControlStudents, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridControlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyBandedGridControl bandedGridControlStudents;
        private UserControls.Grids.MyBandedGridView bandedGridViewStudents;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrivateCode;
    }
}