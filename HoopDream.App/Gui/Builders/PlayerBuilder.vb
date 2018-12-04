Imports System.Threading.Tasks
Imports HoopDream.Framework.Entities
Imports HoopDream.Framework.Schema
Imports HoopDream.Framework.ViewModels

Namespace HoopDream.Gui.Builders

    Public NotInheritable Class PlayerBuilder

        Public Shared ReadOnly Property Table As RankTable

        Private Sub New()
        End Sub

        Public Shared Sub Build()
            Dim lst As IEnumerable(Of Player) = Store.Instance.Players
            Dim ResultSet As New List(Of PlayerViewModel)

            For Each biz As Player In lst

                Dim PlayerID As Integer = biz.PlayerID

                Dim ReportList As IEnumerable(Of Report) = Store.Instance.Reports.Where(Function(x) x.PlayerID = PlayerID)
                Dim vm As New PlayerViewModel(biz) '
                vm.Reports = ReportList

                vm.Reports.ToList.ForEach(Sub(x)

                                              Dim TeamID As Integer = x.TeamID
                                              Dim TeamName As String = Store.Instance.Teams.First(Function(t) t.TeamID = TeamID).Name
                                              vm.TeamName = TeamName
                                              SetItemValues(vm, x)

                                          End Sub)
                ResultSet.Add(vm)
            Next biz

            Build(ResultSet)
        End Sub

        Private Shared Sub Build(ByVal Players As List(Of PlayerViewModel))
            If Players Is Nothing Or Players.Count <= 0 Then Exit Sub
            Dim pointsAverage = Players.Select(Function(x) x.Points).Average()
            Dim pointsStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.Points))

            Dim reboundAverage = Players.Select(Function(x) x.Rebound).Average()
            Dim reboundStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.Rebound))

            Dim stealAverage = Players.Select(Function(x) x.Steal).Average()
            Dim stealStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.Steal))

            Dim blockAverage = Players.Select(Function(x) x.Block).Average()
            Dim blockStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.Block))

            Dim fieldGoalPercentageAverage = Players.Select(Function(x) x.FieldGoalPercentage * x.FieldGoalsAttempted).Average()
            Dim fieldGoalStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.FieldGoalPercentage * x.FieldGoalsAttempted))

            Dim freeThrowPercentageAverage = Players.Select(Function(x) x.FreeThrowPercentage * x.FreeThrowAttempted).Average()
            Dim freeThrowPercentageStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.FreeThrowPercentage * x.FreeThrowAttempted))

            Dim threePointerAverage = Players.Select(Function(x) x.ThreePointFieldGoalMade).Average()
            Dim threePointerStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.ThreePointFieldGoalMade))

            Dim turnoverAverage = Players.Select(Function(x) x.Turnover).Average()
            Dim turnoverStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.Turnover))

            Dim assistAverage = Players.Select(Function(x) x.Assist).Average()
            Dim assistStandardDeviation = CalculateStandardDeviation(Players.Select(Function(x) x.Assist))

            Dim playerCategories As IEnumerable(Of Framework.Service.PlayerCategories) = Players.Select(
                Function(x) New Framework.Service.PlayerCategories With {
                .PlayerID = x.PlayerID,
              .PlayerName = x.Name,
            .PlayerTeam = x.TeamName,
            .AssistRank = Math.Round((x.Assist - assistAverage) / assistStandardDeviation, 2),
            .StealRank = Math.Round((x.Steal - stealAverage) / stealStandardDeviation, 2),
            .ReboundRank = Math.Round((x.Rebound - reboundAverage) / reboundStandardDeviation, 2),
            .FieldGoalPercentageRank = Math.Round((x.FieldGoalPercentage * x.FieldGoalsAttempted - fieldGoalPercentageAverage) / fieldGoalStandardDeviation, 2),
            .FreeThrowPercentageRank = Math.Round((x.FreeThrowPercentage * x.FreeThrowAttempted - freeThrowPercentageAverage) / freeThrowPercentageStandardDeviation, 2),
            .BlockRank = Math.Round((x.Block - blockAverage) / blockStandardDeviation, 2),
            .ThreePointRank = Math.Round((x.ThreePointFieldGoalMade - threePointerAverage) / threePointerStandardDeviation, 2),
            .TurnoverRank = Math.Round((x.Turnover - turnoverAverage) / turnoverStandardDeviation, 2),
            .PointRank = Math.Round((x.Points - pointsAverage) / pointsStandardDeviation, 2)
        })

            Dim playerRank As IEnumerable(Of Framework.Service.PlayerCategories) = playerCategories.OrderByDescending(
                Function(x) x.AssistRank + x.BlockRank + x.StealRank + x.ReboundRank + x.PointRank _
                + x.ThreePointRank + x.FieldGoalPercentageRank + x.FreeThrowPercentageRank - x.TurnoverRank)

            _Table = New RankTable
            Dim i As Integer = 1

            'For i As Integer = 0 To 49
            playerRank.ToList().ForEach(Sub(x)
                                            'Dim x As Framework.Service.PlayerCategories = playerCategories(i) ' playerRank(i)
                                            Dim row As RankRow = _Table.NewRow()

                                            With row
                                                .PlayerID = x.PlayerID
                                                .Name = x.PlayerName
                                                .Rank = i ' i + 1
                                                .Team = x.PlayerTeam
                                                .Points = x.PointRank
                                                .FieldGoals = x.FieldGoalPercentageRank
                                                .FreeThrowPercentageRank = x.FreeThrowPercentageRank

                                                .ThreePointRank = x.ThreePointRank
                                                .ReboundRank = x.ReboundRank
                                                .AssistRank = x.AssistRank

                                                .StealRank = x.StealRank
                                                .BlockRank = x.BlockRank

                                                .TurnoverRank = x.TurnoverRank
                                                i += 1
                                            End With
                                            _Table.AddPlayerRow(row)

                                        End Sub)
            'Next i
            _Table.AcceptChanges()


        End Sub

#Region "SetItemValues"
        Private Shared Sub SetItemValues(ByVal vm As PlayerViewModel, ByVal rpt As Report)
            Dim ItemList As IEnumerable(Of Item) = Store.Instance.Items()
            Dim ReportValue As Decimal = rpt.Value

            For Each biz As Item In ItemList
                Dim ItemID As StatTypes = rpt.ItemID

                Select Case ItemID
                    Case StatTypes.AST
                        vm.Assist = ReportValue

                    Case StatTypes.BLK
                        vm.Block = ReportValue

                    Case StatTypes.DRB
                        vm.DefensiveRebound = ReportValue

                    Case StatTypes.FGA
                        vm.FieldGoalsAttempted = ReportValue

                    Case StatTypes.FGM
                        vm.FieldGoalsMade = ReportValue

                    Case StatTypes.FTA
                        vm.FreeThrowAttempted = ReportValue

                    Case StatTypes.FTM
                        vm.FreeThrowMade = ReportValue

                    Case StatTypes.MIN
                        vm.Minutes = ReportValue

                    Case StatTypes.ORB
                        vm.OffensiveRebound = ReportValue

                    Case StatTypes.PA3
                        vm.ThreePointFieldGoalAttempted = ReportValue

                    Case StatTypes.PF
                        vm.PersonalFoul = ReportValue

                    Case StatTypes.PM3
                        vm.ThreePointFieldGoalMade = ReportValue

                    Case StatTypes.STL
                        vm.Steal = ReportValue

                    Case StatTypes.TO
                        vm.Turnover = ReportValue

                    Case StatTypes.GP  ' Games Played
                        vm.GamesPlayed = ReportValue

                    Case StatTypes.FGP  ' Field Goal Percentage
                        vm.FieldGoalPercentage = ReportValue

                    Case StatTypes.TPP  ' Three Point Percentage
                        vm.ThreePointFieldGoalPercentage = ReportValue

                    Case StatTypes.FTP ' Free Throw Percentage
                        vm.FreeThrowPercentage = ReportValue

                    Case StatTypes.R  ' Rebounds
                        vm.Rebound = ReportValue

                    Case StatTypes.P  ' Points
                        vm.Points = ReportValue

                    Case StatTypes.E  ' Efficiency
                        vm.Efficiency = ReportValue

                End Select

            Next biz

        End Sub
#End Region

#Region "CalculateStandardDeviation"
        Private Shared Function CalculateStandardDeviation(ByVal values As IEnumerable(Of Decimal)) As Decimal
            Dim average As Decimal = values.Average()
            Dim sum As Decimal = CDec(values.Sum(Function(d) Math.Pow(CDbl(d) - CDbl(average), 2)))
            Dim result As Decimal = CDec(Math.Sqrt((CDbl(sum) / (values.Count() - 1))))

            Return IIf(result > 0, result, 1)

        End Function
#End Region

    End Class
End Namespace