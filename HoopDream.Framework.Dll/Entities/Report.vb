
Imports System.ComponentModel

'*************************************************************
' File Name:  Report
' Purpose:  Encapsulates database transmission
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Entities

    <Table(Name:="Reports")> _
    Public Class Report
        Inherits Entity

		
        Private _Item As Item
		
        Private _Player As Player
		
        Private _Team As Team


        <Column(IsPrimaryKey:=True, IsDbGenerated:=True), DataObjectField(True, True, False)> _
        Public Property ReportID() As Integer

		 
        <Column()> _
        Public Property ItemID As Integer

        <Column()>
        Public Overrides Property Name As String

        <Column()> _
        Public Property PlayerID As Integer

        <Column()> _
        Public Property TeamID As Integer

        <Column()>
        Public Property Value As Decimal

        <Association(Name:="ReportItem", Storage:="_Item", ThisKey:="ItemID", OtherKey:="ReportID", IsForeignKey:=True)>
        Public Property Item() As Item
            Get
                Return _Item
            End Get
            Set(ByVal value As Item)
                Dim previousValue As Item = _Item
                If (previousValue IsNot value) Then
                    Me.OnPropertyChanging("Item")

                    If previousValue IsNot Nothing Then
                        _Item = Nothing
                        previousValue.Reports.Remove(Me)
                    End If

                    _Item = value
                    If value IsNot Nothing Then
                        value.Reports.Add(Me)
                        Me.ItemID = value.ItemID
                    Else
                        _ItemID = Nothing
                    End If

                    Me.OnPropertyChanged("Item")
                End If
            End Set
        End Property

        <Association(Name:="ReportPlayer", Storage:="_Player", ThisKey:="PlayerID", OtherKey:="ReportID", IsForeignKey:=True)> _
        Public Property Player() As Player
            Get
                Return _Player
            End Get
            Set(ByVal value As Player)
                Dim previousValue As Player = _Player
                If (previousValue IsNot value) Then
                    Me.OnPropertyChanging("Player")

                    If previousValue IsNot Nothing Then
                        _Player = Nothing
                        previousValue.Reports.Remove(Me)
                    End If

                    _Player = value
                    If value IsNot Nothing Then
                        value.Reports.Add(Me)
                        Me.PlayerID = value.PlayerID
                    Else
                        _PlayerID = Nothing
                    End If

                    Me.OnPropertyChanged("Player")
                End If
            End Set
        End Property
		
		 <Association(Name:="ReportTeam", Storage:="_Team", ThisKey:="TeamID", OtherKey:="ReportID", IsForeignKey:=True)> _
        Public Property Team() As Team
            Get
                Return _Team
            End Get
            Set(ByVal value As Team)
                Dim previousValue As Team = _Team
                If (previousValue IsNot value) Then
                    Me.OnPropertyChanging("Team")

                    If previousValue IsNot Nothing Then
                        _Team = Nothing
                        previousValue.Reports.Remove(Me)
                    End If

                    _Team = value
                    If value IsNot Nothing Then
                        value.Reports.Add(Me)
                        Me.TeamID = value.TeamID
                    Else
                        _TeamID = Nothing
                    End If

                    Me.OnPropertyChanged("Team")
                End If
            End Set
        End Property
		
		
		
		
        Public Sub New()
            MyBase.New()
            Me.InitializeClass()
        End Sub

#Region "InitializeClass"
        Private Sub InitializeClass()
            Try
            Catch ex As System.Exception
            End Try
        End Sub
#End Region

#Region "ToString"
        Overrides Function ToString() As String
            Try
                Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder

			
                sb.Append((("ItemID=" + ItemID.ToString()) + "::"))
			
                sb.Append((("Name=" + Name.ToString()) + "::"))
			
                sb.Append((("PlayerID=" + PlayerID.ToString()) + "::"))
			
                sb.Append((("ReportID=" + ReportID.ToString()) + "::"))
			
                sb.Append((("TeamID=" + TeamID.ToString()) + "::"))
			
                sb.Append((("Value=" + Value.ToString()) + "::"))
			

                Return sb.ToString
            Catch ex As System.Exception
                Return ""
            End Try
        End Function
#End Region

    End Class
End Namespace
