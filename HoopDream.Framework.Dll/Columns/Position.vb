
'*************************************************************
' File Name:  Position
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Position
        Inherits Object

	 
	Shared ReadOnly Property Name As String = "Name"
	 
	Shared ReadOnly Property PositionID As String = "PositionID"
	 
	Shared ReadOnly Property ShortName As String = "ShortName"
	
		     
        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
