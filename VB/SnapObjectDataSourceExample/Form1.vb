Imports DevExpress.Snap.Services
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DataAccess.ObjectBinding

Namespace SnapObjectDataSourceExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private defaultValidationService As IObjectDataSourceValidationService

        Public Sub New()
            InitializeComponent()

'            #Region "#ObjectDataSourceLoadingBehavior"
            snapControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.Prompt
'            #End Region ' #ObjectDataSourceLoadingBehavior

            defaultValidationService = snapControl1.GetService(Of IObjectDataSourceValidationService)()

            repositoryItemDocumentLoadingBehavior.Items.AddRange(GetType(DevExpress.DataAccess.DocumentLoadingBehavior).GetEnumValues())
            barComboDocumentLoadingBehavior.EditValue = snapControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior

            AddHandler barComboDocumentLoadingBehavior.EditValueChanged, AddressOf barComboDocumentLoadingBehavior_EditValueChanged
            AddHandler Me.barCheckCustomValidationService.CheckedChanged, AddressOf BarCheckCustomValidationService_CheckedChanged
        End Sub

        Private Sub BarCheckCustomValidationService_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            If barCheckCustomValidationService.Checked Then
'                #Region "#ReplaceService"
                snapControl1.ReplaceService(Of IObjectDataSourceValidationService)(New MyObjectDataSourceValidationService())
'                #End Region ' #ReplaceService
            Else
                snapControl1.ReplaceService(Of IObjectDataSourceValidationService)(defaultValidationService)
            End If
        End Sub

        Private Sub barBtnLoadSnx_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnLoadSnx.ItemClick
            snapControl1.LoadDocument("DataBoundReport.snx")
        End Sub

        Private Sub barComboDocumentLoadingBehavior_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            snapControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = CType((TryCast(sender, DevExpress.XtraBars.BarEditItem)).EditValue, DevExpress.DataAccess.DocumentLoadingBehavior)
        End Sub
    End Class
    #Region "#MyObjectDataSourceValidationService"
    Public Class MyObjectDataSourceValidationService
        Implements IObjectDataSourceValidationService

        Public Sub Validate(ByVal dataSources As IEnumerable(Of ObjectDataSource)) Implements IObjectDataSourceValidationService.Validate
            ' Do nothing to allow loading.
            ' Clear the DataSource and DataMember properties to prohibit loading.
            For Each ds As ObjectDataSource In dataSources
                ds.DataSource = Nothing
                ds.DataMember = Nothing
            Next ds
        End Sub
    End Class
    #End Region ' #MyObjectDataSourceValidationService
End Namespace
