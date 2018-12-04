Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  ITeamsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface ITeamView

        Sub ShowTeam(ByVal ViewModel As TeamViewModel)
        Sub ReadUserInput()
    Sub ShowError(ByVal message as String)
    Sub Close()	     

    End Interface
End Namespace
