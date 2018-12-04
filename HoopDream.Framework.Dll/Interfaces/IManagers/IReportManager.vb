Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework

    Public Interface IReportManager
		
        Function Count() As Integer

        Function Create() As Report
		
        Function GetByPrimaryKey(ByVal PrimaryID As Integer) As Report

        Function GetAll() As System.Collections.Generic.List(Of Report)

        Function Insert(ByVal biz As Report) As Integer

        Sub Update(ByVal biz As Report)

        Sub Delete(ByVal biz As Report)

        Sub DeleteAll()

        Function GetByCriteria(ByVal CommandText As String) As List(Of Report)

		  
		  Function GetReportsByItemID(ByVal ItemID As Integer) As List(Of Report)
		  
		  Function GetReportsByPlayerID(ByVal PlayerID As Integer) As List(Of Report)
		  
		  Function GetReportsByTeamID(ByVal TeamID As Integer) As List(Of Report)
		  

    End Interface

End Namespace
