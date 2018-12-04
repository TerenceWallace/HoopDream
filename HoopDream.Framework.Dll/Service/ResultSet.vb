Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json

Namespace HoopDream.Framework.Service
	Public Class ResultSet
		<JsonProperty("rowSet")>
		Public Property Players() As IEnumerable(Of Player)
		<JsonProperty("headers")>
		Public Property Headers() As IEnumerable(Of String)
		<JsonProperty("name")>
		Public Property Name() As String
	End Class
End Namespace
