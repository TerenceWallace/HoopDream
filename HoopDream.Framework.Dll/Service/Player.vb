Imports Newtonsoft.Json

Namespace HoopDream.Framework.Service
    <JsonConverter(GetType(PlayerConverter))>
    Public Class Player
        Public Property PlayerID() As Integer
        Public Property Rank() As Integer
        Public Property Name() As String
        Public Property Team() As String
        Public Property GamesPlayed() As Integer
        Public Property Minutes() As Decimal
        Public Property FieldGoalsMade() As Decimal
        Public Property FieldGoalsAttempted() As Decimal
        Public Property FieldGoalPercentage() As Decimal
        Public Property ThreePointFieldGoalMade() As Decimal
        Public Property ThreePointFieldGoalAttempted() As Decimal
        Public Property ThreePointFieldGoalPercentage() As Decimal
        Public Property FreeThrowMade() As Decimal
        Public Property FreeThrowAttempted() As Decimal
        Public Property FreeThrowPercentage() As Decimal
        Public Property OffensiveRebound() As Decimal
        Public Property DefensiveRebound() As Decimal
        Public Property Rebound() As Decimal
        Public Property Assist() As Decimal
        Public Property Steal() As Decimal
        Public Property Block() As Decimal
        Public Property Turnover() As Decimal
        Public Property PersonalFoul() As Decimal
        Public Property Points() As Decimal
        Public Property Efficiency() As Decimal
    End Class
End Namespace