Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IPlayersView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IPlayerView

        Sub ShowPlayer(ByVal ViewModel As PlayerViewModel)
        Sub ReadUserInput()
    Sub ShowError(ByVal message as String)
    Sub Close()	     

    End Interface
End Namespace
