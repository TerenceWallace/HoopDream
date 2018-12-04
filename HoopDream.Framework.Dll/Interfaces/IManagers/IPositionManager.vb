Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework

    Public Interface IPositionManager
		
        Function Count() As Integer

        Function Create() As Position
		
        Function GetByPrimaryKey(ByVal PrimaryID As Integer) As Position

        Function GetAll() As System.Collections.Generic.List(Of Position)

        Function Insert(ByVal biz As Position) As Integer

        Sub Update(ByVal biz As Position)

        Sub Delete(ByVal biz As Position)

        Sub DeleteAll()

        Function GetByCriteria(ByVal CommandText As String) As List(Of Position)

		  

    End Interface

End Namespace
