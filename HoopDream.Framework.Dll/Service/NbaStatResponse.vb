Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json

Namespace HoopDream.Framework.Service
    Public Class NbaStatResponse
        <JsonProperty("resource")>
        Public Property Resource() As String
        <JsonProperty("parameters")>
        Public Property Metadata() As NbaStatResponseParameters
        <JsonProperty("resultSet")>
        Public Property ResultSet() As NbaStatResponseResultSet
    End Class
End Namespace
