<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SnapObjectDataSourceExample/Form1.cs) (VB: [Form1.vb](./VB/SnapObjectDataSourceExample/Form1.vb))
<!-- default file list end -->
# How to validate the ObjectDataSource contained in the Snap document

> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

This example illustrates how to use the [SnapControl.Options.DataSourceOptions](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.SnapControlOptions.DataSourceOptions?v=21.2) property and a custom service that implements the [IObjectDataSourceValidationService](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Services.IObjectDataSourceValidationService?v=21.2) interface to validate an [ObjectDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ObjectBinding.ObjectDataSource) contained in the loaded document and prevent the data source from loading.  
Click **Load Template** to load mail merge template with object data source. Select the **DocumentLoadingBehavior** value combo to specify whether to call a service to prompt the user. Check the **Custom Validation Service** checkbox to replace a default service with a custom implementation which silently prohibits data loading.  

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-validate-the-objectdatasource-contained-in-the-snap-document-t514281/16.2.7+/media/45828db2-3a28-11e7-80c0-00155d624807.png)
