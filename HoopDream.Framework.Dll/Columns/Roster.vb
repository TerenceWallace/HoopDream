
'*************************************************************
' File Name:  Roster
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Roster
        Inherits Object

	 
	Shared ReadOnly Property Name As String = "Name"
	 
	Shared ReadOnly Property PlayerID As String = "PlayerID"
	 
	Shared ReadOnly Property PositionID As String = "PositionID"
	 
	Shared ReadOnly Property RosterID As String = "RosterID"
	
		     
        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
