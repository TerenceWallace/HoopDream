Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IPositionsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IPositionView

        Sub ShowPosition(ByVal ViewModel As PositionViewModel)
        Sub ReadUserInput()
    Sub ShowError(ByVal message as String)
    Sub Close()	     

    End Interface
End Namespace
