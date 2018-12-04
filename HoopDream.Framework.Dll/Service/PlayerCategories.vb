Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace HoopDream.Framework.Service
    Public Class PlayerCategories
        Public Property PlayerID As Integer
        Public Property PlayerName() As String
        Public Property PlayerTeam() As String
        Public Property PointRank() As Decimal
        Public Property FieldGoalPercentageRank() As Decimal
        Public Property FreeThrowPercentageRank() As Decimal
        Public Property ThreePointRank() As Decimal
        Public Property ReboundRank() As Decimal
        Public Property AssistRank() As Decimal
        Public Property StealRank() As Decimal
        Public Property BlockRank() As Decimal
        Public Property TurnoverRank() As Decimal
    End Class
End Namespace
