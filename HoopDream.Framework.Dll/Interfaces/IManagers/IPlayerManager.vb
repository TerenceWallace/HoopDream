Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework

    Public Interface IPlayerManager
		
        Function Count() As Integer

        Function Create() As Player
		
        Function GetByPrimaryKey(ByVal PrimaryID As Integer) As Player

        Function GetAll() As System.Collections.Generic.List(Of Player)

        Function Insert(ByVal biz As Player) As Integer

        Sub Update(ByVal biz As Player)

        Sub Delete(ByVal biz As Player)

        Sub DeleteAll()

        Function GetByCriteria(ByVal CommandText As String) As List(Of Player)

		  

    End Interface

End Namespace
