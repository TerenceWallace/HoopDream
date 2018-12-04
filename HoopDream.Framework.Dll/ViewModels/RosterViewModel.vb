
Imports System.ComponentModel
Imports HoopDream.Framework.Entities

'*************************************************************
' Name:  RosterViewModel
' Purpose:  Encapsulates business rules and logic
' Description: 
'***************************************************************
Namespace HoopDream.Framework.ViewModels

    Public Class RosterViewModel

        <Browsable(False)>
        Public ReadOnly Property Entity As Roster


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

        Public Property PositionID As Integer
            Get
                Return _Entity.PositionID
            End Get
            Set
                _Entity.PositionID = Value
            End Set
        End Property

        Public Property RosterID As Integer
            Get
                Return _Entity.RosterID
            End Get
            Set
                _Entity.RosterID = Value
            End Set
        End Property



#Region "Parent - [Player]"

        Public Property Player As Player


        Public Property PlayerIsPicked() As Boolean
            Get
                Return _Player.IsPicked
            End Get
            Set
                _Player.IsPicked = Value
            End Set
        End Property

        Public Property PlayerName() As String
            Get
                Return _Player.Name
            End Get
            Set
                _Player.Name = Value
            End Set
        End Property

        Public Property PlayerPlayerID() As Integer
            Get
                Return _Player.PlayerID
            End Get
            Set
                _Player.PlayerID = Value
            End Set
        End Property


#End Region

#Region "Parent - [Position]"

        Public Property Position As Position


        Public Property PositionName() As String
            Get
                Return _Position.Name
            End Get
            Set
                _Position.Name = Value
            End Set
        End Property

        Public Property PositionPositionID() As Integer
            Get
                Return _Position.PositionID
            End Get
            Set
                _Position.PositionID = Value
            End Set
        End Property

        Public Property PositionShortName() As String
            Get
                Return _Position.ShortName
            End Get
            Set
                _Position.ShortName = Value
            End Set
        End Property


#End Region




        Public Sub New(ByVal ent As Roster)
            _Entity = ent
        End Sub

    End Class
End Namespace
