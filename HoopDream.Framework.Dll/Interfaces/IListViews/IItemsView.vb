Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IItemsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IItemsView

        Sub ShowItems(ByVal ItemViewModelList As IEnumerable(Of ItemViewModel))

    End Interface
End Namespace
