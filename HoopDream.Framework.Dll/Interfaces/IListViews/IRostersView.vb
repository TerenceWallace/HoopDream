Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IRostersView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IRostersView

        Sub ShowRosters(ByVal RosterViewModelList As IEnumerable(Of RosterViewModel))

    End Interface
End Namespace
