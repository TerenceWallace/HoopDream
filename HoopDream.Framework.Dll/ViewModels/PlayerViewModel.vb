
Imports System.ComponentModel
Imports HoopDream.Framework.Entities

'*************************************************************
' Name:  PlayerViewModel
' Purpose:  Encapsulates business rules and logic
' Description: 
'***************************************************************
Namespace HoopDream.Framework.ViewModels

    Public Class PlayerViewModel

        <Browsable(False)>
        Public ReadOnly Property Entity As Player

        Public Property IsPicked As Boolean
            Get
                Return _Entity.IsPicked
            End Get
            Set
                _Entity.IsPicked = Value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _Entity.Name
            End Get
            Set
                _Entity.Name = Value
            End Set
        End Property

        Public Property PlayerID As Integer
            Get
                Return _Entity.PlayerID
            End Get
            Set
                _Entity.PlayerID = Value
            End Set
        End Property


#Region "Dependent - [Reports]"
        Public Property Reports As IEnumerable(Of Report)

#End Region

#Region "Dependent - [Rosters]"
        Public Property Roster As Roster



        Public Property RosterName() As String
            Get
                Return _Roster.Name
            End Get
            Set
                _Roster.Name = Value
            End Set
        End Property



        Public Property RosterPlayerID() As Integer
            Get
                Return _Roster.PlayerID
            End Get
            Set
                _Roster.PlayerID = Value
            End Set
        End Property



        Public Property RosterPositionID() As Integer
            Get
                Return _Roster.PositionID
            End Get
            Set
                _Roster.PositionID = Value
            End Set
        End Property



        Public Property RosterRosterID() As Integer
            Get
                Return _Roster.RosterID
            End Get
            Set
                _Roster.RosterID = Value
            End Set
        End Property


#End Region

#Region "ViewModel Properties"
        Public Property Rank() As Integer
        Public Property TeamName() As String
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
#End Region

        Public Sub New(ByVal ent As Player)
            _Entity = ent
        End Sub

    End Class
End Namespace
