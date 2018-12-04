Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json

Namespace HoopDream.Framework.Service
    Public Class NbaStatResponseParameters
        <JsonProperty("LeagueID")>
        Public Property LeagueId() As Integer
        <JsonProperty("PerMode")>
        Public Property StatMode() As String
        <JsonProperty("StatCategory")>
        Public Property RankedBy() As String
        <JsonProperty("Season")>
        Public Property StatYear() As String
        Public Property SeasonType() As String
        Public Property Scope() As String
        Public Property ActiveFlag() As String
    End Class
End Namespace
