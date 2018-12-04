
'*************************************************************
' File Name:  Player
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Columns

    Public NotInheritable Class Rank
        Inherits Object

        Shared ReadOnly Property RankTable As String = "RankTable"

        Shared ReadOnly Property PlayerID As String = "PlayerID"

        Shared ReadOnly Property Rank As String = "Rank"

        Shared ReadOnly Property Name As String = "Name"

        Shared ReadOnly Property Team As String = "Team"

        Shared ReadOnly Property Points As String = "Points"

        Shared ReadOnly Property FieldGoals As String = "FieldGoals"

        Shared ReadOnly Property ThreePoints As String = "ThreePoints"

        Shared ReadOnly Property FreeThrows As String = "FreeThrows"

        Shared ReadOnly Property Rebounds As String = "Rebounds"

        Shared ReadOnly Property Assists As String = "Assists"

        Shared ReadOnly Property Steals As String = "Steals"

        Shared ReadOnly Property Blocks As String = "Blocks"

        Shared ReadOnly Property Turnovers As String = "Turnovers"

        Private Sub New()
            MyBase.New()
        End Sub

    End Class
End Namespace
