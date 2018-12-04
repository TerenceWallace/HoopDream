Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework

    Public Interface IRosterManager
		
        Function Count() As Integer

        Function Create() As Roster
		
        Function GetByPrimaryKey(ByVal PrimaryID As Integer) As Roster

        Function GetAll() As System.Collections.Generic.List(Of Roster)

        Function Insert(ByVal biz As Roster) As Integer

        Sub Update(ByVal biz As Roster)

        Sub Delete(ByVal biz As Roster)

        Sub DeleteAll()

        Function GetByCriteria(ByVal CommandText As String) As List(Of Roster)

		  
		  Function GetRostersByPlayerID(ByVal PlayerID As Integer) As List(Of Roster)
		  
		  Function GetRostersByPositionID(ByVal PositionID As Integer) As List(Of Roster)
		  

    End Interface

End Namespace
