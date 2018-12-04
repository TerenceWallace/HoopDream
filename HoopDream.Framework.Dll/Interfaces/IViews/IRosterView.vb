Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IRostersView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IRosterView

        Sub ShowRoster(ByVal ViewModel As RosterViewModel)
        Sub ReadUserInput()
    Sub ShowError(ByVal message as String)
    Sub Close()	     

    End Interface
End Namespace
