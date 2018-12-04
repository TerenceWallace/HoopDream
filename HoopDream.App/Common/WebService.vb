Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading.Tasks

Imports HoopDream.Framework.Service
Imports Newtonsoft.Json

Namespace HoopDream.Common
    Friend Class WebService

        Private Shared ReadOnly httpClient As New HttpClient()

        Public Shared Sub Start()
            Store.Instance.CreateDatabaseObjects()

            httpClient.DefaultRequestHeaders.Accept.Clear()
            httpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            DownloadPage().Wait()
        End Sub

        Private Shared Async Function DownloadPage() As Task
            Dim page As String = "https://stats.nba.com/stats/leagueLeaders?LeagueID=00&PerMode=PerGame&Scope=S&Season=2017-18&SeasonType=Regular+Season&StatCategory=PTS"

            Using client As HttpClient = New HttpClient
                Using response As HttpResponseMessage = Await httpClient.GetAsync(page, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(False)
                    If response.IsSuccessStatusCode Then
                        Using content As HttpContent = response.Content
                            Dim json = Await response.Content.ReadAsStringAsync()
                            Dim result = JsonConvert.DeserializeObject(Of NbaStatResponse)(json)
                            Dim players = result.ResultSet.Players
                            Save(players)
                        End Using

                    Else
                        MessageBox.Show("Failed to download information. Please try again later.")
                    End If
                End Using
            End Using

        End Function

        Private Shared Sub Save(ByVal lst As IEnumerable(Of Player))
            lst.ToList.ForEach(Sub(x)
                                   Dim biz As New Framework.Entities.Player With {.Name = x.Name, .IsPicked = False}
                                   Dim PlayerID As Integer = Store.Instance.PlayerManager.Insert(biz)
                                   Dim TeamID As Integer = Store.Instance.Teams.First(Function(tm) String.Compare(tm.ShortName, x.Team, True) = 0).TeamID
                                   Save(x, PlayerID, TeamID)
                               End Sub)
        End Sub

        Private Shared Sub Save(ByVal p As Player, ByVal PlayerID As Integer, ByVal TeamID As Integer)

            Dim items As Array = System.Enum.GetValues(GetType(StatTypes))

            For Each ItemID As Integer In items
                Dim biz As New Framework.Entities.Report With {.Name = Guid.NewGuid.ToString,
                    .PlayerID = PlayerID,
                    .TeamID = TeamID,
                    .ItemID = ItemID,
                    .Value = GetValue(p, ItemID)}

                Store.Instance.ReportManager.Insert(biz)
            Next

        End Sub

        Private Shared Function GetValue(ByVal p As Player, ByVal value As Integer) As Decimal
            Dim ItemID As StatTypes = DirectCast(value, StatTypes)

            Select Case ItemID
                Case StatTypes.AST
                    Return p.Assist

                Case StatTypes.BLK
                    Return p.Block

                Case StatTypes.DRB
                    Return p.DefensiveRebound

                Case StatTypes.FGA
                    Return p.FieldGoalsAttempted

                Case StatTypes.FGM
                    Return p.FieldGoalsMade

                Case StatTypes.FTA
                    Return p.FreeThrowAttempted

                Case StatTypes.FTM
                    Return p.FreeThrowMade

                Case StatTypes.MIN
                    Return p.Minutes

                Case StatTypes.ORB
                    Return p.OffensiveRebound

                Case StatTypes.PA3
                    Return p.ThreePointFieldGoalAttempted

                Case StatTypes.PF
                    Return p.PersonalFoul

                Case StatTypes.PM3
                    Return p.ThreePointFieldGoalMade

                Case StatTypes.STL
                    Return p.Steal

                Case StatTypes.TO
                    Return p.Turnover

                Case StatTypes.GP  ' Games Played
                    Return p.GamesPlayed

                Case StatTypes.FGP  ' Field Goal Percentage
                    Return p.FieldGoalPercentage

                Case StatTypes.TPP  ' Three Point Percentage
                    Return p.ThreePointFieldGoalPercentage

                Case StatTypes.FTP ' Free Throw Percentage
                    Return p.FreeThrowPercentage

                Case StatTypes.R  ' Rebounds
                    Return p.Rebound

                Case StatTypes.P  '  Points
                    Return p.Points

                Case StatTypes.E  ' Efficiency
                    Return p.Efficiency

            End Select

            Return 0
        End Function

    End Class
End Namespace
