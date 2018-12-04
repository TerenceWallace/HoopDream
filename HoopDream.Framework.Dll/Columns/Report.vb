
'*************************************************************
' File Name:  Report
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Report
        Inherits Object

	 
	Shared ReadOnly Property ItemID As String = "ItemID"
	 
	Shared ReadOnly Property Name As String = "Name"
	 
	Shared ReadOnly Property PlayerID As String = "PlayerID"
	 
	Shared ReadOnly Property ReportID As String = "ReportID"
	 
	Shared ReadOnly Property TeamID As String = "TeamID"
	 
	Shared ReadOnly Property Value As String = "Value"
	
		     
        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
