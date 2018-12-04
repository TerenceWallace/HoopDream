
Imports System.ComponentModel
Imports HoopDream.Framework.Entities

'*************************************************************
' Name:  PositionViewModel
' Purpose:  Encapsulates business rules and logic
' Description: 
'***************************************************************
Namespace HoopDream.Framework.ViewModels

    Public Class PositionViewModel

        <Browsable(False)>
        Public ReadOnly Property Entity As Position


        Public Property Name As String
            Get
                Return _Entity.Name
            End Get
            Set
                _Entity.Name = Value
            End Set
        End Property

        Public Property PositionID As Integer
            Get
                Return _Entity.PositionID
            End Get
            Set
                _Entity.PositionID = Value
            End Set
        End Property

        Public Property ShortName As String
            Get
                Return _Entity.ShortName
            End Get
            Set
                _Entity.ShortName = Value
            End Set
        End Property





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


        Public Sub New(ByVal ent As Position)
            _Entity = ent
        End Sub

    End Class
End Namespace
