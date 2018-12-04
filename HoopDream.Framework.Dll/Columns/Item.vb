
'*************************************************************
' File Name:  Item
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Item
        Inherits Object

	 
	Shared ReadOnly Property ItemID As String = "ItemID"
	 
	Shared ReadOnly Property Name As String = "Name"
	 
	Shared ReadOnly Property ShortName As String = "ShortName"
	
		     
        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
