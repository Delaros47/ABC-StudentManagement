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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSchools = new DevExpress.XtraBars.BarButtonItem();
            this.btnCities = new DevExpress.XtraBars.BarButtonItem();
            this.btnFamilyInformations = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelReasons = new DevExpress.XtraBars.BarButtonItem();
            this.btnForeignLanguages = new DevExpress.XtraBars.BarButtonItem();
            this.btnIncentives = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuotas = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuidanceCounselors = new DevExpress.XtraBars.BarButtonItem();
            this.btnClassGroups = new DevExpress.XtraBars.BarButtonItem();
            this.btnOccupations = new DevExpress.XtraBars.BarButtonItem();
            this.btnFamilyIntimacies = new DevExpress.XtraBars.BarButtonItem();
            this.btnWorkplace = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuties = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiscountType = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocuments = new DevExpress.XtraBars.BarButtonItem();
            this.btnPromotions = new DevExpress.XtraBars.BarButtonItem();
            this.btnSchoolServices = new DevExpress.XtraBars.BarButtonItem();
            this.btnClasses = new DevExpress.XtraBars.BarButtonItem();
            this.btnServiceTypes = new DevExpress.XtraBars.BarButtonItem();
            this.btnServices = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashes = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanks = new DevExpress.XtraBars.BarButtonItem();
            this.btnLawyers = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaymentTypes = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageStudent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStudent = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupClass = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupGeneral = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageParent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupParent = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageService = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupService = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDiscount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageFinance = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupFinance = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnContacts = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnFamilyInformations,
            this.btnCancelReasons,
            this.btnForeignLanguages,
            this.btnIncentives,
            this.btnQuotas,
            this.btnGuidanceCounselors,
            this.btnClassGroups,
            this.btnOccupations,
            this.btnFamilyIntimacies,
            this.btnWorkplace,
            this.btnDuties,
            this.btnDiscountType,
            this.btnDocuments,
            this.btnPromotions,
            this.btnSchoolServices,
            this.btnClasses,
            this.btnServiceTypes,
            this.btnServices,
            this.btnCashes,
            this.btnBanks,
            this.btnLawyers,
            this.btnCustomers,
            this.btnPaymentTypes,
            this.btnBankAccounts,
            this.btnContacts});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 28;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageStudent,
            this.ribbonPageParent,
            this.ribbonPageService,
            this.ribbonPageFinance});
            this.ribbonControl.Size = new System.Drawing.Size(1162, 146);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // btnSchools
            // 
            this.btnSchools.Caption = "Schools";
            this.btnSchools.Id = 1;
            this.btnSchools.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSchools.ImageOptions.LargeImage")));
            this.btnSchools.Name = "btnSchools";
            // 
            // btnCities
            // 
            this.btnCities.Caption = "Cities";
            this.btnCities.Id = 2;
            this.btnCities.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCities.ImageOptions.LargeImage")));
            this.btnCities.Name = "btnCities";
            // 
            // btnFamilyInformations
            // 
            this.btnFamilyInformations.Caption = "Family Informations";
            this.btnFamilyInformations.Id = 3;
            this.btnFamilyInformations.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFamilyInformations.ImageOptions.LargeImage")));
            this.btnFamilyInformations.Name = "btnFamilyInformations";
            // 
            // btnCancelReasons
            // 
            this.btnCancelReasons.Caption = "Cancel Reasons";
            this.btnCancelReasons.Id = 4;
            this.btnCancelReasons.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelReasons.ImageOptions.LargeImage")));
            this.btnCancelReasons.Name = "btnCancelReasons";
            // 
            // btnForeignLanguages
            // 
            this.btnForeignLanguages.Caption = "Foreign Languages";
            this.btnForeignLanguages.Id = 5;
            this.btnForeignLanguages.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnForeignLanguages.ImageOptions.LargeImage")));
            this.btnForeignLanguages.Name = "btnForeignLanguages";
            // 
            // btnIncentives
            // 
            this.btnIncentives.Caption = "Incentives";
            this.btnIncentives.Id = 6;
            this.btnIncentives.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIncentives.ImageOptions.LargeImage")));
            this.btnIncentives.Name = "btnIncentives";
            // 
            // btnQuotas
            // 
            this.btnQuotas.Caption = "Quotas";
            this.btnQuotas.Id = 7;
            this.btnQuotas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuotas.ImageOptions.LargeImage")));
            this.btnQuotas.Name = "btnQuotas";
            // 
            // btnGuidanceCounselors
            // 
            this.btnGuidanceCounselors.Caption = "Guidance Counselors";
            this.btnGuidanceCounselors.Id = 8;
            this.btnGuidanceCounselors.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuidanceCounselors.ImageOptions.LargeImage")));
            this.btnGuidanceCounselors.Name = "btnGuidanceCounselors";
            // 
            // btnClassGroups
            // 
            this.btnClassGroups.Caption = "Class Groups";
            this.btnClassGroups.Id = 9;
            this.btnClassGroups.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClassGroups.ImageOptions.SvgImage")));
            this.btnClassGroups.Name = "btnClassGroups";
            // 
            // btnOccupations
            // 
            this.btnOccupations.Caption = "Occupations";
            this.btnOccupations.Id = 10;
            this.btnOccupations.Name = "btnOccupations";
            // 
            // btnFamilyIntimacies
            // 
            this.btnFamilyIntimacies.Caption = "Family Intimacies";
            this.btnFamilyIntimacies.Id = 11;
            this.btnFamilyIntimacies.Name = "btnFamilyIntimacies";
            // 
            // btnWorkplace
            // 
            this.btnWorkplace.Caption = "Workplace";
            this.btnWorkplace.Id = 12;
            this.btnWorkplace.Name = "btnWorkplace";
            // 
            // btnDuties
            // 
            this.btnDuties.Caption = "Duties";
            this.btnDuties.Id = 13;
            this.btnDuties.Name = "btnDuties";
            // 
            // btnDiscountType
            // 
            this.btnDiscountType.Caption = "Discount Type";
            this.btnDiscountType.Id = 14;
            this.btnDiscountType.Name = "btnDiscountType";
            // 
            // btnDocuments
            // 
            this.btnDocuments.Caption = "Documents";
            this.btnDocuments.Id = 15;
            this.btnDocuments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDocuments.ImageOptions.LargeImage")));
            this.btnDocuments.Name = "btnDocuments";
            // 
            // btnPromotions
            // 
            this.btnPromotions.Caption = "Promotions";
            this.btnPromotions.Id = 16;
            this.btnPromotions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPromotions.ImageOptions.LargeImage")));
            this.btnPromotions.Name = "btnPromotions";
            // 
            // btnSchoolServices
            // 
            this.btnSchoolServices.Caption = "School Services";
            this.btnSchoolServices.Id = 17;
            this.btnSchoolServices.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSchoolServices.ImageOptions.LargeImage")));
            this.btnSchoolServices.Name = "btnSchoolServices";
            // 
            // btnClasses
            // 
            this.btnClasses.Caption = "Classes";
            this.btnClasses.Id = 18;
            this.btnClasses.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClasses.ImageOptions.LargeImage")));
            this.btnClasses.Name = "btnClasses";
            // 
            // btnServiceTypes
            // 
            this.btnServiceTypes.Caption = "Service Types";
            this.btnServiceTypes.Id = 19;
            this.btnServiceTypes.Name = "btnServiceTypes";
            // 
            // btnServices
            // 
            this.btnServices.Caption = "Services";
            this.btnServices.Id = 20;
            this.btnServices.Name = "btnServices";
            // 
            // btnCashes
            // 
            this.btnCashes.Caption = "Cashes";
            this.btnCashes.Id = 21;
            this.btnCashes.Name = "btnCashes";
            // 
            // btnBanks
            // 
            this.btnBanks.Caption = "Banks";
            this.btnBanks.Id = 22;
            this.btnBanks.Name = "btnBanks";
            // 
            // btnLawyers
            // 
            this.btnLawyers.Caption = "Lawyers";
            this.btnLawyers.Id = 23;
            this.btnLawyers.Name = "btnLawyers";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Caption = "Customers";
            this.btnCustomers.Id = 24;
            this.btnCustomers.Name = "btnCustomers";
            // 
            // btnPaymentTypes
            // 
            this.btnPaymentTypes.Caption = "Payment Types";
            this.btnPaymentTypes.Id = 25;
            this.btnPaymentTypes.Name = "btnPaymentTypes";
            // 
            // btnBankAccounts
            // 
            this.btnBankAccounts.Caption = "Bank Accounts";
            this.btnBankAccounts.Id = 26;
            this.btnBankAccounts.Name = "btnBankAccounts";
            // 
            // ribbonPageStudent
            // 
            this.ribbonPageStudent.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStudent,
            this.ribbonPageGroupClass,
            this.ribbonPageGroupGeneral});
            this.ribbonPageStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageStudent.ImageOptions.Image")));
            this.ribbonPageStudent.Name = "ribbonPageStudent";
            this.ribbonPageStudent.Text = "Student";
            // 
            // ribbonPageGroupStudent
            // 
            this.ribbonPageGroupStudent.Name = "ribbonPageGroupStudent";
            this.ribbonPageGroupStudent.Text = "Student";
            // 
            // ribbonPageGroupClass
            // 
            this.ribbonPageGroupClass.ItemLinks.Add(this.btnClasses);
            this.ribbonPageGroupClass.ItemLinks.Add(this.btnClassGroups);
            this.ribbonPageGroupClass.Name = "ribbonPageGroupClass";
            this.ribbonPageGroupClass.Text = "Class";
            // 
            // ribbonPageGroupGeneral
            // 
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnFamilyInformations);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnCities);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnIncentives);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnQuotas);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnGuidanceCounselors);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnSchools);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnDocuments);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnPromotions);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnSchoolServices);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnCancelReasons);
            this.ribbonPageGroupGeneral.ItemLinks.Add(this.btnForeignLanguages);
            this.ribbonPageGroupGeneral.Name = "ribbonPageGroupGeneral";
            this.ribbonPageGroupGeneral.Text = "General";
            // 
            // ribbonPageParent
            // 
            this.ribbonPageParent.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupParent});
            this.ribbonPageParent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageParent.ImageOptions.Image")));
            this.ribbonPageParent.Name = "ribbonPageParent";
            this.ribbonPageParent.Text = "Parent";
            // 
            // ribbonPageGroupParent
            // 
            this.ribbonPageGroupParent.ItemLinks.Add(this.btnOccupations);
            this.ribbonPageGroupParent.ItemLinks.Add(this.btnFamilyIntimacies);
            this.ribbonPageGroupParent.ItemLinks.Add(this.btnWorkplace);
            this.ribbonPageGroupParent.ItemLinks.Add(this.btnDuties);
            this.ribbonPageGroupParent.ItemLinks.Add(this.btnContacts);
            this.ribbonPageGroupParent.Name = "ribbonPageGroupParent";
            this.ribbonPageGroupParent.Text = "Parent";
            // 
            // ribbonPageService
            // 
            this.ribbonPageService.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupService,
            this.ribbonPageGroupDiscount});
            this.ribbonPageService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageService.ImageOptions.Image")));
            this.ribbonPageService.Name = "ribbonPageService";
            this.ribbonPageService.Text = "Service";
            // 
            // ribbonPageGroupService
            // 
            this.ribbonPageGroupService.ItemLinks.Add(this.btnServices);
            this.ribbonPageGroupService.ItemLinks.Add(this.btnServiceTypes);
            this.ribbonPageGroupService.Name = "ribbonPageGroupService";
            this.ribbonPageGroupService.Text = "Service";
            // 
            // ribbonPageGroupDiscount
            // 
            this.ribbonPageGroupDiscount.ItemLinks.Add(this.btnDiscountType);
            this.ribbonPageGroupDiscount.Name = "ribbonPageGroupDiscount";
            this.ribbonPageGroupDiscount.Text = "Discount";
            // 
            // ribbonPageFinance
            // 
            this.ribbonPageFinance.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupFinance});
            this.ribbonPageFinance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageFinance.ImageOptions.Image")));
            this.ribbonPageFinance.Name = "ribbonPageFinance";
            this.ribbonPageFinance.Text = "Finance";
            // 
            // ribbonPageGroupFinance
            // 
            this.ribbonPageGroupFinance.ItemLinks.Add(this.btnCashes);
            this.ribbonPageGroupFinance.ItemLinks.Add(this.btnBanks);
            this.ribbonPageGroupFinance.ItemLinks.Add(this.btnLawyers);
            this.ribbonPageGroupFinance.ItemLinks.Add(this.btnCustomers);
            this.ribbonPageGroupFinance.ItemLinks.Add(this.btnPaymentTypes);
            this.ribbonPageGroupFinance.ItemLinks.Add(this.btnBankAccounts);
            this.ribbonPageGroupFinance.Name = "ribbonPageGroupFinance";
            this.ribbonPageGroupFinance.Text = "Finance";
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
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "ribbonPage6";
            // 
            // btnContacts
            // 
            this.btnContacts.Caption = "Contacts";
            this.btnContacts.Id = 27;
            this.btnContacts.Name = "btnContacts";
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupClass;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSchools;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnCities;
        private DevExpress.XtraBars.BarButtonItem btnFamilyInformations;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnCancelReasons;
        private DevExpress.XtraBars.BarButtonItem btnForeignLanguages;
        private DevExpress.XtraBars.BarButtonItem btnIncentives;
        private DevExpress.XtraBars.BarButtonItem btnQuotas;
        private DevExpress.XtraBars.BarButtonItem btnGuidanceCounselors;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStudent;
        private DevExpress.XtraBars.BarButtonItem btnClassGroups;
        private DevExpress.XtraBars.BarButtonItem btnOccupations;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageParent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupParent;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnFamilyIntimacies;
        private DevExpress.XtraBars.BarButtonItem btnWorkplace;
        private DevExpress.XtraBars.BarButtonItem btnDuties;
        private DevExpress.XtraBars.BarButtonItem btnDiscountType;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDiscount;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnDocuments;
        private DevExpress.XtraBars.BarButtonItem btnPromotions;
        private DevExpress.XtraBars.BarButtonItem btnSchoolServices;
        private DevExpress.XtraBars.BarButtonItem btnClasses;
        private DevExpress.XtraBars.BarButtonItem btnServiceTypes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupService;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnServices;
        private DevExpress.XtraBars.BarButtonItem btnCashes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageFinance;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFinance;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.BarButtonItem btnBanks;
        private DevExpress.XtraBars.BarButtonItem btnLawyers;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
        private DevExpress.XtraBars.BarButtonItem btnPaymentTypes;
        private DevExpress.XtraBars.BarButtonItem btnBankAccounts;
        private DevExpress.XtraBars.BarButtonItem btnContacts;
    }
}