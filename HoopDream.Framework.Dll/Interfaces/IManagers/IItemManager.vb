Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework

    Public Interface IItemManager
		
        Function Count() As Integer

        Function Create() As Item
		
        Function GetByPrimaryKey(ByVal PrimaryID As Integer) As Item

        Function GetAll() As System.Collections.Generic.List(Of Item)

        Function Insert(ByVal biz As Item) As Integer

        Sub Update(ByVal biz As Item)

        Sub Delete(ByVal biz As Item)

        Sub DeleteAll()

        Function GetByCriteria(ByVal CommandText As String) As List(Of Item)

		  

    End Interface

End Namespace
