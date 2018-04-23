namespace SnapObjectDataSourceExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.snapControl1 = new DevExpress.Snap.SnapControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.commandBarItem1 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.showDocumentPropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem();
            this.commandBarItem2 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.barBtnLoadSnx = new DevExpress.XtraBars.BarButtonItem();
            this.barComboDocumentLoadingBehavior = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDocumentLoadingBehavior = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            this.infoRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup();
            this.dataRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.DataRibbonPageGroup();
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.fieldListDockPanel1 = new DevExpress.Snap.Extensions.UI.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.reportExplorerDockPanel1 = new DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel();
            this.reportExplorerDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.snapDocumentManager1 = new DevExpress.Snap.Extensions.SnapDocumentManager(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.snapBarController1 = new DevExpress.Snap.Extensions.SnapBarController();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barCheckCustomValidationService = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDocumentLoadingBehavior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.fieldListDockPanel1.SuspendLayout();
            this.reportExplorerDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // snapControl1
            // 
            this.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapControl1.Location = new System.Drawing.Point(0, 146);
            this.snapControl1.MenuManager = this.ribbonControl1;
            this.snapControl1.Name = "snapControl1";
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = null;
            this.snapControl1.Size = new System.Drawing.Size(584, 415);
            this.snapControl1.TabIndex = 0;
            this.snapControl1.Text = "snapControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.undoItem1,
            this.redoItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.commandBarItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.showDocumentPropertiesFormItem1,
            this.commandBarItem2,
            this.barBtnLoadSnx,
            this.barComboDocumentLoadingBehavior,
            this.barCheckCustomValidationService});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.fileRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDocumentLoadingBehavior});
            this.ribbonControl1.Size = new System.Drawing.Size(784, 146);
            // 
            // undoItem1
            // 
            this.undoItem1.Id = 1;
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Id = 2;
            this.redoItem1.Name = "redoItem1";
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Id = 3;
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Id = 4;
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Id = 5;
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Id = 6;
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // commandBarItem1
            // 
            this.commandBarItem1.Id = 7;
            this.commandBarItem1.Name = "commandBarItem1";
            this.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument;
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Id = 8;
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 9;
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 10;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // showDocumentPropertiesFormItem1
            // 
            this.showDocumentPropertiesFormItem1.Id = 11;
            this.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1";
            // 
            // commandBarItem2
            // 
            this.commandBarItem2.Id = 12;
            this.commandBarItem2.Name = "commandBarItem2";
            this.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource;
            // 
            // barBtnLoadSnx
            // 
            this.barBtnLoadSnx.Caption = "Load Data Bound Snap Document";
            this.barBtnLoadSnx.Id = 14;
            this.barBtnLoadSnx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnLoadSnx.ImageOptions.Image")));
            this.barBtnLoadSnx.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnLoadSnx.ImageOptions.LargeImage")));
            this.barBtnLoadSnx.Name = "barBtnLoadSnx";
            this.barBtnLoadSnx.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLoadSnx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLoadSnx_ItemClick);
            // 
            // barComboDocumentLoadingBehavior
            // 
            this.barComboDocumentLoadingBehavior.Caption = "DocumentLoadingBehavior";
            this.barComboDocumentLoadingBehavior.Edit = this.repositoryItemDocumentLoadingBehavior;
            this.barComboDocumentLoadingBehavior.EditWidth = 100;
            this.barComboDocumentLoadingBehavior.Id = 16;
            this.barComboDocumentLoadingBehavior.Name = "barComboDocumentLoadingBehavior";
            // 
            // repositoryItemDocumentLoadingBehavior
            // 
            this.repositoryItemDocumentLoadingBehavior.AutoHeight = false;
            this.repositoryItemDocumentLoadingBehavior.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDocumentLoadingBehavior.Name = "repositoryItemDocumentLoadingBehavior";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Example";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnLoadSnx);
            this.ribbonPageGroup1.ItemLinks.Add(this.barComboDocumentLoadingBehavior);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckCustomValidationService);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Object Data Source";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.infoRibbonPageGroup1,
            this.dataRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.undoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.redoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileNewItem1, "N");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileOpenItem1, "O");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveItem1, "S");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveAsItem1, "A");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.commandBarItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.quickPrintItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printItem1, "P");
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // infoRibbonPageGroup1
            // 
            this.infoRibbonPageGroup1.ItemLinks.Add(this.showDocumentPropertiesFormItem1);
            this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
            // 
            // dataRibbonPageGroup1
            // 
            this.dataRibbonPageGroup1.ItemLinks.Add(this.commandBarItem2);
            this.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1";
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.snapDockManager1.SnapControl = this.snapControl1;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer1.Controls.Add(this.reportExplorerDockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("e82ee214-9e44-4ce5-b24d-eaae771bd127");
            this.panelContainer1.Location = new System.Drawing.Point(584, 146);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 415);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("6b65de31-284e-4721-9ede-45812bc96e32");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 208);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 208);
            this.fieldListDockPanel1.SnapControl = this.snapControl1;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(5, 38);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(191, 165);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            this.reportExplorerDockPanel1.Controls.Add(this.reportExplorerDockPanel1_Container);
            this.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.reportExplorerDockPanel1.ID = new System.Guid("cc87e06e-3c3b-4ee3-9318-32b9d9d91dd2");
            this.reportExplorerDockPanel1.Location = new System.Drawing.Point(0, 208);
            this.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            this.reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(200, 207);
            this.reportExplorerDockPanel1.Size = new System.Drawing.Size(200, 207);
            this.reportExplorerDockPanel1.SnapControl = this.snapControl1;
            // 
            // reportExplorerDockPanel1_Container
            // 
            this.reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(5, 38);
            this.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            this.reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(191, 165);
            this.reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // snapDocumentManager1
            // 
            this.snapDocumentManager1.ClientControl = this.snapControl1;
            this.snapDocumentManager1.View = this.noDocumentsView1;
            this.snapDocumentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1});
            // 
            // snapBarController1
            // 
            this.snapBarController1.BarItems.Add(this.undoItem1);
            this.snapBarController1.BarItems.Add(this.redoItem1);
            this.snapBarController1.BarItems.Add(this.fileNewItem1);
            this.snapBarController1.BarItems.Add(this.fileOpenItem1);
            this.snapBarController1.BarItems.Add(this.fileSaveItem1);
            this.snapBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem1);
            this.snapBarController1.BarItems.Add(this.quickPrintItem1);
            this.snapBarController1.BarItems.Add(this.printItem1);
            this.snapBarController1.BarItems.Add(this.printPreviewItem1);
            this.snapBarController1.BarItems.Add(this.showDocumentPropertiesFormItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem2);
            this.snapBarController1.Control = this.snapControl1;
            this.snapBarController1.RibbonControl = this.ribbonControl1;
            this.snapBarController1.SnapDockManager = this.snapDockManager1;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // barCheckCustomValidationService
            // 
            this.barCheckCustomValidationService.Caption = "Custom Validation Service";
            this.barCheckCustomValidationService.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.barCheckCustomValidationService.Id = 17;
            this.barCheckCustomValidationService.Name = "barCheckCustomValidationService";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.snapControl1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Snap Object Data Source Example";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDocumentLoadingBehavior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.fieldListDockPanel1.ResumeLayout(false);
            this.reportExplorerDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.Snap.Extensions.SnapDocumentManager snapDocumentManager1;
        private DevExpress.XtraBars.Docking.ControlContainer reportExplorerDockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel reportExplorerDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.Snap.SnapControl snapControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem showDocumentPropertiesFormItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem2;
        private DevExpress.XtraRichEdit.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup infoRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.DataRibbonPageGroup dataRibbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.Snap.Extensions.SnapBarController snapBarController1;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadSnx;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarEditItem barComboDocumentLoadingBehavior;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemDocumentLoadingBehavior;
        private DevExpress.XtraBars.BarCheckItem barCheckCustomValidationService;
    }
}

