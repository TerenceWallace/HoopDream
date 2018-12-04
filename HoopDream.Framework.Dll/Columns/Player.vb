
'*************************************************************
' File Name:  Player
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Player
        Inherits Object

	 
	Shared ReadOnly Property IsPicked As String = "IsPicked"
	 
	Shared ReadOnly Property Name As String = "Name"
	 
	Shared ReadOnly Property PlayerID As String = "PlayerID"
	
		     
        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
