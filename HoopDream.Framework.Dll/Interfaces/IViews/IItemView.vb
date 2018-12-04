Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IItemsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IItemView

        Sub ShowItem(ByVal ViewModel As ItemViewModel)
        Sub ReadUserInput()
    Sub ShowError(ByVal message as String)
    Sub Close()	     

    End Interface
End Namespace
