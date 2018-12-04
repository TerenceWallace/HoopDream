
Imports System.ComponentModel
Imports HoopDream.Framework.Entities

'*************************************************************
' Name:  ReportViewModel
' Purpose:  Encapsulates business rules and logic
' Description: 
'***************************************************************
Namespace HoopDream.Framework.ViewModels

    Public Class ReportViewModel

        <Browsable(False)>
        Public ReadOnly Property Entity As Report


        Public Property ItemID As Integer
            Get
                Return _Entity.ItemID
            End Get
            Set
                _Entity.ItemID = Value
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

        Public Property ReportID As Integer
            Get
                Return _Entity.ReportID
            End Get
            Set
                _Entity.ReportID = Value
            End Set
        End Property

        Public Property TeamID As Integer
            Get
                Return _Entity.TeamID
            End Get
            Set
                _Entity.TeamID = Value
            End Set
        End Property

        Public Property Value As Decimal
            Get
                Return _Entity.Value
            End Get
            Set
                _Entity.Value = Value
            End Set
        End Property



#Region "Parent - [Item]"

        Public Property Item As Item


        Public Property ItemItemID() As Integer
            Get
                Return _Item.ItemID
            End Get
            Set
                _Item.ItemID = Value
            End Set
        End Property

        Public Property ItemName() As String
            Get
                Return _Item.Name
            End Get
            Set
                _Item.Name = Value
            End Set
        End Property

        Public Property ItemShortName() As String
            Get
                Return _Item.ShortName
            End Get
            Set
                _Item.ShortName = Value
            End Set
        End Property


#End Region

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

#Region "Parent - [Team]"

        Public Property Team As Team


        Public Property TeamName() As String
            Get
                Return _Team.Name
            End Get
            Set
                _Team.Name = Value
            End Set
        End Property

        Public Property TeamShortName() As String
            Get
                Return _Team.ShortName
            End Get
            Set
                _Team.ShortName = Value
            End Set
        End Property

        Public Property TeamTeamID() As Integer
            Get
                Return _Team.TeamID
            End Get
            Set
                _Team.TeamID = Value
            End Set
        End Property


#End Region




        Public Sub New(ByVal ent As Report)
            _Entity = ent
        End Sub

    End Class
End Namespace
