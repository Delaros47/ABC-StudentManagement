namespace StudentManagementUI.Forms.BaseForms
{
    partial class BaseListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseListForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnFilter = new DevExpress.XtraBars.BarButtonItem();
            this.btnColumns = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSend = new DevExpress.XtraBars.BarSubItem();
            this.btnExcelFiles = new DevExpress.XtraBars.BarSubItem();
            this.btnExcelFileStandard = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelFileFormatted = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelFileUnformatted = new DevExpress.XtraBars.BarButtonItem();
            this.btnWordFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnTxtFile = new DevExpress.XtraBars.BarButtonItem();
            this.barInsert = new DevExpress.XtraBars.BarStaticItem();
            this.barInsertDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barDelete = new DevExpress.XtraBars.BarStaticItem();
            this.barDeleteDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barEnter = new DevExpress.XtraBars.BarStaticItem();
            this.barEnterDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barEdit = new DevExpress.XtraBars.BarStaticItem();
            this.barEditDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barRefresh = new DevExpress.XtraBars.BarStaticItem();
            this.barRefreshDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barFilter = new DevExpress.XtraBars.BarStaticItem();
            this.barFilterDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barColumns = new DevExpress.XtraBars.BarStaticItem();
            this.barColumnsDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barPrint = new DevExpress.XtraBars.BarStaticItem();
            this.barPrintDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barSend = new DevExpress.XtraBars.BarStaticItem();
            this.barSendDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barExit = new DevExpress.XtraBars.BarStaticItem();
            this.barExitDescription = new DevExpress.XtraBars.BarStaticItem();
            this.btnActivePassiveList = new DevExpress.XtraBars.BarButtonItem();
            this.btnConnectedCards = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnNew,
            this.btnDelete,
            this.btnSelect,
            this.btnEdit,
            this.btnRefresh,
            this.btnFilter,
            this.btnColumns,
            this.btnPrint,
            this.btnExit,
            this.btnSend,
            this.barInsert,
            this.barInsertDescription,
            this.barDelete,
            this.barDeleteDescription,
            this.barEnter,
            this.barEnterDescription,
            this.barEdit,
            this.barEditDescription,
            this.barRefresh,
            this.barRefreshDescription,
            this.barFilter,
            this.barFilterDescription,
            this.barColumns,
            this.barColumnsDescription,
            this.barPrint,
            this.barPrintDescription,
            this.barSend,
            this.barSendDescription,
            this.barExit,
            this.barExitDescription,
            this.btnActivePassiveList,
            this.btnExcelFiles,
            this.btnExcelFileStandard,
            this.btnExcelFileFormatted,
            this.btnExcelFileUnformatted,
            this.btnWordFile,
            this.btnPdfFile,
            this.btnTxtFile,
            this.btnConnectedCards});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 42;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(1120, 102);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.LargeImage")));
            this.btnNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Caption = "Select";
            this.btnSelect.Id = 3;
            this.btnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.Image")));
            this.btnSelect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.LargeImage")));
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShortcutKeyDisplayString = "Enter";
            this.btnSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelect_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 4;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Caption = "Filter";
            this.btnFilter.Id = 6;
            this.btnFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.ImageOptions.Image")));
            this.btnFilter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.ImageOptions.LargeImage")));
            this.btnFilter.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFilter_ItemClick);
            // 
            // btnColumns
            // 
            this.btnColumns.Caption = "Columns";
            this.btnColumns.Id = 7;
            this.btnColumns.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.Image")));
            this.btnColumns.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.LargeImage")));
            this.btnColumns.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColumns_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Print";
            this.btnPrint.Id = 8;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 10;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeyDisplayString = "Esc";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnSend
            // 
            this.btnSend.Caption = "Send";
            this.btnSend.Id = 11;
            this.btnSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.Image")));
            this.btnSend.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.LargeImage")));
            this.btnSend.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.btnSend.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcelFiles, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTxtFile)});
            this.btnSend.Name = "btnSend";
            // 
            // btnExcelFiles
            // 
            this.btnExcelFiles.Caption = "Excel Files";
            this.btnExcelFiles.Id = 34;
            this.btnExcelFiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFiles.ImageOptions.Image")));
            this.btnExcelFiles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelFiles.ImageOptions.LargeImage")));
            this.btnExcelFiles.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFileStandard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFileFormatted),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFileUnformatted)});
            this.btnExcelFiles.Name = "btnExcelFiles";
            // 
            // btnExcelFileStandard
            // 
            this.btnExcelFileStandard.Caption = "Excel File (Standard)";
            this.btnExcelFileStandard.Id = 35;
            this.btnExcelFileStandard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFileStandard.ImageOptions.Image")));
            this.btnExcelFileStandard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelFileStandard.ImageOptions.LargeImage")));
            this.btnExcelFileStandard.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnExcelFileStandard.Name = "btnExcelFileStandard";
            this.btnExcelFileStandard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelFileStandard_ItemClick);
            // 
            // btnExcelFileFormatted
            // 
            this.btnExcelFileFormatted.Caption = "Excel File (Formatted)";
            this.btnExcelFileFormatted.Id = 36;
            this.btnExcelFileFormatted.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFileFormatted.ImageOptions.Image")));
            this.btnExcelFileFormatted.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelFileFormatted.ImageOptions.LargeImage")));
            this.btnExcelFileFormatted.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btnExcelFileFormatted.Name = "btnExcelFileFormatted";
            this.btnExcelFileFormatted.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelFileFormatted_ItemClick);
            // 
            // btnExcelFileUnformatted
            // 
            this.btnExcelFileUnformatted.Caption = "Excel File (UnFormatted)";
            this.btnExcelFileUnformatted.Id = 37;
            this.btnExcelFileUnformatted.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFileUnformatted.ImageOptions.Image")));
            this.btnExcelFileUnformatted.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelFileUnformatted.ImageOptions.LargeImage")));
            this.btnExcelFileUnformatted.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnExcelFileUnformatted.Name = "btnExcelFileUnformatted";
            this.btnExcelFileUnformatted.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelFileUnformatted_ItemClick);
            // 
            // btnWordFile
            // 
            this.btnWordFile.Caption = "Word File";
            this.btnWordFile.Id = 38;
            this.btnWordFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWordFile.ImageOptions.Image")));
            this.btnWordFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWordFile.ImageOptions.LargeImage")));
            this.btnWordFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.btnWordFile.Name = "btnWordFile";
            this.btnWordFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWordFile_ItemClick);
            // 
            // btnPdfFile
            // 
            this.btnPdfFile.Caption = "Pdf File";
            this.btnPdfFile.Id = 39;
            this.btnPdfFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfFile.ImageOptions.Image")));
            this.btnPdfFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdfFile.ImageOptions.LargeImage")));
            this.btnPdfFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPdfFile.Name = "btnPdfFile";
            this.btnPdfFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPdfFile_ItemClick);
            // 
            // btnTxtFile
            // 
            this.btnTxtFile.Caption = "Txt File";
            this.btnTxtFile.Id = 40;
            this.btnTxtFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTxtFile.ImageOptions.Image")));
            this.btnTxtFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTxtFile.ImageOptions.LargeImage")));
            this.btnTxtFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T));
            this.btnTxtFile.Name = "btnTxtFile";
            this.btnTxtFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTxtFile_ItemClick);
            // 
            // barInsert
            // 
            this.barInsert.Caption = "Insert :";
            this.barInsert.Id = 12;
            this.barInsert.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barInsert.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barInsert.ItemAppearance.Normal.Options.UseFont = true;
            this.barInsert.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barInsert.Name = "barInsert";
            // 
            // barInsertDescription
            // 
            this.barInsertDescription.Caption = "New";
            this.barInsertDescription.Id = 13;
            this.barInsertDescription.Name = "barInsertDescription";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Delete :";
            this.barDelete.Id = 14;
            this.barDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barDelete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.barDelete.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barDelete.Name = "barDelete";
            // 
            // barDeleteDescription
            // 
            this.barDeleteDescription.Caption = "Remove";
            this.barDeleteDescription.Id = 15;
            this.barDeleteDescription.Name = "barDeleteDescription";
            // 
            // barEnter
            // 
            this.barEnter.Caption = "Enter :";
            this.barEnter.Id = 16;
            this.barEnter.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barEnter.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barEnter.ItemAppearance.Normal.Options.UseFont = true;
            this.barEnter.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barEnter.Name = "barEnter";
            // 
            // barEnterDescription
            // 
            this.barEnterDescription.Caption = "Select";
            this.barEnterDescription.Id = 17;
            this.barEnterDescription.Name = "barEnterDescription";
            // 
            // barEdit
            // 
            this.barEdit.Caption = "F3 :";
            this.barEdit.Id = 18;
            this.barEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barEdit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.barEdit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barEdit.Name = "barEdit";
            // 
            // barEditDescription
            // 
            this.barEditDescription.Caption = "Edit";
            this.barEditDescription.Id = 19;
            this.barEditDescription.Name = "barEditDescription";
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "F5 :";
            this.barRefresh.Id = 20;
            this.barRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barRefresh.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.barRefresh.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barRefresh.Name = "barRefresh";
            // 
            // barRefreshDescription
            // 
            this.barRefreshDescription.Caption = "Refresh";
            this.barRefreshDescription.Id = 21;
            this.barRefreshDescription.Name = "barRefreshDescription";
            // 
            // barFilter
            // 
            this.barFilter.Caption = "F8 :";
            this.barFilter.Id = 22;
            this.barFilter.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barFilter.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barFilter.ItemAppearance.Normal.Options.UseFont = true;
            this.barFilter.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barFilter.Name = "barFilter";
            // 
            // barFilterDescription
            // 
            this.barFilterDescription.Caption = "Filter";
            this.barFilterDescription.Id = 23;
            this.barFilterDescription.Name = "barFilterDescription";
            // 
            // barColumns
            // 
            this.barColumns.Caption = "Ctrl+O :";
            this.barColumns.Id = 24;
            this.barColumns.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barColumns.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barColumns.ItemAppearance.Normal.Options.UseFont = true;
            this.barColumns.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barColumns.Name = "barColumns";
            // 
            // barColumnsDescription
            // 
            this.barColumnsDescription.Caption = "Columns";
            this.barColumnsDescription.Id = 25;
            this.barColumnsDescription.Name = "barColumnsDescription";
            // 
            // barPrint
            // 
            this.barPrint.Caption = "Ctrl+P :";
            this.barPrint.Id = 26;
            this.barPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barPrint.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.barPrint.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barPrint.Name = "barPrint";
            // 
            // barPrintDescription
            // 
            this.barPrintDescription.Caption = "Print";
            this.barPrintDescription.Id = 27;
            this.barPrintDescription.Name = "barPrintDescription";
            // 
            // barSend
            // 
            this.barSend.Caption = "F12 :";
            this.barSend.Id = 28;
            this.barSend.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barSend.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barSend.ItemAppearance.Normal.Options.UseFont = true;
            this.barSend.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barSend.Name = "barSend";
            // 
            // barSendDescription
            // 
            this.barSendDescription.Caption = "Send";
            this.barSendDescription.Id = 29;
            this.barSendDescription.Name = "barSendDescription";
            // 
            // barExit
            // 
            this.barExit.Caption = "Esc :";
            this.barExit.Id = 30;
            this.barExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barExit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barExit.ItemAppearance.Normal.Options.UseFont = true;
            this.barExit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barExit.Name = "barExit";
            // 
            // barExitDescription
            // 
            this.barExitDescription.Caption = "Exit";
            this.barExitDescription.Id = 32;
            this.barExitDescription.Name = "barExitDescription";
            // 
            // btnActivePassiveList
            // 
            this.btnActivePassiveList.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnActivePassiveList.Caption = "Passive List";
            this.btnActivePassiveList.Id = 33;
            this.btnActivePassiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActivePassiveList.ImageOptions.Image")));
            this.btnActivePassiveList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActivePassiveList.ImageOptions.LargeImage")));
            this.btnActivePassiveList.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActivePassiveList.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnActivePassiveList.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnActivePassiveList.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnActivePassiveList.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActivePassiveList.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.btnActivePassiveList.ItemAppearance.Normal.Options.UseFont = true;
            this.btnActivePassiveList.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnActivePassiveList.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActivePassiveList.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnActivePassiveList.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnActivePassiveList.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnActivePassiveList.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.btnActivePassiveList.Name = "btnActivePassiveList";
            this.btnActivePassiveList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActivePassiveList_ItemClick);
            // 
            // btnConnectedCards
            // 
            this.btnConnectedCards.Caption = "Connected Card";
            this.btnConnectedCards.Id = 41;
            this.btnConnectedCards.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnectedCards.ImageOptions.Image")));
            this.btnConnectedCards.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConnectedCards.ImageOptions.LargeImage")));
            this.btnConnectedCards.Name = "btnConnectedCards";
            this.btnConnectedCards.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnConnectedCards.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConnectedCards_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup.ItemLinks.Add(this.btnSelect);
            this.ribbonPageGroup.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup.ItemLinks.Add(this.btnFilter);
            this.ribbonPageGroup.ItemLinks.Add(this.btnConnectedCards);
            this.ribbonPageGroup.ItemLinks.Add(this.btnColumns);
            this.ribbonPageGroup.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup.ItemLinks.Add(this.btnSend);
            this.ribbonPageGroup.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barInsert);
            this.ribbonStatusBar.ItemLinks.Add(this.barInsertDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barDelete, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barDeleteDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barEnter, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barEnterDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barEdit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefresh, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefreshDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barFilter, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barFilterDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumns, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumnsDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barPrint, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barPrintDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barSend, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barSendDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barExit);
            this.ribbonStatusBar.ItemLinks.Add(this.barExitDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.btnActivePassiveList);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 364);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1120, 31);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // BaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 395);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "BaseListForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnFilter;
        private DevExpress.XtraBars.BarButtonItem btnColumns;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarSubItem btnSend;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarStaticItem barInsert;
        private DevExpress.XtraBars.BarStaticItem barInsertDescription;
        private DevExpress.XtraBars.BarStaticItem barDelete;
        private DevExpress.XtraBars.BarStaticItem barDeleteDescription;
        private DevExpress.XtraBars.BarStaticItem barEnter;
        private DevExpress.XtraBars.BarStaticItem barEnterDescription;
        private DevExpress.XtraBars.BarStaticItem barEdit;
        private DevExpress.XtraBars.BarStaticItem barEditDescription;
        private DevExpress.XtraBars.BarStaticItem barRefresh;
        private DevExpress.XtraBars.BarStaticItem barRefreshDescription;
        private DevExpress.XtraBars.BarStaticItem barFilter;
        private DevExpress.XtraBars.BarStaticItem barFilterDescription;
        private DevExpress.XtraBars.BarStaticItem barColumns;
        private DevExpress.XtraBars.BarStaticItem barColumnsDescription;
        private DevExpress.XtraBars.BarStaticItem barPrint;
        private DevExpress.XtraBars.BarStaticItem barPrintDescription;
        private DevExpress.XtraBars.BarStaticItem barSend;
        private DevExpress.XtraBars.BarStaticItem barSendDescription;
        private DevExpress.XtraBars.BarStaticItem barExit;
        private DevExpress.XtraBars.BarStaticItem barExitDescription;
        private DevExpress.XtraBars.BarButtonItem btnActivePassiveList;
        private DevExpress.XtraBars.BarSubItem btnExcelFiles;
        private DevExpress.XtraBars.BarButtonItem btnExcelFileStandard;
        private DevExpress.XtraBars.BarButtonItem btnExcelFileFormatted;
        private DevExpress.XtraBars.BarButtonItem btnExcelFileUnformatted;
        private DevExpress.XtraBars.BarButtonItem btnWordFile;
        private DevExpress.XtraBars.BarButtonItem btnPdfFile;
        private DevExpress.XtraBars.BarButtonItem btnTxtFile;
        protected DevExpress.XtraBars.BarButtonItem btnConnectedCards;
    }
}