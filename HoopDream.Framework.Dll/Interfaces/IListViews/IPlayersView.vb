Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IPlayersView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IPlayersView

        Sub ShowPlayers(ByVal table As DataTable)

        Sub ShowError(ByVal message As String)

    End Interface
End Namespace
