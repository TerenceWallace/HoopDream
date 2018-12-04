
Imports HoopDream.Framework.Entities
Imports HoopDream.Framework.Schema
Imports HoopDream.Framework.ViewModels

'*************************************************************
' Class Name:  InsertPlayerPresenter
' Purpose:  Class to encapsulate business rules and logic
' Description: 
'***************************************************************
Namespace HoopDream.Gui.Presenters

    Friend Class PlayersPresenter

        Private _View As IPlayersView

        Private _Table As RankTable

        Public Sub New(ByVal view As IPlayersView)
            _View = view

            Update()
        End Sub

        Private Sub Databind()
            Builders.PlayerBuilder.Build()
            _Table = Builders.PlayerBuilder.Table
        End Sub

        Public Sub Update()
            Databind()

            _View.ShowPlayers(_Table)
        End Sub

        Public Sub Update(ByVal TeamName As String)
            Databind()

            Dim tblFiltered As DataTable = _Table.AsEnumerable().Where(Function(row) row.Field(Of String)(Framework.Columns.Rank.Team) _
                                                                           = TeamName).CopyToDataTable()

            _Table = tblFiltered
            _View.ShowPlayers(_Table)
        End Sub

        Public Sub Insert(biz As Player)
            Store.Instance.PlayerManager.Insert(biz)
        End Sub


    End Class
End Namespace
