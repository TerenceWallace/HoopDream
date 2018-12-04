
Imports System.ComponentModel

'*************************************************************
' File Name:  Player
' Purpose:  Encapsulates database transmission
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Entities

    <Table(Name:="Players")> _
    Public Class Player
        Inherits Entity


        Private _Reports As New List(Of Report)
		
        Private _Rosters As New List(Of Roster)
		

        <Column(IsPrimaryKey:=True, IsDbGenerated:=True), DataObjectField(True, True, False)> _
        Public Property PlayerID() As Integer

		 
        <Column()> _
        Public Property IsPicked As Boolean

        <Column()>
        Public Overrides Property Name As String


        <Association(Name:="PlayerReports", Storage:="_Reports", ThisKey:="PlayerID", OtherKey:="ReportID")> _
        Public ReadOnly Property Reports() As List(Of Report)
            Get
                Return _Reports
            End Get
        End Property
		
        <Association(Name:="PlayerRosters", Storage:="_Rosters", ThisKey:="PlayerID", OtherKey:="RosterID")> _
        Public ReadOnly Property Rosters() As List(Of Roster)
            Get
                Return _Rosters
            End Get
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

			
                sb.Append((("IsPicked=" + IsPicked.ToString()) + "::"))
			
                sb.Append((("Name=" + Name.ToString()) + "::"))
			
                sb.Append((("PlayerID=" + PlayerID.ToString()) + "::"))
			

                Return sb.ToString
            Catch ex As System.Exception
                Return ""
            End Try
        End Function
#End Region

    End Class
End Namespace
