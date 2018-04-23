Imports DevExpress.DataAccess.ObjectBinding
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Xml.Serialization

Namespace FishDataSource
    Public Class Fish
        <DisplayName("ID")> _
        Public Property ID() As Integer
        <DisplayName("Category")> _
        Public Property Category() As String
        <DisplayName("Common Name")> _
        Public Property CommonName() As String
        <DisplayName("Notes")> _
        Public Property Notes() As String
        <DisplayName("Scientific Classification")> _
        Public Property ScientificClassification() As ScientificClassification
    End Class
    Public Class ScientificClassification
        <XmlElement("Reference")> _
        Public Property Hyperlink() As String
        Public Property Kingdom() As String
        Public Property Phylum() As String
        <XmlElement("Class"), DisplayName("Class")> _
        Public Property _Class() As String
        Public Property Order() As String
        Public Property Family() As String
        Public Property Genus() As String
        Public Property Species() As String
    End Class

    <DisplayName("FishesSource"), HighlightedClass> _
    Public NotInheritable Class FishesSource

        Private Sub New()
        End Sub


        Private Shared data_Renamed As List(Of Fish)
        <HighlightedMember> _
        Public Shared ReadOnly Property Data() As List(Of Fish)
            Get
                If data_Renamed Is Nothing Then
                    data_Renamed = GetDataSource()
                End If
                Return data_Renamed
            End Get
        End Property
        Private Shared Function GetDataSource() As List(Of Fish)
            Return DataSourceHelper.GetDataSouresFromXml(Of Fish)("FishDataSource.fishes.xml", "Fishes")
        End Function
    End Class
End Namespace
