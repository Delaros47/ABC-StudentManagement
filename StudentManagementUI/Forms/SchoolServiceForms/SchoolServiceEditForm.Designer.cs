namespace StudentManagementUI.Forms.SchoolServiceForms
{
    partial class SchoolServiceEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition9 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition11 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition12 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new StudentManagementUI.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtPrivateCode = new StudentManagementUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSchoolService = new StudentManagementUI.UserControls.Controls.MyTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPrice = new StudentManagementUI.UserControls.Controls.MyCalcEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtDescription = new StudentManagementUI.UserControls.Controls.MyMemoEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tglState = new StudentManagementUI.UserControls.Controls.MyToggleSwitch();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(390, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.tglState);
            this.myDataLayoutControl1.Controls.Add(this.txtDescription);
            this.myDataLayoutControl1.Controls.Add(this.txtPrice);
            this.myDataLayoutControl1.Controls.Add(this.txtSchoolService);
            this.myDataLayoutControl1.Controls.Add(this.txtPrivateCode);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(390, 266);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition7.Width = 230D;
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition8.Width = 100D;
            columnDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition9.Width = 110D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition7,
            columnDefinition8,
            columnDefinition9});
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition10.Height = 24D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition11.Height = 24D;
            rowDefinition11.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition12.Height = 100D;
            rowDefinition12.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition9,
            rowDefinition10,
            rowDefinition11,
            rowDefinition12});
            this.Root.Size = new System.Drawing.Size(390, 266);
            this.Root.TextVisible = false;
            // 
            // txtPrivateCode
            // 
            this.txtPrivateCode.EnterMoveNextControl = true;
            this.txtPrivateCode.Location = new System.Drawing.Point(115, 12);
            this.txtPrivateCode.MenuManager = this.ribbonControl;
            this.txtPrivateCode.Name = "txtPrivateCode";
            this.txtPrivateCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtPrivateCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrivateCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrivateCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrivateCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPrivateCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPrivateCode.Properties.MaxLength = 30;
            this.txtPrivateCode.Size = new System.Drawing.Size(123, 20);
            this.txtPrivateCode.StatusBarDescription = "Enter the Private Code";
            this.txtPrivateCode.StyleController = this.myDataLayoutControl1;
            this.txtPrivateCode.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtPrivateCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem1.Text = "Private Code";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem1.TextToControlDistance = 10;
            // 
            // txtSchoolService
            // 
            this.txtSchoolService.EnterMoveNextControl = true;
            this.txtSchoolService.Location = new System.Drawing.Point(115, 36);
            this.txtSchoolService.MenuManager = this.ribbonControl;
            this.txtSchoolService.Name = "txtSchoolService";
            this.txtSchoolService.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSchoolService.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSchoolService.Properties.MaxLength = 50;
            this.txtSchoolService.Size = new System.Drawing.Size(263, 20);
            this.txtSchoolService.StatusBarDescription = "Enter School Service name.";
            this.txtSchoolService.StyleController = this.myDataLayoutControl1;
            this.txtSchoolService.TabIndex = 0;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtSchoolService;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem2.Text = "School Service ";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.EnterMoveNextControl = true;
            this.txtPrice.Location = new System.Drawing.Point(115, 60);
            this.txtPrice.MenuManager = this.ribbonControl;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrice.Properties.MaskSettings.Set("mask", "n2");
            this.txtPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPrice.StatusBarDescription = "Enter the Price";
            this.txtPrice.StatusBarShortcut = "F4 :";
            this.txtPrice.StatusBarShortcutDescription = "Calculator";
            this.txtPrice.StyleController = this.myDataLayoutControl1;
            this.txtPrice.TabIndex = 1;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtPrice;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem3.Text = "Price";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(115, 84);
            this.txtDescription.MenuManager = this.ribbonControl;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Properties.MaxLength = 500;
            this.txtDescription.Size = new System.Drawing.Size(263, 170);
            this.txtDescription.StatusBarDescription = "Enter the description.";
            this.txtDescription.StyleController = this.myDataLayoutControl1;
            this.txtDescription.TabIndex = 2;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtDescription;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(370, 174);
            this.layoutControlItem4.Text = "Description";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // tglState
            // 
            this.tglState.EnterMoveNextControl = true;
            this.tglState.Location = new System.Drawing.Point(272, 12);
            this.tglState.MenuManager = this.ribbonControl;
            this.tglState.Name = "tglState";
            this.tglState.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglState.Properties.Appearance.Options.UseForeColor = true;
            this.tglState.Properties.AutoHeight = false;
            this.tglState.Properties.AutoWidth = true;
            this.tglState.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglState.Properties.OffText = "Passive";
            this.tglState.Properties.OnText = "Active";
            this.tglState.Size = new System.Drawing.Size(109, 20);
            this.tglState.StatusBarDescription = "Choose the state of the form.";
            this.tglState.StyleController = this.myDataLayoutControl1;
            this.tglState.TabIndex = 3;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.tglState;
            this.layoutControlItem5.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(110, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // SchoolServiceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 399);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "SchoolServiceEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Service Edit";
            this.Load += new System.EventHandler(this.SchoolServiceEditForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private UserControls.Controls.MyToggleSwitch tglState;
        private UserControls.Controls.MyMemoEdit txtDescription;
        private UserControls.Controls.MyCalcEdit txtPrice;
        private UserControls.Controls.MyTextEdit txtSchoolService;
        private UserControls.Controls.MyPrivateCodeTextEdit txtPrivateCode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}