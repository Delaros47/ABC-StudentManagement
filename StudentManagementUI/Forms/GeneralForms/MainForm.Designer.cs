namespace StudentManagementUI.Forms.GeneralForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSchools = new DevExpress.XtraBars.BarButtonItem();
            this.btnCities = new DevExpress.XtraBars.BarButtonItem();
            this.btnFamilyInformation = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelReason = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageStudent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnForeignLanguages = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnSchools,
            this.btnCities,
            this.btnFamilyInformation,
            this.btnCancelReason,
            this.btnForeignLanguages});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageStudent});
            this.ribbonControl.Size = new System.Drawing.Size(1162, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // btnSchools
            // 
            this.btnSchools.Caption = "Schools";
            this.btnSchools.Id = 1;
            this.btnSchools.Name = "btnSchools";
            // 
            // btnCities
            // 
            this.btnCities.Caption = "Cities";
            this.btnCities.Id = 2;
            this.btnCities.Name = "btnCities";
            // 
            // btnFamilyInformation
            // 
            this.btnFamilyInformation.Caption = "Family Information";
            this.btnFamilyInformation.Id = 3;
            this.btnFamilyInformation.Name = "btnFamilyInformation";
            // 
            // btnCancelReason
            // 
            this.btnCancelReason.Caption = "Cancel Reason";
            this.btnCancelReason.Id = 4;
            this.btnCancelReason.Name = "btnCancelReason";
            // 
            // ribbonPageStudent
            // 
            this.ribbonPageStudent.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPageStudent.Name = "ribbonPageStudent";
            this.ribbonPageStudent.Text = "Student";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSchools);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnFamilyInformation);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCities);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCancelReason);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnForeignLanguages);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 504);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1162, 31);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // btnForeignLanguages
            // 
            this.btnForeignLanguages.Caption = "Foreign Languages";
            this.btnForeignLanguages.Id = 5;
            this.btnForeignLanguages.Name = "btnForeignLanguages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 535);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Student Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSchools;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnCities;
        private DevExpress.XtraBars.BarButtonItem btnFamilyInformation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnCancelReason;
        private DevExpress.XtraBars.BarButtonItem btnForeignLanguages;
    }
}