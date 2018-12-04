
Imports System.ComponentModel

'*************************************************************
' File Name:  Position
' Purpose:  Encapsulates database transmission
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Entities

    <Table(Name:="Positions")> _
    Public Class Position
        Inherits Entity

        Private _Rosters As New List(Of Roster)

        <Column(IsPrimaryKey:=True, IsDbGenerated:=True), DataObjectField(True, True, False)>
        Public Property PositionID() As Integer

        <Column()>
        Public Overrides Property Name As String


        <Column()> _
        Public Property ShortName As String

        <Association(Name:="PositionRosters", Storage:="_Rosters", ThisKey:="PositionID", OtherKey:="RosterID")> _
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

			
                sb.Append((("Name=" + Name.ToString()) + "::"))
			
                sb.Append((("PositionID=" + PositionID.ToString()) + "::"))
			
                sb.Append((("ShortName=" + ShortName.ToString()) + "::"))
			

                Return sb.ToString
            Catch ex As System.Exception
                Return ""
            End Try
        End Function
#End Region

    End Class
End Namespace
