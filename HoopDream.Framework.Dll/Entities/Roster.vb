
Imports System.ComponentModel

'*************************************************************
' File Name:  Roster
' Purpose:  Encapsulates database transmission
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Entities

    <Table(Name:="Rosters")> _
    Public Class Roster
        Inherits Entity

		
        Private _Player As Player
		
        Private _Position As Position


        <Column(IsPrimaryKey:=True, IsDbGenerated:=True), DataObjectField(True, True, False)> _
        Public Property RosterID() As Integer

        <Column()>
        Public Overrides Property Name As String

        <Column()> _
        Public Property PlayerID As Integer 
		 
        <Column()> _
        Public Property PositionID As Integer

        <Association(Name:="RosterPlayer", Storage:="_Player", ThisKey:="PlayerID", OtherKey:="RosterID", IsForeignKey:=True)>
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
                        previousValue.Rosters.Remove(Me)
                    End If

                    _Player = value
                    If value IsNot Nothing Then
                        value.Rosters.Add(Me)
                        Me.PlayerID = value.PlayerID
                    Else
                        _PlayerID = Nothing
                    End If

                    Me.OnPropertyChanged("Player")
                End If
            End Set
        End Property

        <Association(Name:="RosterPosition", Storage:="_Position", ThisKey:="PositionID", OtherKey:="RosterID", IsForeignKey:=True)> _
        Public Property Position() As Position
            Get
                Return _Position
            End Get
            Set(ByVal value As Position)
                Dim previousValue As Position = _Position
                If (previousValue IsNot value) Then
                    Me.OnPropertyChanging("Position")

                    If previousValue IsNot Nothing Then
                        _Position = Nothing
                        previousValue.Rosters.Remove(Me)
                    End If

                    _Position = value
                    If value IsNot Nothing Then
                        value.Rosters.Add(Me)
                        Me.PositionID = value.PositionID
                    Else
                        _PositionID = Nothing
                    End If

                    Me.OnPropertyChanged("Position")
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

			
                sb.Append((("Name=" + Name.ToString()) + "::"))
			
                sb.Append((("PlayerID=" + PlayerID.ToString()) + "::"))
			
                sb.Append((("PositionID=" + PositionID.ToString()) + "::"))
			
                sb.Append((("RosterID=" + RosterID.ToString()) + "::"))
			

                Return sb.ToString
            Catch ex As System.Exception
                Return ""
            End Try
        End Function
#End Region

    End Class
End Namespace
