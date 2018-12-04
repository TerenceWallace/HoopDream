
'*************************************************************
' File Name:  Team
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Team
        Inherits Object

	 
	Shared ReadOnly Property Name As String = "Name"
	 
	Shared ReadOnly Property ShortName As String = "ShortName"
	 
	Shared ReadOnly Property TeamID As String = "TeamID"
	
		     
        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
