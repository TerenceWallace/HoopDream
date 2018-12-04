
Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml
Imports HoopDream.Framework.Entities


Namespace HoopDream.Framework
    Public NotInheritable Class Database
        Inherits FrameworkConnection

        Private Const TableCount As Integer = 6

        Public Event CreatingTables(ByVal Count As Integer)

        Public Event TableCreated(ByVal Increment As Integer)

        Public Event ValidatingTables(ByVal Count As Integer)

        Public Event TableValidated(ByVal Increment As Integer)

        Friend Property IsSaved As Boolean = False

        Friend ReadOnly Property Items() As IEnumerable(Of Item)
            Get
                Return From ent In Table(Of Item)()
            End Get
        End Property

        Friend ReadOnly Property Players() As IEnumerable(Of Player)
            Get
                Return From ent In Table(Of Player)()
            End Get
        End Property

        Friend ReadOnly Property Reports() As IEnumerable(Of Report)
            Get
                Return From ent In Table(Of Report)()
            End Get
        End Property

        Friend ReadOnly Property Positions() As IEnumerable(Of Position)
            Get
                Return From ent In Table(Of Position)()
            End Get
        End Property

        Friend ReadOnly Property Rosters() As IEnumerable(Of Roster)
            Get
                Return From ent In Table(Of Roster)()
            End Get
        End Property

        Friend ReadOnly Property Teams() As IEnumerable(Of Team)
            Get
                Return From ent In Table(Of Team)()
            End Get
        End Property

        Public Sub New(ByVal inConnectionString As String)
            MyBase.New(inConnectionString)
            MyBase.Start()
        End Sub

        ''' <summary>
        ''' The order of table initialization is important for relationship associations
        ''' </summary>
        Protected Overrides Sub OnDatabaseCreated()
            RaiseEvent CreatingTables(TableCount)

        End Sub

        Protected Overrides Sub OnDatabaseStarted()
            RaiseEvent ValidatingTables(TableCount)
            Dim Count As Integer = 0

        End Sub

    End Class
End Namespace
