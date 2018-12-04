Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IPositionsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IPositionsView

        Sub ShowPositions(ByVal PositionViewModelList As IEnumerable(Of PositionViewModel))

    End Interface
End Namespace
