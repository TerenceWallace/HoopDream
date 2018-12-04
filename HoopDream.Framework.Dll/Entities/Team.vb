
Imports System.ComponentModel

'*************************************************************
' File Name:  Team
' Purpose:  Encapsulates database transmission
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Entities

    <Table(Name:="Teams")> _
    Public Class Team
        Inherits Entity


        Private _Reports As New List(Of Report)
		

        <Column(IsPrimaryKey:=True, IsDbGenerated:=True), DataObjectField(True, True, False)> _
        Public Property TeamID() As Integer


        <Column()>
        Public Overrides Property Name As String

        <Column()> _
        Public Property ShortName As String

        <Association(Name:="TeamReports", Storage:="_Reports", ThisKey:="TeamID", OtherKey:="ReportID")> _
        Public ReadOnly Property Reports() As List(Of Report)
            Get
                Return _Reports
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
			
                sb.Append((("ShortName=" + ShortName.ToString()) + "::"))
			
                sb.Append((("TeamID=" + TeamID.ToString()) + "::"))
			

                Return sb.ToString
            Catch ex As System.Exception
                Return ""
            End Try
        End Function
#End Region

    End Class
End Namespace
