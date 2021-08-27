<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608852/16.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T514281)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SnapObjectDataSourceExample/Form1.cs) (VB: [Form1.vb](./VB/SnapObjectDataSourceExample/Form1.vb))
<!-- default file list end -->
# How to validate the ObjectDataSource contained in the Snap document


This example illustrates how to use the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapSnapControlOptions_DataSourceOptionstopic">SnapControl.Options.DataSourceOptions</a> property and a custom service that implements the <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressSnapServicesIObjectDataSourceValidationServicetopic">IObjectDataSourceValidationService</a> interface to validate an <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessObjectBindingObjectDataSourcetopic">ObjectDataSource</a> contained in the loaded document and prevent the data source from loading.<br>Click <strong>Load Template </strong>to load mail merge template with object data source. Select the <strong>DocumentLoadingBehavior</strong> value combo to specify whether to call a service to prompt the user. Check the <strong>Custom Validation Service </strong>checkbox to replace a default service with a custom implementation which silently prohibits data loading.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-validate-the-objectdatasource-contained-in-the-snap-document-t514281/16.2.7+/media/45828db2-3a28-11e7-80c0-00155d624807.png"><br><br>

<br/>


