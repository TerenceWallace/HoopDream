
Imports System.ComponentModel
Imports HoopDream.Framework.Entities

'*************************************************************
' Name:  TeamViewModel
' Purpose:  Encapsulates business rules and logic
' Description: 
'***************************************************************
Namespace HoopDream.Framework.ViewModels

    Public Class TeamViewModel

        <Browsable(False)>
        Public ReadOnly Property Entity As Team


        Public Property Name As String
            Get
                Return _Entity.Name
            End Get
            Set
                _Entity.Name = Value
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

        Public Property TeamID As Integer
            Get
                Return _Entity.TeamID
            End Get
            Set
                _Entity.TeamID = Value
            End Set
        End Property





#Region "Dependent - [Reports]"
        Public Property Report As Report



        Public Property ReportItemID() As Integer
            Get
                Return _Report.ItemID
            End Get
            Set
                _Report.ItemID = Value
            End Set
        End Property



        Public Property ReportName() As String
            Get
                Return _Report.Name
            End Get
            Set
                _Report.Name = Value
            End Set
        End Property



        Public Property ReportPlayerID() As Integer
            Get
                Return _Report.PlayerID
            End Get
            Set
                _Report.PlayerID = Value
            End Set
        End Property



        Public Property ReportReportID() As Integer
            Get
                Return _Report.ReportID
            End Get
            Set
                _Report.ReportID = Value
            End Set
        End Property



        Public Property ReportTeamID() As Integer
            Get
                Return _Report.TeamID
            End Get
            Set
                _Report.TeamID = Value
            End Set
        End Property



        Public Property ReportValue() As Decimal
            Get
                Return _Report.Value
            End Get
            Set
                _Report.Value = Value
            End Set
        End Property


#End Region


        Public Sub New(ByVal ent As Team)
            _Entity = ent
        End Sub

    End Class
End Namespace
