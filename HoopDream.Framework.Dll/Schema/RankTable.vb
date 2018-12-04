'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml
Imports HoopDream.Framework.Entities

Namespace HoopDream.Framework.Schema

    <System.Diagnostics.DebuggerStepThrough()>
    Public Class RankTable
        Inherits DataTable
        Implements System.Collections.IEnumerable

        Friend ReadOnly Property PlayerIDColumn() As DataColumn

        Friend ReadOnly Property RankColumn() As DataColumn

        Friend ReadOnly Property NameColumn() As DataColumn

        Friend ReadOnly Property TeamColumn As DataColumn


        ''' <summary>
        '''  Ranks
        ''' </summary>
        Friend ReadOnly Property PointsColumn As DataColumn

        Friend ReadOnly Property FieldGoalsColumn As DataColumn

        Friend ReadOnly Property FreeThrowsColumn As DataColumn
        Friend ReadOnly Property ThreePointsColumn As DataColumn
        Friend ReadOnly Property ReboundsColumn As DataColumn
        Friend ReadOnly Property AssistsColumn As DataColumn
        Friend ReadOnly Property StealsColumn As DataColumn
        Friend ReadOnly Property BlocksColumn As DataColumn
        Friend ReadOnly Property TurnoversColumn As DataColumn

        Public Sub New()
            MyBase.New(Framework.Columns.Rank.RankTable)
            InitClass()
        End Sub

        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Prefix = table.Prefix
            MinimumCapacity = table.MinimumCapacity
            DisplayExpression = table.DisplayExpression
        End Sub

        <System.ComponentModel.Browsable(False)>
        Public ReadOnly Property Count() As Integer
            Get
                Return Rows.Count
            End Get
        End Property

        Default Public ReadOnly Property Item(ByVal index As Integer) As RankRow
            Get
                Return CType(Rows(index), RankRow)
            End Get
        End Property


        Public Overloads Sub AddPlayerRow(ByVal row As RankRow)
            Rows.Add(row)
        End Sub

        Public Function FindByPrimaryKey(ByVal PlayerID As Integer) As RankRow
            Return CType(Rows.Find(New Object() {PlayerID}), RankRow)
        End Function

        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Rows.GetEnumerator
        End Function

        Public Overrides Function Clone() As DataTable
            Dim cln As RankTable = CType(MyBase.Clone, RankTable)
            cln.InitVars()
            Return cln
        End Function

        Protected Overrides Function CreateInstance() As DataTable
            Return New RankTable()
        End Function

        Friend Sub InitVars()
            _PlayerIDColumn = Columns(Framework.Columns.Rank.PlayerID)
            _RankColumn = Columns(Framework.Columns.Rank.Rank)
            _NameColumn = Columns(Framework.Columns.Rank.Name)
            _TeamColumn = Columns(Framework.Columns.Rank.Team)
            _PointsColumn = Columns(Framework.Columns.Rank.Points)
            _FieldGoalsColumn = Columns(Framework.Columns.Rank.FieldGoals)
            _ThreePointsColumn = Columns(Framework.Columns.Rank.ThreePoints)
            _FreeThrowsColumn = Columns(Framework.Columns.Rank.FreeThrows)
            _ReboundsColumn = Columns(Framework.Columns.Rank.Rebounds)
            _AssistsColumn = Columns(Framework.Columns.Rank.Assists)
            _StealsColumn = Columns(Framework.Columns.Rank.Steals)
            _BlocksColumn = Columns(Framework.Columns.Rank.Blocks)
            _TurnoversColumn = Columns(Framework.Columns.Rank.Turnovers)
        End Sub

        Private Sub InitClass()
            '' 
            '' PlayerIDColumn
            ''
            _PlayerIDColumn = New DataColumn(Framework.Columns.Rank.PlayerID, GetType(Integer), Nothing, System.Data.MappingType.Element)
            Columns.Add(_PlayerIDColumn)
            _PlayerIDColumn.AllowDBNull = True
            _PlayerIDColumn.Caption = Framework.Columns.Rank.PlayerID
            _PlayerIDColumn.DefaultValue = 0

            '' 
            '' RankColumn
            ''
            _RankColumn = New DataColumn(Framework.Columns.Rank.Rank, GetType(Integer), Nothing, System.Data.MappingType.Element)
            Columns.Add(_RankColumn)
            _RankColumn.AllowDBNull = True
            _RankColumn.Caption = Framework.Columns.Rank.Rank
            _RankColumn.DefaultValue = 0

            '' 
            '' NameColumn
            ''
            _NameColumn = New DataColumn(Framework.Columns.Rank.Name, GetType(String), Nothing, System.Data.MappingType.Element)
            Columns.Add(_NameColumn)
            _NameColumn.AllowDBNull = True
            _NameColumn.Caption = Framework.Columns.Rank.Name
            _NameColumn.DefaultValue = String.Empty

            '' 
            '' TeamColumn
            ''
            _TeamColumn = New DataColumn(Framework.Columns.Rank.Team, GetType(String), Nothing, System.Data.MappingType.Element)
            Columns.Add(_TeamColumn)
            _TeamColumn.AllowDBNull = True
            _TeamColumn.Caption = Framework.Columns.Rank.Team
            _TeamColumn.DefaultValue = String.Empty

            ''
            '' Ranks
            ''' ============================================
            ''' 
            '' PointsColumn
            ''
            _PointsColumn = New DataColumn(Framework.Columns.Rank.Points, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_PointsColumn)
            _PointsColumn.AllowDBNull = True
            _PointsColumn.Caption = Framework.Columns.Rank.Points
            _PointsColumn.DefaultValue = 0.0D

            ''
            '' ThreePointsColumn
            ''
            _ThreePointsColumn = New DataColumn(Framework.Columns.Rank.ThreePoints, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_ThreePointsColumn)
            _ThreePointsColumn.AllowDBNull = True
            _ThreePointsColumn.Caption = Framework.Columns.Rank.ThreePoints
            _ThreePointsColumn.DefaultValue = 0.0D
            ''
            '' FieldGoalsColumn
            ''
            _FieldGoalsColumn = New DataColumn(Framework.Columns.Rank.FieldGoals, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_FieldGoalsColumn)
            _FieldGoalsColumn.AllowDBNull = True
            _FieldGoalsColumn.Caption = Framework.Columns.Rank.FieldGoals
            _FieldGoalsColumn.DefaultValue = 0.0D

            ''
            '' FreeThrowsColumn
            ''
            _FreeThrowsColumn = New DataColumn(Framework.Columns.Rank.FreeThrows, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_FreeThrowsColumn)
            _FreeThrowsColumn.AllowDBNull = True
            _FreeThrowsColumn.Caption = Framework.Columns.Rank.FreeThrows
            _FreeThrowsColumn.DefaultValue = 0.0D
            ''
            '' ReboundsColumn
            ''
            _ReboundsColumn = New DataColumn(Framework.Columns.Rank.Rebounds, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_ReboundsColumn)
            _ReboundsColumn.AllowDBNull = True
            _ReboundsColumn.Caption = Framework.Columns.Rank.Rebounds
            _ReboundsColumn.DefaultValue = 0.0D
            ''
            '' AssistsColumn
            ''
            _AssistsColumn = New DataColumn(Framework.Columns.Rank.Assists, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_AssistsColumn)
            _AssistsColumn.AllowDBNull = True
            _AssistsColumn.Caption = Framework.Columns.Rank.Assists
            _AssistsColumn.DefaultValue = 0.0D
            ''
            '' StealsColumn
            ''
            _StealsColumn = New DataColumn(Framework.Columns.Rank.Steals, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_StealsColumn)
            _StealsColumn.AllowDBNull = True
            _StealsColumn.Caption = Framework.Columns.Rank.Steals
            _StealsColumn.DefaultValue = 0.0D
            ''
            '' BlocksColumn
            ''
            _BlocksColumn = New DataColumn(Framework.Columns.Rank.Blocks, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_BlocksColumn)
            _BlocksColumn.AllowDBNull = True
            _BlocksColumn.Caption = Framework.Columns.Rank.Blocks
            _BlocksColumn.DefaultValue = 0.0D
            ''
            '' TurnoversColumn
            ''
            _TurnoversColumn = New DataColumn(Framework.Columns.Rank.Turnovers, GetType(Decimal), Nothing, System.Data.MappingType.Element)
            Columns.Add(_TurnoversColumn)
            _TurnoversColumn.AllowDBNull = True
            _TurnoversColumn.Caption = Framework.Columns.Rank.Turnovers
            _TurnoversColumn.DefaultValue = 0.0D
        End Sub

        Public Function NewPlayerRow() As RankRow
            Return CType(NewRow, RankRow)
        End Function

        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New RankRow(builder)
        End Function

        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RankRow)
        End Function

        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
        End Sub

        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
        End Sub

        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
        End Sub

        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
        End Sub

        Public Sub RemovePlayerRow(ByVal row As RankRow)
            Rows.Remove(row)
        End Sub

        Public Overloads Function AddPlayerRow(ByVal PlayerID As Integer, ByVal IsPicked As Boolean, ByVal Name As String) As RankRow
            Dim rowTableRow As RankRow = CType(NewRow, RankRow)
            rowTableRow.ItemArray = New Object() {PlayerID, IsPicked, Name}
            Rows.Add(rowTableRow)
            Return rowTableRow
        End Function
    End Class
End Namespace
