Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework

    Public Interface ITeamManager
		
        Function Count() As Integer

        Function Create() As Team
		
        Function GetByPrimaryKey(ByVal PrimaryID As Integer) As Team

        Function GetAll() As System.Collections.Generic.List(Of Team)

        Function Insert(ByVal biz As Team) As Integer

        Sub Update(ByVal biz As Team)

        Sub Delete(ByVal biz As Team)

        Sub DeleteAll()

        Function GetByCriteria(ByVal CommandText As String) As List(Of Team)

		  

    End Interface

End Namespace
