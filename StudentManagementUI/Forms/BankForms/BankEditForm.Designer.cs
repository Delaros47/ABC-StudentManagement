namespace StudentManagementUI.Forms.BankForms
{
    partial class BankEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new StudentManagementUI.UserControls.Controls.MyDataLayoutControl();
            this.tglState = new StudentManagementUI.UserControls.Controls.MyToggleSwitch();
            this.txtDescription = new StudentManagementUI.UserControls.Controls.MyMemoEdit();
            this.btnSpecialCode2 = new StudentManagementUI.UserControls.Controls.MyButtonEdit();
            this.btnSpecialCode1 = new StudentManagementUI.UserControls.Controls.MyButtonEdit();
            this.txtBankName = new StudentManagementUI.UserControls.Controls.MyTextEdit();
            this.txtPrivateCode = new StudentManagementUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpecialCode2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpecialCode1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
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
            this.myDataLayoutControl1.Controls.Add(this.btnSpecialCode2);
            this.myDataLayoutControl1.Controls.Add(this.btnSpecialCode1);
            this.myDataLayoutControl1.Controls.Add(this.txtBankName);
            this.myDataLayoutControl1.Controls.Add(this.txtPrivateCode);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(390, 214);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
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
            this.tglState.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(115, 108);
            this.txtDescription.MenuManager = this.ribbonControl;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Properties.MaxLength = 500;
            this.txtDescription.Size = new System.Drawing.Size(263, 94);
            this.txtDescription.StatusBarDescription = "Enter the description.";
            this.txtDescription.StyleController = this.myDataLayoutControl1;
            this.txtDescription.TabIndex = 3;
            // 
            // btnSpecialCode2
            // 
            this.btnSpecialCode2.EnterMoveNextControl = true;
            this.btnSpecialCode2.Id = null;
            this.btnSpecialCode2.Location = new System.Drawing.Point(115, 84);
            this.btnSpecialCode2.MenuManager = this.ribbonControl;
            this.btnSpecialCode2.Name = "btnSpecialCode2";
            this.btnSpecialCode2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnSpecialCode2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnSpecialCode2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSpecialCode2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnSpecialCode2.Size = new System.Drawing.Size(123, 20);
            this.btnSpecialCode2.StatusBarDescription = null;
            this.btnSpecialCode2.StatusBarShortcut = "F4 :";
            this.btnSpecialCode2.StatusBarShortcutDescription = null;
            this.btnSpecialCode2.StyleController = this.myDataLayoutControl1;
            this.btnSpecialCode2.TabIndex = 2;
            this.btnSpecialCode2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSpecialCode2_ButtonClick);
            // 
            // btnSpecialCode1
            // 
            this.btnSpecialCode1.EnterMoveNextControl = true;
            this.btnSpecialCode1.Id = null;
            this.btnSpecialCode1.Location = new System.Drawing.Point(115, 60);
            this.btnSpecialCode1.MenuManager = this.ribbonControl;
            this.btnSpecialCode1.Name = "btnSpecialCode1";
            this.btnSpecialCode1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnSpecialCode1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnSpecialCode1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSpecialCode1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnSpecialCode1.Size = new System.Drawing.Size(123, 20);
            this.btnSpecialCode1.StatusBarDescription = null;
            this.btnSpecialCode1.StatusBarShortcut = "F4 :";
            this.btnSpecialCode1.StatusBarShortcutDescription = null;
            this.btnSpecialCode1.StyleController = this.myDataLayoutControl1;
            this.btnSpecialCode1.TabIndex = 1;
            this.btnSpecialCode1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSpecialCode1_ButtonClick);
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(115, 36);
            this.txtBankName.MenuManager = this.ribbonControl;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankName.Properties.MaxLength = 50;
            this.txtBankName.Size = new System.Drawing.Size(263, 20);
            this.txtBankName.StatusBarDescription = null;
            this.txtBankName.StyleController = this.myDataLayoutControl1;
            this.txtBankName.TabIndex = 0;
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
            this.txtPrivateCode.TabIndex = 5;
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
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 230D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 110D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(390, 214);
            this.Root.TextVisible = false;
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
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtBankName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem2.Text = "Bank Name";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.btnSpecialCode1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem3.Text = "Special Code-1";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.btnSpecialCode2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem4.Text = "Special Code-2";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtDescription;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(370, 98);
            this.layoutControlItem5.Text = "Description";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem5.TextToControlDistance = 10;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.tglState;
            this.layoutControlItem6.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem6.Size = new System.Drawing.Size(110, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // BankEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 349);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "BankEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Edit";
            this.Load += new System.EventHandler(this.BankEditForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpecialCode2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpecialCode1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyToggleSwitch tglState;
        private UserControls.Controls.MyMemoEdit txtDescription;
        private UserControls.Controls.MyButtonEdit btnSpecialCode2;
        private UserControls.Controls.MyButtonEdit btnSpecialCode1;
        private UserControls.Controls.MyTextEdit txtBankName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtPrivateCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}