Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Serialization

Namespace FishDataSource
    Public NotInheritable Class DataSourceHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDataSouresFromXml(Of T As Class)(ByVal resName As String, ByVal attribute As String) As List(Of T)
            Using stream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resName)
                Dim s As New XmlSerializer(GetType(List(Of T)), New XmlRootAttribute(attribute))
                Return DirectCast(s.Deserialize(stream), List(Of T))
            End Using
        End Function
    End Class
End Namespace
