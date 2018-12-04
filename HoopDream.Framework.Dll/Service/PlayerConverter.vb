Option Strict Off

Imports System
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace HoopDream.Framework.Service
    Public Class PlayerConverter
        Inherits JsonConverter

        Public Overrides Sub WriteJson(ByVal writer As JsonWriter, ByVal value As Object, ByVal serializer As JsonSerializer)
            Dim player = DirectCast(value, Player)
            serializer.Serialize(writer, {player.PlayerId.ToString(), player.Rank.ToString(), player.Name, player.Team, player.GamesPlayed.ToString(), player.Minutes.ToString(), player.FieldGoalsMade.ToString(), player.FieldGoalsAttempted.ToString(), player.FieldGoalPercentage.ToString(), player.ThreePointFieldGoalMade.ToString(), player.ThreePointFieldGoalAttempted.ToString(), player.ThreePointFieldGoalPercentage.ToString(), player.FreeThrowMade.ToString(), player.FreeThrowAttempted.ToString(), player.FreeThrowPercentage.ToString(), player.OffensiveRebound.ToString(), player.DefensiveRebound.ToString(), player.Rebound.ToString(), player.Assist.ToString(), player.Steal.ToString(), player.Block.ToString(), player.Turnover.ToString(), player.PersonalFoul.ToString(), player.Points.ToString(), player.Efficiency.ToString()})
        End Sub

        Public Overrides Function ReadJson(ByVal reader As JsonReader, ByVal objectType As Type, ByVal existingValue As Object, ByVal serializer As JsonSerializer) As Object
            If reader.TokenType = JsonToken.Null Then
                Return Nothing
            End If

            Try

                Dim array As JArray = JArray.Load(reader)
                Dim player = If(TryCast(existingValue, Player), New Player())
                player.PlayerId = CInt(Math.Truncate(CDec(array.ElementAtOrDefault(0))))
                player.Rank = CInt(Math.Truncate(CDec(array.ElementAtOrDefault(1))))
                player.Name = CStr(array.ElementAtOrDefault(2))
                player.Team = CStr(array.ElementAtOrDefault(3))
                player.GamesPlayed = CInt(Math.Truncate(CDec(array.ElementAtOrDefault(4))))
                player.Minutes = CDec(array.ElementAtOrDefault(5))
                player.FieldGoalsMade = CDec(array.ElementAtOrDefault(6))
                player.FieldGoalsAttempted = CDec(array.ElementAtOrDefault(7))
                player.FieldGoalPercentage = CDec(array.ElementAtOrDefault(8))
                player.ThreePointFieldGoalMade = CDec(array.ElementAtOrDefault(9))
                player.ThreePointFieldGoalAttempted = CDec(array.ElementAtOrDefault(10))
                player.ThreePointFieldGoalPercentage = CDec(array.ElementAtOrDefault(11))
                player.FreeThrowMade = CDec(array.ElementAtOrDefault(12))
                player.FreeThrowAttempted = CDec(array.ElementAtOrDefault(13))
                player.FreeThrowPercentage = CDec(array.ElementAtOrDefault(14))
                player.OffensiveRebound = CDec(array.ElementAtOrDefault(15))
                player.DefensiveRebound = CDec(array.ElementAtOrDefault(16))
                player.Rebound = CDec(array.ElementAtOrDefault(17))
                player.Assist = CDec(array.ElementAtOrDefault(18))
                player.Steal = CDec(array.ElementAtOrDefault(19))
                player.Block = CDec(array.ElementAtOrDefault(20))
                player.Turnover = CDec(array.ElementAtOrDefault(21))
                player.PersonalFoul = CDec(array.ElementAtOrDefault(22))
                player.Points = CDec(array.ElementAtOrDefault(23))
                'player.Efficiency = (decimal) array.ElementAtOrDefault(24);

                Return player
            Catch e As Exception
                Console.WriteLine(e)
                Return Nothing
            End Try
        End Function

        Public Overrides Function CanConvert(ByVal objectType As Type) As Boolean
            Return objectType Is GetType(Player)
        End Function
    End Class
End Namespace