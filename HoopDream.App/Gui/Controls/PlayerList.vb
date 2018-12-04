
Imports System.ComponentModel
Imports System.Diagnostics
Imports Microsoft.Win32

Imports HoopDream.Framework.ViewModels
Imports HoopDream.Gui.Presenters
Imports HoopDream.Framework

Imports HoopDream.Framework.Entities
Imports System.Threading.Tasks
Imports System.Threading

Namespace HoopDream.Gui.Controls
    Friend Class PlayerList
        Implements IPlayersView


        ' Style applied to the DataGridView should only be created once
        Private IsStyleApplied As Boolean = False

        Private _PlayerTable As HoopDream.Framework.Schema.RankTable = Nothing

        Public Event SelectionChanged As EventHandler(Of PlayerEventArgs)

        Private _PlayerImage As Bitmap
        Private _font As Font

        Private uiScheduler As TaskScheduler

        Private _Presenter As PlayersPresenter

        Private IsCancelled As Boolean = False

#Region "PlayerList_Load"
        Private Sub PlayerList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext()

            ' Auto dock fill
            Me.Dock = DockStyle.Fill

            ' Get images

            _PlayerImage = My.Resources.player16
            _PlayerImage.MakeTransparent(Color.FromArgb(238, 238, 238))

            InitializeHandlers()
        End Sub

        Private Sub InitializeHandlers()
        End Sub
#End Region

        Public Sub Databind()
            If _Presenter Is Nothing Then _Presenter = New PlayersPresenter(Me)
            _Presenter.Update()
        End Sub

        Public Sub Databind(ByVal TeamName As String)
            If _Presenter Is Nothing Then Exit Sub

            _Presenter.Update(TeamName)
        End Sub

        Public Sub ShowError(message As String) Implements IPlayersView.ShowError

        End Sub

        Public Sub ShowPlayers(ByVal table As DataTable) Implements IPlayersView.ShowPlayers
            _PlayerTable = CType(table, Schema.RankTable)

            FormatGrid()
            Invalidate()

        End Sub


#Region "miExport_Click"
        'Friend Sub Export()
        '    Dim mgr As PlayerManager = Store.Instance.PlayerManager
        '    Dim lst As New List(Of ExportPlayerViewModel)

        '    Dim lstPlayer As List(Of Player) = mgr.GetAll
        '    Dim lstLocation As List(Of Location) = Store.Instance.Locations

        '    For Each biz As Player In lstPlayer
        '        Dim item As Location = lstLocation.Find(Function(m) m.LocationID = biz.LocationID)

        '        If Not item Is Nothing Then lst.Add(New ExportPlayerViewModel(biz, item))
        '    Next

        '    If lst.Count <= 0 Then Exit Sub
        '    SaveFile(lst)
        'End Sub

        'Private Sub miExport_Click(sender As Object, e As EventArgs) Handles miExport.Click
        '    Export()
        'End Sub
#End Region

#Region "SaveFileName"
        'Private Sub SaveFile(ByVal Players As List(Of ExportPlayerViewModel))
        '    Try

        '        Using sfd As New SaveFileDialog

        '            With sfd
        '                .Title = "Save Excel File"
        '                .Filter = ExcelFileFilter
        '                .FileName = $"Network-Report_{Now.Year}-{Now.Month}-{Now.Day}"
        '                .DefaultExt = ".xlsx"

        '                If .ShowDialog = DialogResult.OK Then
        '                    Dim OriginalFileName As String = .FileName

        '                    Network.Instance.Export(Players, OriginalFileName)

        '                End If

        '            End With
        '        End Using

        '    Catch ex As System.InvalidOperationException
        '        MessageBox.Show("Sorry, you may have selected to many files at one time." + Environment.NewLine +
        '                        "Try again by selecting less files.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        '    Catch ex As UnauthorizedAccessException
        '        MessageBox.Show("Sorry, you do not have the necessary permissions to open a file from here.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        '    Catch ex As Exception
        '        Dim mText As String = String.Format("Ooops. Unexpected error:{0}{0}({1}){0}{2}", Environment.NewLine, ex.GetType().Name, ex.Message)
        '        MessageBox.Show(mText, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    End Try
        'End Sub
#End Region

#Region "FormatGrid"
        Private Sub FormatGrid()
            If _PlayerTable Is Nothing Then Exit Sub

            ' Set the DataGrid caption and bind it to the DataSet.
            With gridPlayers
                .CaptionText = "Player Rankings"
                .DataSource = _PlayerTable
            End With

            ' Use a table style object to apply custom formatting to the DataGrid.
            ' Only create this style the first time the data is loaded.
            If Not IsStyleApplied Then
                Dim grdTableStyle1 As New DataGridTableStyle

                With grdTableStyle1
                    .AlternatingBackColor = Color.LightSkyBlue
                    .BackColor = Color.WhiteSmoke
                    .ForeColor = Color.Black
                    .GridLineColor = Color.Gainsboro
                    .GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
                    .HeaderBackColor = Color.MidnightBlue
                    .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
                    .HeaderForeColor = Color.WhiteSmoke
                    .LinkColor = Color.Blue
                    ' Do not forget to set the MappingName property. 
                    ' Without this, the DataGridTableStyle properties
                    ' and any associated DataGridColumnStyle objects
                    ' will have no effect.
                    .MappingName = Framework.Columns.Rank.RankTable
                    .SelectionBackColor = Color.CadetBlue
                    .SelectionForeColor = Color.WhiteSmoke
                End With

                ' Use column style objects to apply formatting specific to each column.
                '' First column is a hidden column
                Dim grdColStyle0 As New DataGridTextBoxColumn
                With grdColStyle0
                    .HeaderText = Framework.Columns.Rank.PlayerID
                    .MappingName = Framework.Columns.Rank.PlayerID
                    .Width = 0
                End With

                Dim grdColStyle1 As New DataGridTextBoxColumn
                With grdColStyle1
                    .HeaderText = Framework.Columns.Rank.Rank
                    .MappingName = Framework.Columns.Rank.Rank
                    .Width = 75
                End With

                Dim grdColStyle2 As New DataGridTextBoxColumn
                With grdColStyle2
                    .HeaderText = Framework.Columns.Rank.Name
                    .MappingName = Framework.Columns.Rank.Name
                    .Width = 175
                End With

                Dim grdColStyle3 As New DataGridTextBoxColumn
                With grdColStyle3
                    .HeaderText = Framework.Columns.Rank.Team
                    .MappingName = Framework.Columns.Rank.Team
                    .Width = 175
                End With

                Dim grdColStyle4 As New DataGridTextBoxColumn
                With grdColStyle4
                    .HeaderText = Framework.Columns.Rank.Points
                    .MappingName = Framework.Columns.Rank.Points
                    .Width = 100
                End With

                Dim grdColStyle5 As New DataGridTextBoxColumn
                With grdColStyle5
                    .HeaderText = Framework.Columns.Rank.FieldGoals
                    .MappingName = Framework.Columns.Rank.FieldGoals
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With

                Dim grdColStyle6 As New DataGridTextBoxColumn
                With grdColStyle6
                    .HeaderText = Framework.Columns.Rank.ThreePoints
                    .MappingName = Framework.Columns.Rank.ThreePoints
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With


                Dim grdColStyle7 As New DataGridTextBoxColumn
                With grdColStyle7
                    .HeaderText = Framework.Columns.Rank.FreeThrows
                    .MappingName = Framework.Columns.Rank.FreeThrows
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With


                Dim grdColStyle8 As New DataGridTextBoxColumn
                With grdColStyle8
                    .HeaderText = Framework.Columns.Rank.Rebounds
                    .MappingName = Framework.Columns.Rank.Rebounds
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With


                Dim grdColStyle9 As New DataGridTextBoxColumn
                With grdColStyle9
                    .HeaderText = Framework.Columns.Rank.Assists
                    .MappingName = Framework.Columns.Rank.Assists
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With


                Dim grdColStyle10 As New DataGridTextBoxColumn
                With grdColStyle10
                    .HeaderText = Framework.Columns.Rank.Steals
                    .MappingName = Framework.Columns.Rank.Steals
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With


                Dim grdColStyle11 As New DataGridTextBoxColumn
                With grdColStyle11
                    .HeaderText = Framework.Columns.Rank.Blocks
                    .MappingName = Framework.Columns.Rank.Blocks
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With


                Dim grdColStyle12 As New DataGridTextBoxColumn
                With grdColStyle12
                    .HeaderText = Framework.Columns.Rank.Turnovers
                    .MappingName = Framework.Columns.Rank.Turnovers
                    .Width = 100
                    '.Format = "c" ' This sets the format for currency for a DataGridTextBoxColumn
                End With

                ' Add the column style objects to the tables style's column styles 
                ' collection. If you fail to do this the column styles will not apply.
                Dim style As DataGridColumnStyle() = New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4,
                    grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9, grdColStyle10, grdColStyle11, grdColStyle12}
                grdTableStyle1.GridColumnStyles.AddRange(style)

                ' Again, failure to add the style to the collection will cause the style
                ' to not take effect.
                gridPlayers.TableStyles.Add(grdTableStyle1)
                gridPlayers.TableStyles(0).RowHeadersVisible = False
                IsStyleApplied = True
            End If

            gridPlayers.Refresh()
        End Sub
#End Region


    End Class
End Namespace
