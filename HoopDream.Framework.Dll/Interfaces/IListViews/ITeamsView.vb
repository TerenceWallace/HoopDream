Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  ITeamsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface ITeamsView

        Sub ShowTeams(ByVal TeamViewModelList As IEnumerable(Of TeamViewModel))

    End Interface
End Namespace
