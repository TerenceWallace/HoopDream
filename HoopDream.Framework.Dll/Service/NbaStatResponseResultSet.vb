﻿Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json

Namespace HoopDream.Framework.Service
	Public Class NbaStatResponseResultSet
		<JsonProperty("name")>
		Private Property Name() As String
		<JsonProperty("headers")>
		Public Property Headers() As IEnumerable(Of String)
		<JsonProperty("rowSet")>
		Public Property Players() As IEnumerable(Of Player)
	End Class
End Namespace
