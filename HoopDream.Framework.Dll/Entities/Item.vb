
Imports System.ComponentModel

'*************************************************************
' File Name:  Item
' Purpose:  Encapsulates database transmission
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Entities

    <Table(Name:="Items")> _
    Public Class Item
        Inherits Entity



        Private _Reports As New List(Of Report)
		

        <Column(IsPrimaryKey:=True, IsDbGenerated:=True), DataObjectField(True, True, False)> _
        Public Property ItemID() As Integer

        <Column()>
        Public Overrides Property Name As String

        <Column()>
        Public Property ShortName As String

        <Association(Name:="ItemReports", Storage:="_Reports", ThisKey:="ItemID", OtherKey:="ReportID")>
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

			
                sb.Append((("ItemID=" + ItemID.ToString()) + "::"))
			
                sb.Append((("Name=" + Name.ToString()) + "::"))
			
                sb.Append((("ShortName=" + ShortName.ToString()) + "::"))
			

                Return sb.ToString
            Catch ex As System.Exception
                Return ""
            End Try
        End Function
#End Region

    End Class
End Namespace
