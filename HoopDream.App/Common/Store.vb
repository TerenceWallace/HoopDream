

Imports System.ComponentModel
Imports System.Data.SqlServerCe
Imports System.Reflection
Imports Arkitech.Platform.Common
Imports HoopDream.Framework
Imports HoopDream.Framework.Entities

Namespace HoopDream.Common

    Friend NotInheritable Class Store
        Implements INotifyPropertyChanged

        Private Shared _Instance As Store

        Private _selectedPlayer As Player
        Private _previous As Integer = 0

        Private Shared ReadOnly DatabaseConnectionString As String = My.Settings.dbConnectionString
        Private Shared _Database As HoopDream.Framework.Database = Nothing

#Region "Properties"
        Friend Shared ReadOnly Property Instance() As Store
            Get
                If Nothing Is _Instance Then _Instance = New Store()
                Return _Instance
            End Get
        End Property

        Friend Shared ReadOnly Property db As HoopDream.Framework.Database
            Get

                Dim ConnectionString As String = String.Format(DatabaseConnectionString, DataDirectory)
                If _Database Is Nothing Then _Database = New HoopDream.Framework.Database(ConnectionString)

                Return _Database
            End Get
        End Property

        Public Property SelectedPlayer() As Player
            Get
                Return _selectedPlayer
            End Get
            Set(ByVal value As Player)
                If _selectedPlayer IsNot value Then
                    ' Called when the selected item changes
                    Dim pos As Integer = _Players.IndexOf(value)

                    ' See if a new item is selected
                    If _previous <> pos Then
                        '' Check Previous (to mark as read)
                        'If (Not value.Read) Then
                        '    ' Mark as read
                        '    value.Read = True

                        '    ' Decrement unread count
                        '    Me.UnreadCount -= 1
                        'End If

                        ' Set this to previous
                        _previous = pos
                    End If

                    ' Update Selected
                    _selectedPlayer = value
                    OnPropertyChanged("SelectedPlayer")
                End If
            End Set
        End Property

        ' Managers
        Public ReadOnly Property ItemManager As ItemManager = Nothing

        Public ReadOnly Property PlayerManager As PlayerManager = Nothing

        Public ReadOnly Property PositionManager As PositionManager = Nothing

        Public ReadOnly Property ReportManager As ReportManager = Nothing

        Public ReadOnly Property RosterManager As RosterManager = Nothing

        Public ReadOnly Property TeamManager As TeamManager = Nothing


        ' Entities List
        Public ReadOnly Property Items() As IEnumerable(Of Item)

        Public ReadOnly Property Players() As BindingList(Of Player)

        Public ReadOnly Property Positions() As IEnumerable(Of Position)

        Public ReadOnly Property Reports() As IEnumerable(Of Report)

        Public ReadOnly Property Rosters() As IEnumerable(Of Roster)

        Public ReadOnly Property Teams() As BindingList(Of Team)
#End Region

#Region "Constructor"
        Private Sub New()
            ' Create the data connectors
            _ItemManager = New ItemManager(db)
            _PlayerManager = New PlayerManager(db)
            _PositionManager = New PositionManager(db)

            _ReportManager = New ReportManager(db)
            _RosterManager = New RosterManager(db)
            _TeamManager = New TeamManager(db)

            Refresh()

        End Sub
#End Region

#Region "Disconnect"
        Public Sub Disconnect()
            If _Database IsNot Nothing Then _Database = Nothing

            ' Force clients to re-read thier data
            OnPropertyChanged(Nothing)
        End Sub
#End Region

#Region "Refresh"
        Friend Sub Refresh()
            ' Load Items
            Dim items As Array = System.Enum.GetValues(GetType(EntityType))

            For Each item As EntityType In items
                Refresh(New RefreshEntityEventArgs(item))
            Next

        End Sub

        Friend Sub Refresh(ByVal args As RefreshEntityEventArgs)
            Select Case args.Type
                Case EntityType.Items
                    Dim ItemList As List(Of Item) = _ItemManager.GetAll()
                    _Items = New List(Of Item)(ItemList)

                Case EntityType.Rosters
                    Dim RosterList As List(Of Roster) = _RosterManager.GetAll()
                    _Rosters = New List(Of Roster)(RosterList)

                Case EntityType.Positions
                    Dim PositionList As List(Of Position) = _PositionManager.GetAll()
                    PositionList = PositionList.ToList.Where(Function(e) e.Name <> String.Empty).ToList
                    _Positions = New List(Of Position)(PositionList)

                Case EntityType.Players
                    Dim PlayerList As List(Of Player) = _PlayerManager.GetAll()
                    PlayerList = PlayerList.ToList.Where(Function(e) e.Name <> String.Empty).ToList
                    _Players = New SortableBindingList(Of Player)(PlayerList)

                Case EntityType.Reports
                    Dim ReportList As List(Of Report) = _ReportManager.GetAll()
                    _Reports = New List(Of Report)(ReportList)

                Case EntityType.Teams
                    Dim TeamList As List(Of Team) = _TeamManager.GetAll()
                    TeamList = TeamList.ToList.Where(Function(e) e.Name <> String.Empty).ToList
                    _Teams = New SortableBindingList(Of Team)(TeamList)

            End Select
        End Sub
#End Region

#Region "CreateDatabaseObjects"
        ''' <summary>
        ''' When the database is created, we need to initialize it with new tables, relations and possibly data 
        ''' </summary>
        Public Sub CreateDatabaseObjects()
            Dim ScriptFile As String = String.Format(My.Settings.dbScriptFile, DataDirectory)
            If Not File.Exists(ScriptFile) Then Exit Sub
            If Not BackupDatabase() Then Exit Sub

            Dim ConnectionString As String = String.Format(DatabaseConnectionString, DataDirectory)
            VerifyDatabaseExists(ConnectionString)

            ' Grab a reference to the connection on the client provider
            Using connection As New SqlCeConnection(ConnectionString)

                ' To simplify editing and testing TSQL statements, 
                ' the commands are placed in a managed resource of the dll.  
                Dim Script As String = File.OpenText(ScriptFile).ReadToEnd()

                ' Using the SQL Management Studio convention of using GO to identify individual commands
                ' Create a list of commands to execute 
                Dim commands() As String = Script.Split(New String() {"GO"}, StringSplitOptions.RemoveEmptyEntries)

                ' make sure we put the connection back to its previous state
                Dim cmd As New SqlCeCommand()
                cmd.Connection = connection
                connection.Open()

                For Each command As String In commands

                    If command.Length > 5 Then
                        cmd.CommandText = command
                        cmd.ExecuteNonQuery()
                    End If

                Next
            End Using

        End Sub
#End Region

#Region "Backup"
        Private Function BackupDatabase() As Boolean
            Dim IsValid As Boolean = True

            Dim dbBackupFileName As String = String.Format(My.Settings.dbFileName, DataDirectory & "bkup.")
            If File.Exists(dbBackupFileName) Then File.Delete(dbBackupFileName)

            Dim dbFileName As String = String.Format(My.Settings.dbFileName, DataDirectory)
            If Not File.Exists(dbFileName) Then IsValid = False

            FileSystem.Rename(dbFileName, dbBackupFileName)

            Return IsValid
        End Function
#End Region

#Region "VerifyDatabaseExists"
        Public Sub VerifyDatabaseExists(ByVal ConnectionString As String)
            ' we'll use the SqlServerCe connection object to get the database file path

            Using localConnection As New SqlCeConnection(ConnectionString)

                ' The SqlCeConnection.Database contains the file parth portion 
                ' of the database from the full connectionstring
                If Not System.IO.File.Exists(localConnection.Database) Then

                    ' No file, no database
                    Using sqlCeEngine As New SqlCeEngine(ConnectionString)

                        sqlCeEngine.CreateDatabase()
                        sqlCeEngine.Compact(ConnectionString)

                    End Using
                End If

            End Using

        End Sub
#End Region

#Region "INotifyPropertyChanged Members"
        Protected Sub OnPropertyChanged(ByVal prop As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

    End Class

End Namespace
